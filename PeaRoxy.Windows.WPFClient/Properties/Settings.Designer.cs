﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PeaRoxy.Windows.WPFClient.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public byte Server_Type {
            get {
                return ((byte)(this["Server_Type"]));
            }
            set {
                this["Server_Type"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public byte Auth_Type {
            get {
                return ((byte)(this["Auth_Type"]));
            }
            set {
                this["Auth_Type"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PeaRoxySocks_Address {
            get {
                return ((string)(this["PeaRoxySocks_Address"]));
            }
            set {
                this["PeaRoxySocks_Address"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("80")]
        public ushort PeaRoxySocks_Port {
            get {
                return ((ushort)(this["PeaRoxySocks_Port"]));
            }
            set {
                this["PeaRoxySocks_Port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PeaRoxyWeb_Address {
            get {
                return ((string)(this["PeaRoxyWeb_Address"]));
            }
            set {
                this["PeaRoxyWeb_Address"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserAndPassword_User {
            get {
                return ((string)(this["UserAndPassword_User"]));
            }
            set {
                this["UserAndPassword_User"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserAndPassword_Pass {
            get {
                return ((string)(this["UserAndPassword_Pass"]));
            }
            set {
                this["UserAndPassword_Pass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string Proxy_Address {
            get {
                return ((string)(this["Proxy_Address"]));
            }
            set {
                this["Proxy_Address"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1080")]
        public ushort Proxy_Port {
            get {
                return ((ushort)(this["Proxy_Port"]));
            }
            set {
                this["Proxy_Port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Proxy_SOCKS {
            get {
                return ((bool)(this["Proxy_SOCKS"]));
            }
            set {
                this["Proxy_SOCKS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Proxy_HTTP {
            get {
                return ((bool)(this["Proxy_HTTP"]));
            }
            set {
                this["Proxy_HTTP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Proxy_HTTPS {
            get {
                return ((bool)(this["Proxy_HTTPS"]));
            }
            set {
                this["Proxy_HTTPS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("proxy.pac")]
        public string AutoConfig_Address {
            get {
                return ((string)(this["AutoConfig_Address"]));
            }
            set {
                this["AutoConfig_Address"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoConfig_KeepRuning {
            get {
                return ((bool)(this["AutoConfig_KeepRuning"]));
            }
            set {
                this["AutoConfig_KeepRuning"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoConfig_Enable {
            get {
                return ((bool)(this["AutoConfig_Enable"]));
            }
            set {
                this["AutoConfig_Enable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public byte AutoConfig_Mime {
            get {
                return ((byte)(this["AutoConfig_Mime"]));
            }
            set {
                this["AutoConfig_Mime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6000")]
        public ushort Connection_NoDataTimeout {
            get {
                return ((ushort)(this["Connection_NoDataTimeout"]));
            }
            set {
                this["Connection_NoDataTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public byte Connection_Encryption {
            get {
                return ((byte)(this["Connection_Encryption"]));
            }
            set {
                this["Connection_Encryption"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Startup_StartServer {
            get {
                return ((bool)(this["Startup_StartServer"]));
            }
            set {
                this["Startup_StartServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Startup_ShowWindow {
            get {
                return ((bool)(this["Startup_ShowWindow"]));
            }
            set {
                this["Startup_ShowWindow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1024")]
        public uint Connection_SendPacketSize {
            get {
                return ((uint)(this["Connection_SendPacketSize"]));
            }
            set {
                this["Connection_SendPacketSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8192")]
        public uint Connection_RecPacketSize {
            get {
                return ((uint)(this["Connection_RecPacketSize"]));
            }
            set {
                this["Connection_RecPacketSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public byte Connection_Compression {
            get {
                return ((byte)(this["Connection_Compression"]));
            }
            set {
                this["Connection_Compression"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Smart_HTTP_Enable {
            get {
                return ((bool)(this["Smart_HTTP_Enable"]));
            }
            set {
                this["Smart_HTTP_Enable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Smart_HTTP_AutoRoute_Enable {
            get {
                return ((bool)(this["Smart_HTTP_AutoRoute_Enable"]));
            }
            set {
                this["Smart_HTTP_AutoRoute_Enable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Smart_HTTP_AutoRoute_Pattern {
            get {
                return ((string)(this["Smart_HTTP_AutoRoute_Pattern"]));
            }
            set {
                this["Smart_HTTP_AutoRoute_Pattern"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Smart_HTTPS_Enable {
            get {
                return ((bool)(this["Smart_HTTPS_Enable"]));
            }
            set {
                this["Smart_HTTPS_Enable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Smart_SOCKS_Enable {
            get {
                return ((bool)(this["Smart_SOCKS_Enable"]));
            }
            set {
                this["Smart_SOCKS_Enable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public ushort Smart_Timeout_Value {
            get {
                return ((ushort)(this["Smart_Timeout_Value"]));
            }
            set {
                this["Smart_Timeout_Value"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Smart_Timeout_Enable {
            get {
                return ((bool)(this["Smart_Timeout_Enable"]));
            }
            set {
                this["Smart_Timeout_Enable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Smart_Direct_Port80Router {
            get {
                return ((bool)(this["Smart_Direct_Port80Router"]));
            }
            set {
                this["Smart_Direct_Port80Router"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Smart_HTTP_List {
            get {
                return ((string)(this["Smart_HTTP_List"]));
            }
            set {
                this["Smart_HTTP_List"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Smart_Direct_List {
            get {
                return ((string)(this["Smart_Direct_List"]));
            }
            set {
                this["Smart_Direct_List"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PeaRoxySocks_Domain {
            get {
                return ((string)(this["PeaRoxySocks_Domain"]));
            }
            set {
                this["PeaRoxySocks_Domain"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxyServer_Address {
            get {
                return ((string)(this["ProxyServer_Address"]));
            }
            set {
                this["ProxyServer_Address"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1080")]
        public ushort ProxyServer_Port {
            get {
                return ((ushort)(this["ProxyServer_Port"]));
            }
            set {
                this["ProxyServer_Port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ProxyServer_Type {
            get {
                return ((int)(this["ProxyServer_Type"]));
            }
            set {
                this["ProxyServer_Type"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DNS_Enable {
            get {
                return ((bool)(this["DNS_Enable"]));
            }
            set {
                this["DNS_Enable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8.8.8.8")]
        public string DNS_IPAddress {
            get {
                return ((string)(this["DNS_IPAddress"]));
            }
            set {
                this["DNS_IPAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ErrorRenderer_EnableHTTP {
            get {
                return ((bool)(this["ErrorRenderer_EnableHTTP"]));
            }
            set {
                this["ErrorRenderer_EnableHTTP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ErrorRenderer_Enable443 {
            get {
                return ((bool)(this["ErrorRenderer_Enable443"]));
            }
            set {
                this["ErrorRenderer_Enable443"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ErrorRenderer_Enable80 {
            get {
                return ((bool)(this["ErrorRenderer_Enable80"]));
            }
            set {
                this["ErrorRenderer_Enable80"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Connection_StopOnInterrupt {
            get {
                return ((bool)(this["Connection_StopOnInterrupt"]));
            }
            set {
                this["Connection_StopOnInterrupt"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Smart_Direct_AutoRoutePort80AsHTTP {
            get {
                return ((bool)(this["Smart_Direct_AutoRoutePort80AsHTTP"]));
            }
            set {
                this["Smart_Direct_AutoRoutePort80AsHTTP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10.0.0.0")]
        public string TAP_IPRange {
            get {
                return ((string)(this["TAP_IPRange"]));
            }
            set {
                this["TAP_IPRange"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Grabber {
            get {
                return ((int)(this["Grabber"]));
            }
            set {
                this["Grabber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool FirstRun {
            get {
                return ((bool)(this["FirstRun"]));
            }
            set {
                this["FirstRun"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Smart_AntiDNS_Enable {
            get {
                return ((bool)(this["Smart_AntiDNS_Enable"]));
            }
            set {
                this["Smart_AntiDNS_Enable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Smart_AntiDNSPattern {
            get {
                return ((string)(this["Smart_AntiDNSPattern"]));
            }
            set {
                this["Smart_AntiDNSPattern"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int Accepting_Wait {
            get {
                return ((int)(this["Accepting_Wait"]));
            }
            set {
                this["Accepting_Wait"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int Routing_Wait {
            get {
                return ((int)(this["Routing_Wait"]));
            }
            set {
                this["Routing_Wait"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("firefox\r\niexplore\r\nchrome\r\nopera\r\nsafari\r\nrockmelt\r\ndeepnet\r\nmaxthon\r\nseamonkey\r\n" +
            "idman\r\ndap")]
        public string Hook_Processes {
            get {
                return ((string)(this["Hook_Processes"]));
            }
            set {
                this["Hook_Processes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public int Settings_Version {
            get {
                return ((int)(this["Settings_Version"]));
            }
            set {
                this["Settings_Version"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Welcome_Shown {
            get {
                return ((bool)(this["Welcome_Shown"]));
            }
            set {
                this["Welcome_Shown"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SelectedProfile {
            get {
                return ((string)(this["SelectedProfile"]));
            }
            set {
                this["SelectedProfile"] = value;
            }
        }
    }
}
