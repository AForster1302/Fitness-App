#pragma checksum "..\..\PanelHomeScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AA11D396A5FE45C07E4660456F87D19036012ECB00314716AF826BA800F465A5"
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
    /// PanelHomeScreen
    /// </summary>
    public partial class PanelHomeScreen : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\PanelHomeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MyWorkoutRoutines.PanelHomeScreen HomeScreenPage;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\PanelHomeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ParentGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\PanelHomeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar Calendar;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\PanelHomeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSafeDays;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\PanelHomeScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserName;
        
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
            System.Uri resourceLocater = new System.Uri("/MyWorkoutRoutines;component/panelhomescreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PanelHomeScreen.xaml"
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
            this.HomeScreenPage = ((MyWorkoutRoutines.PanelHomeScreen)(target));
            
            #line 8 "..\..\PanelHomeScreen.xaml"
            this.HomeScreenPage.Loaded += new System.Windows.RoutedEventHandler(this.HomeScreenPage_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ParentGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Calendar = ((System.Windows.Controls.Calendar)(target));
            
            #line 23 "..\..\PanelHomeScreen.xaml"
            this.Calendar.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Calendar_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 23 "..\..\PanelHomeScreen.xaml"
            this.Calendar.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Calendar_MouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSafeDays = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\PanelHomeScreen.xaml"
            this.btnSafeDays.Click += new System.Windows.RoutedEventHandler(this.btnSafeDays_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UserName = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

