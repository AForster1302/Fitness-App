using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyWorkoutRoutines
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public int userid;

        public MainWindow()
        {
            this.Hide();
            InitializeComponent();
            WindowLogin();

        }

        //MyWorkoutRoutinesEntities ctx = new MyWorkoutRoutinesEntities();
        
        private void DrawWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Close_Program(object sender, RoutedEventArgs e)
        {
            Close();          
        }


        private void WindowNormalMaximize()
        {
            switch (WindowState)
            {
                case WindowState.Maximized:
                    MaximizeProgram.Content = "🗖";
                    WindowState = WindowState.Normal;
                    ParentBorder.CornerRadius = new CornerRadius(15, 15, 15, 15);
                    break;
                case WindowState.Normal:
                    MaximizeProgram.Content = "🗗";
                    WindowState = WindowState.Maximized;
                    ParentBorder.CornerRadius = new CornerRadius(0);
                    break;
            }
        }

        private void Maximize_Program(object sender, RoutedEventArgs e)
        {
            WindowNormalMaximize();
        }

        private void Minimize_Program(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        public void WindowLogin()
        {
            WindowLogin windowLogin = new WindowLogin(this);
            windowLogin.Show();
        }

        private void btnCreateRoutine(object sender, RoutedEventArgs e)
        {
            PanelCreatingRoutine();
        }

        private void btnRoutines(object sender, RoutedEventArgs e)
        {
            PanelRoutines();
        }

        public void CreatingRoutine()
        {
            CreatingRoutine creatingRoutine = new CreatingRoutine(this);
            Main.Content = creatingRoutine;
        }

        public void PanelCreatingRoutine()
        {
            PanelCreatingRoutine creatingRoutine = new PanelCreatingRoutine(this);
            Main.Content = creatingRoutine;
        }

        public void PanelRoutines()
        {
            PanelRoutines creatingRoutine = new PanelRoutines(this);
            Main.Content = creatingRoutine;
        }
    }
}