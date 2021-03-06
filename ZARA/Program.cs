﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="PeaRoxy.com">
//   PeaRoxy by PeaRoxy.com is licensed under a Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License .
//   Permissions beyond the scope of this license may be requested by sending email to PeaRoxy's Dev Email .
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ZARA
{
    #region

    using System;
    using System.Windows.Forms;

    #endregion

    /// <summary>
    /// The program.
    /// </summary>
    internal static class Program
    {
        #region Public Properties

        /// <summary>
        /// Gets the notify.
        /// </summary>
        public static NotifyIcon Notify { get; private set; }

        #endregion

        #region Methods

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Notify = new NotifyIcon { Visible = false };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Main());
        }

        #endregion
    }
}