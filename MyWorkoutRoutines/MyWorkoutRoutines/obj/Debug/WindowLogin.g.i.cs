﻿#pragma checksum "..\..\WindowLogin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3098AF8C0FD7D464A8C19995FDED829BA289DA781288D327A4595E1630DD9CC0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using MyWorkoutRoutines;
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


namespace MyWorkoutRoutines {
    
    
    /// <summary>
    /// WindowLogin
    /// </summary>
    public partial class WindowLogin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\WindowLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MyWorkoutRoutines.WindowLogin Login;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WindowLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid left;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WindowLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.UserControl LoginUC;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\WindowLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Username;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\WindowLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lUsername;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\WindowLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PWBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\WindowLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lPassword;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\WindowLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label showPassword;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\WindowLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckboxPW;
        
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
            System.Uri resourceLocater = new System.Uri("/MyWorkoutRoutines;component/windowlogin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowLogin.xaml"
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
            this.Login = ((MyWorkoutRoutines.WindowLogin)(target));
            
            #line 10 "..\..\WindowLogin.xaml"
            this.Login.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Login_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.left = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.LoginUC = ((System.Windows.Controls.UserControl)(target));
            return;
            case 4:
            
            #line 20 "..\..\WindowLogin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_Program);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 23 "..\..\WindowLogin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Minimize_Program);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Username = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\WindowLogin.xaml"
            this.Username.LostFocus += new System.Windows.RoutedEventHandler(this.Username_LostFocus);
            
            #line default
            #line hidden
            
            #line 30 "..\..\WindowLogin.xaml"
            this.Username.GotFocus += new System.Windows.RoutedEventHandler(this.Username_GotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lUsername = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.PWBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 41 "..\..\WindowLogin.xaml"
            this.PWBox.LostFocus += new System.Windows.RoutedEventHandler(this.PWBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 42 "..\..\WindowLogin.xaml"
            this.PWBox.GotFocus += new System.Windows.RoutedEventHandler(this.PWBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 42 "..\..\WindowLogin.xaml"
            this.PWBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.PWBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lPassword = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.showPassword = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.CheckboxPW = ((System.Windows.Controls.CheckBox)(target));
            
            #line 54 "..\..\WindowLogin.xaml"
            this.CheckboxPW.Checked += new System.Windows.RoutedEventHandler(this.CheckboxPW_Checked);
            
            #line default
            #line hidden
            
            #line 54 "..\..\WindowLogin.xaml"
            this.CheckboxPW.Unchecked += new System.Windows.RoutedEventHandler(this.CheckboxPW_Unchecked);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 56 "..\..\WindowLogin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Login);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 67 "..\..\WindowLogin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Register);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

