﻿#pragma checksum "..\..\PanelCreatingRoutine.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1D251A2A6A6EE64280AB065B5DA67B765A43FB19639D8B928DC1DE5843C6F22D"
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
    /// PanelCreatingRoutine
    /// </summary>
    public partial class PanelCreatingRoutine : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\PanelCreatingRoutine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MyWorkoutRoutines.PanelCreatingRoutine CreateRoutinePage;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\PanelCreatingRoutine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.UserControl Pagee;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\PanelCreatingRoutine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listboxExercises;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\PanelCreatingRoutine.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpload;
        
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
            System.Uri resourceLocater = new System.Uri("/MyWorkoutRoutines;component/panelcreatingroutine.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PanelCreatingRoutine.xaml"
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
            this.CreateRoutinePage = ((MyWorkoutRoutines.PanelCreatingRoutine)(target));
            
            #line 8 "..\..\PanelCreatingRoutine.xaml"
            this.CreateRoutinePage.Loaded += new System.Windows.RoutedEventHandler(this.CreateRoutinePage_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Pagee = ((System.Windows.Controls.UserControl)(target));
            return;
            case 3:
            this.listboxExercises = ((System.Windows.Controls.ListBox)(target));
            
            #line 12 "..\..\PanelCreatingRoutine.xaml"
            this.listboxExercises.Loaded += new System.Windows.RoutedEventHandler(this.ListBox_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 19 "..\..\PanelCreatingRoutine.xaml"
            ((System.Windows.Controls.ListBox)(target)).Loaded += new System.Windows.RoutedEventHandler(this.ListBox_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnUpload = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\PanelCreatingRoutine.xaml"
            this.btnUpload.Click += new System.Windows.RoutedEventHandler(this.btnCreatingRoutine);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
