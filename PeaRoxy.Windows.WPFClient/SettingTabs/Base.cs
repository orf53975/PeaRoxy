﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PeaRoxy.Windows.WPFClient.SettingTabs
{
    public class Base : UserControl, ISynchronizeInvoke
    {
        public bool AutoSave { get; set; }
        internal bool isLoading = true;
        public virtual void SaveSettings() { return; }
        public virtual void LoadSettings() { return; }
        public virtual void SetEnable(bool enable)
        {
            this.IsEnabled = enable;
        }
        public Base() { }

        public IAsyncResult BeginInvoke(Delegate method, object[] args)
        {
            throw new NotImplementedException();
        }
        public object EndInvoke(IAsyncResult result)
        {
            throw new NotImplementedException();
        }
        public object Invoke(Delegate method, object[] args)
        {
            return this.Dispatcher.Invoke(method, args);
        }
        public bool InvokeRequired
        {
            get { return true; }
        }
    }
}
