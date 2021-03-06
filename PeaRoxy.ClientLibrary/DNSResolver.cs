﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DnsResolver.cs" company="PeaRoxy.com">
//   PeaRoxy by PeaRoxy.com is licensed under a Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License .
//   Permissions beyond the scope of this license may be requested by sending email to PeaRoxy's Dev Email .
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace PeaRoxy.ClientLibrary
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;
    using System.Threading.Tasks;

    using PeaRoxy.CommonLibrary;

    /// <summary>
    ///     DNS Resolver class is responsible for resolving DNS requests on port 53
    /// </summary>
    public class DnsResolver : IDisposable
    {
        private readonly ProxyController parent;

        private Socket dnsTcpListenerSocket;

        private Socket dnsUdpListenerSocket;

        private IPEndPoint localDnsIp;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DnsResolver" /> class.
        /// </summary>
        /// <param name="parent">
        ///     The parent proxy controller class to forward DNS requests.
        /// </param>
        public DnsResolver(ProxyController parent)
        {
            this.parent = parent;
            this.DnsResolverServerIp = IPAddress.Parse("8.8.4.4");
            this.DnsResolverSupported = true;
            this.DnsResolverUdpSupported = true;
        }

        /// <summary>
        ///     Gets or sets the DNS resolver IP to forward the requests.
        /// </summary>
        public IPAddress DnsResolverServerIp { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether we should response to the TCP requests.
        /// </summary>
        public bool DnsResolverSupported { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether we should response to the UDP requests.
        /// </summary>
        public bool DnsResolverUdpSupported { get; set; }

        public void Dispose()
        {
            this.dnsTcpListenerSocket.Dispose();
            this.dnsUdpListenerSocket.Dispose();
        }

        internal void Accepting()
        {
            try
            {
                if (this.DnsResolverSupported && this.dnsTcpListenerSocket.Poll(0, SelectMode.SelectRead))
                {
                    ProxyClient c = new ProxyClient(this.dnsTcpListenerSocket.Accept(), this.parent)
                                        {
                                            ReceivePacketSize
                                                =
                                                this.parent
                                                .ReceivePacketSize,
                                            SendPacketSize
                                                =
                                                this.parent
                                                .SendPacketSize,
                                            NoDataTimeOut =
                                                10,
                                            RequestType =
                                                ProxyClient
                                                .RequestTypes
                                                .Dns,
                                            IsSendingStarted
                                                = true,
                                        };
                    lock (this.parent.ConnectedClients) this.parent.ConnectedClients.Add(c);
                    this.parent.ActiveServer.Clone().Establish(this.DnsResolverServerIp.ToString(), 53, c);
                }

                if (this.DnsResolverSupported && this.DnsResolverUdpSupported)
                {
                    if (this.dnsUdpListenerSocket == null)
                    {
                        this.dnsUdpListenerSocket = new Socket(
                            AddressFamily.InterNetwork,
                            SocketType.Dgram,
                            ProtocolType.Udp) { EnableBroadcast = true };
                        this.dnsUdpListenerSocket.Bind(this.localDnsIp);
                    }

                    try
                    {
                        if (this.dnsUdpListenerSocket.Poll(0, SelectMode.SelectRead))
                        {
                            byte[] globalBuffer = new byte[500];
                            EndPoint remoteEp = new IPEndPoint(IPAddress.Any, 0);
                            int i = this.dnsUdpListenerSocket.ReceiveFrom(globalBuffer, ref remoteEp);
                            byte[] buffer = new byte[i + 2];
                            Array.Copy(globalBuffer, 0, buffer, 2, i);
                            Task.Factory.StartNew(
                                delegate
                                    {
                                        try
                                        {
                                            buffer[0] = (byte)Math.Floor((double)i / 256);
                                            buffer[1] = (byte)(i % 256);

                                            IPAddress ip = this.parent.Ip;

                                            // Connecting to our self on same port, But TCP
                                            if (ip.Equals(IPAddress.Any))
                                            {
                                                ip = IPAddress.Loopback;
                                            }

                                            Socket tcpLinkForUdp = new Socket(
                                                AddressFamily.InterNetwork,
                                                SocketType.Stream,
                                                ProtocolType.Tcp);
                                            tcpLinkForUdp.Connect(ip, 53);

                                            tcpLinkForUdp.Send(buffer);
                                            buffer = new byte[tcpLinkForUdp.ReceiveBufferSize];
                                            i = tcpLinkForUdp.Receive(buffer);
                                            if (i != 0)
                                            {
                                                int neededBytes = (buffer[0] * 256) + buffer[1] + 2;
                                                Array.Resize(ref buffer, Math.Max(i, neededBytes));
                                                if (i < neededBytes)
                                                {
                                                    int timeout = Environment.TickCount + 2000;
                                                    int received = i;
                                                    while (received < neededBytes && timeout > Environment.TickCount
                                                           && Common.IsSocketConnected(tcpLinkForUdp))
                                                    {
                                                        i = tcpLinkForUdp.Receive(
                                                            buffer,
                                                            received,
                                                            buffer.Length - received,
                                                            SocketFlags.None);
                                                        received += i;
                                                        if (i == 0)
                                                        {
                                                            break;
                                                        }

                                                        Thread.Sleep(16);
                                                    }
                                                }
                                            }

                                            this.dnsUdpListenerSocket.SendTo(
                                                buffer,
                                                2,
                                                buffer.Length - 2,
                                                SocketFlags.None,
                                                remoteEp);
                                        }
                                        catch (Exception
                                            e)
                                        {
                                            ProxyController.LogIt("DNS Resolver UDP Error: " + e.Message);
                                        }
                                    });
                        }
                    }
                    catch (Exception)
                    {
                        this.dnsUdpListenerSocket.Close();
                        this.dnsUdpListenerSocket = null;
                    }
                }
            }
            catch
            {
            }
        }

        /// <summary>
        ///     Starting the resolving/forwarding process and listening for the requests.
        /// </summary>
        public void Start()
        {
            if (this.DnsResolverSupported)
            {
                this.localDnsIp = new IPEndPoint(this.parent.Ip, 53);
                this.dnsTcpListenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this.dnsTcpListenerSocket.Bind(this.localDnsIp);
                this.dnsTcpListenerSocket.Listen(256);
            }
        }

        /// <summary>
        ///     Stopping the resolving/forwarding process.
        /// </summary>
        public void Stop()
        {
            try
            {
                if (this.DnsResolverSupported)
                {
                    this.dnsTcpListenerSocket.Close();
                    if (this.DnsResolverUdpSupported && this.dnsUdpListenerSocket != null)
                    {
                        this.dnsUdpListenerSocket.Close();
                        this.dnsUdpListenerSocket = null;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}