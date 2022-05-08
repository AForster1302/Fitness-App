using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyWorkoutRoutines
{
    /// <summary>
    /// Interaktionslogik für WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        MainWindow mainWindow;
        public WindowLogin(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            Username.Focus();
        
        }

        public WindowLogin()
        {
            InitializeComponent();
        }

        //public void WindowRegister()
        //{
        //    WindowRegister windowRegister = new WindowRegister();
        //    mainWindow.Content = windowRegister;
        //}

        private void Close_Program(object sender, RoutedEventArgs e)
        {
            Close();
            mainWindow.Close();
        }

        private void WindowNormalMaximize()
        {
            switch (WindowState)
            {
                case WindowState.Maximized:
                    MaximizeProgram.Content = "🗖";
                    WindowState = WindowState.Normal;
                    break;
                case WindowState.Normal:
                    MaximizeProgram.Content = "🗗";
                    WindowState = WindowState.Maximized;
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


        private void Login_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            if (Username.Text != "" && Password.Text != "" && CheckPassword())
            {

                using (MyWorkoutRoutines_Entities ctx = new MyWorkoutRoutines_Entities())
                {
                   mainWindow.userid = ctx.Users.Where(x => x.UserName == Username.Text).FirstOrDefault().UserID;

                    mainWindow.Show();
                    this.Close();
                }
                    
            }

            else if (Username.Text == "")
            {
                MessageBox.Show("You need to type in your username.");
            }

            else if (Password.Text == "")
            {
                MessageBox.Show("You need to type in your password.");
            }

            else
            {
                MessageBox.Show("Wrong password or username. \nPlease try again.");
                Password.Text = "";
            }
        }

        public bool CheckPassword()
        {
            string salt = GetSaltFromDB();
            bool hashesMatch;

            if (salt != "")
            {
                byte[] saltBytes = Convert.FromBase64String(salt);
                Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Password.Text, saltBytes);
                byte[] enteredHash = rfc2898DeriveBytes.GetBytes(20);
                string str = Convert.ToBase64String(enteredHash);
                string expectedHash = GetHashFromDB();

                hashesMatch = str.Equals(expectedHash);
            }
            else
            {
                hashesMatch = false;
            }

            return hashesMatch;
        }

        private string GetHashFromDB()
        {
            using (MyWorkoutRoutines_Entities ctx = new MyWorkoutRoutines_Entities())
            {
                return ctx.Users.Where(x => x.UserName == Username.Text).FirstOrDefault().HashPassword;
            }
        }

        private string GetSaltFromDB()
        {
            using (MyWorkoutRoutines_Entities ctx = new MyWorkoutRoutines_Entities())
            {
                if (ctx.Users.Where(x => x.UserName == Username.Text).Count() > 0)
                {
                    return ctx.Users.Where(x => x.UserName == Username.Text).FirstOrDefault().Salt;
                }

                return "";
            }
        }


        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Password.Focus();
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Login(sender, e);
            }
        }

        

        private void Register(object sender, RoutedEventArgs e)
        {
            WindowRegister windowRegister = new WindowRegister();
            windowRegister.Show();
            Login.Hide();

        }

    }
}
