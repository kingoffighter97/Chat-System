﻿#pragma checksum "..\..\Lobby.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "298359286D35E67FB8615EE843A95128"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MsgClient;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MsgClient {
    
    
    /// <summary>
    /// Lobby
    /// </summary>
    public partial class Lobby : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\Lobby.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblServerName;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Lobby.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblChatName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Lobby.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbOnlineUsers;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Lobby.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRefreshOnlineList;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Lobby.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblOnlineUsers;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MsgClient;component/lobby.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Lobby.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 16 "..\..\Lobby.xaml"
            ((MsgClient.Lobby)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblServerName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblChatName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lbOnlineUsers = ((System.Windows.Controls.ListBox)(target));
            
            #line 20 "..\..\Lobby.xaml"
            this.lbOnlineUsers.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.lbOnlineUsers_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnRefreshOnlineList = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Lobby.xaml"
            this.btnRefreshOnlineList.Click += new System.Windows.RoutedEventHandler(this.btnRefreshOnlineList_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblOnlineUsers = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
