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
            if (Username.Text != "" && PasswordBox.Text != "" && CheckPassword())
            {

                using (MyWorkoutRoutinesEntities2 ctx = new MyWorkoutRoutinesEntities2())
                {
                    mainWindow.userid = ctx.Users.Where(x => x.UserName == Username.Text).FirstOrDefault().UserID;
                    //wip after Registration
                    mainWindow.Show();
                    mainWindow.PanelHomeScreen();
                    this.Close();
                }

            }

            else if (Username.Text == "")
            {
                MessageBox.Show("Geben Sie Ihren Nutzernamen ein.");
            }

            else if (PasswordBox.Text == "")
            {
                MessageBox.Show("Geben Sie Ihr Passwort ein.");
            }

            else
            {
                MessageBox.Show("Falscher Nutzername oder Passwort. \nVersuchen Sie es erneut.");
                PasswordBox.Text = "";
            }
        }

        public bool CheckPassword()
        {
            string salt = GetSaltFromDB();
            bool hashesMatch;

            if (salt != "")
            {
                byte[] saltBytes = Convert.FromBase64String(salt);
                Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(PasswordBox.Text, saltBytes);
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
            using (MyWorkoutRoutinesEntities2 ctx = new MyWorkoutRoutinesEntities2())
            {
                return ctx.Users.Where(x => x.UserName == Username.Text).FirstOrDefault().HashPassword;
            }
        }

        private string GetSaltFromDB()
        {
            using (MyWorkoutRoutinesEntities2 ctx = new MyWorkoutRoutinesEntities2())
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
                PasswordBox.Focus();
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
            WindowRegister windowRegister = new WindowRegister(mainWindow, this);
            windowRegister.Show();
            Login.Hide();

        }

        private void Password_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PasswordBox.Clear();
        }

        private void Username_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Username.Clear();
        }

        public void LoginShow()
        {
            Login.Show();
        }


        private void Username_GotFocus(object sender, RoutedEventArgs e)
        {
            Username.Text = string.Empty;
            Username.GotFocus -= Username_GotFocus;
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox.Text = string.Empty;
            PasswordBox.GotFocus -= PasswordBox_GotFocus;
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Username.Text != "" && PasswordBox.Text != "" && CheckPassword())
                {

                    using (MyWorkoutRoutinesEntities2 ctx = new MyWorkoutRoutinesEntities2())
                    {
                        mainWindow.userid = ctx.Users.Where(x => x.UserName == Username.Text).FirstOrDefault().UserID;
                        //wip after Registration
                        mainWindow.Show();
                        mainWindow.PanelHomeScreen(); 
                        this.Close();
                    }

                }

                else if (Username.Text == "")
                {
                    MessageBox.Show("Geben Sie Ihren Nutzernamen ein.");
                }

                else if (PasswordBox.Text == "")
                {
                    MessageBox.Show("Geben Sie Ihr Passwort ein.");
                }

                else
                {
                    MessageBox.Show("Falscher Nutzername oder Passwort. \nVersuchen Sie es erneut.");
                    PasswordBox.Text = "";
                }
            }
        }

    }
}
