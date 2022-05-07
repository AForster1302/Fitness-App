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
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace MyWorkoutRoutines
{
    /// <summary>
    /// Interaktionslogik für WindowRegister.xaml
    /// </summary>
    public partial class WindowRegister : Window
    {
        MainWindow mainWindow;
        public WindowRegister(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            Username.Focus();
        }

        public WindowRegister()
        {
            InitializeComponent();
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            bool passwordCheck = CheckPassword();
            bool usernameCheck = CheckUsername();

            if (!usernameCheck)
            {
                MessageBox.Show("This username already exists.");
            }

            else if (!passwordCheck)
            {
                MessageBox.Show("Both passwords must be identical.");
            }


            else
            {
                using (MyWorkoutRoutines_Entities ctx = new MyWorkoutRoutines_Entities())
                {
                    Users newUser = new Users();
                    newUser.UserName = Username.Text;

                    Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Password.Text, 32);
                    byte[] hash = rfc2898DeriveBytes.GetBytes(20);
                    byte[] salt = rfc2898DeriveBytes.Salt;

                    newUser.Salt = Convert.ToBase64String(salt);
                    newUser.HashPassword = Convert.ToBase64String(hash);
                    ctx.Users.Add(newUser);
                    ctx.SaveChanges();
                }

                MessageBox.Show("Your user account was successfully created.");
                Registration.Hide();
                
            }
        }

        private bool CheckPassword()
        {
            if (Password.Text != RepeatPassword.Text)
            {
                return false;
            }

            else if (Password.Text.Length == 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private bool CheckUsername()
        {
            using (MyWorkoutRoutines_Entities ctx = new MyWorkoutRoutines_Entities())
            {
                if (ctx.Users.Where(x => x.UserName == Username.Text).Count() > 0)
                {
                    return false;
                }

                else
                {
                    return true;
                }
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
                RepeatPassword.Focus();
            }
        }

        private void RepeatPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Register(sender, e);
            }
        }

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


        private void Back(object sender, RoutedEventArgs e)
        {
            mainWindow.WindowLogin();
        }
    }
}
