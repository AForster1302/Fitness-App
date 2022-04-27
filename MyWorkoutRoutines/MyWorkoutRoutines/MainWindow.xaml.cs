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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            if (e.LeftButton == MouseButtonState.Pressed)
            {
                //wip
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
                    TitleDrawBar.CornerRadius = new CornerRadius(25, 15, 0, 0);
                    break;
                case WindowState.Normal:
                    MaximizeProgram.Content = "🗗";
                    WindowState = WindowState.Maximized;
                    TitleDrawBar.CornerRadius = new CornerRadius(0);
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
    }
}
