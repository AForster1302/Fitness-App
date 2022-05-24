﻿#pragma checksum "..\..\WindowLogin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "607D0D05CAE1FCD3E4213CEEBE02F17561C5A3D91308F97B431BA23F1D54986B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
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
        
        
        #line 17 "..\..\WindowLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid left;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\WindowLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.UserControl LoginUC;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\WindowLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Username;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\WindowLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\WindowLogin.xaml"
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
            
            #line 25 "..\..\WindowLogin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_Program);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 28 "..\..\WindowLogin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Minimize_Program);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Username = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\WindowLogin.xaml"
            this.Username.GotFocus += new System.Windows.RoutedEventHandler(this.Username_GotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PasswordBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\WindowLogin.xaml"
            this.PasswordBox.GotFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 44 "..\..\WindowLogin.xaml"
            this.PasswordBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.PasswordBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CheckboxPW = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            
            #line 55 "..\..\WindowLogin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Login);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 66 "..\..\WindowLogin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Register);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

