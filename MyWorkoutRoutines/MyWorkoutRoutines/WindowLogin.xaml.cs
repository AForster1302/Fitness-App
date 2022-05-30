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
            if (Username.Text != "" && PWBox.Password != "" && CheckPassword())
            {

                using (MyWorkoutRoutinesCtx ctx = new MyWorkoutRoutinesCtx())
                {
                    mainWindow.userid = ctx.Users.Where(x => x.UserName == Username.Text).FirstOrDefault().UserID;
                    mainWindow.Show();
                    mainWindow.PanelHomeScreen();
                    this.Close();
                }

            }

            else if (Username.Text == "")
            {
                MessageBox.Show("Geben Sie Ihren Nutzernamen ein.");
            }

            else if (PWBox.Password == "")
            {
                MessageBox.Show("Geben Sie Ihr Passwort ein.");
            }

            else
            {
                MessageBox.Show("Falscher Nutzername oder Passwort. \nVersuchen Sie es erneut.");
                PWBox.Password = "";
            }
        }

        public bool CheckPassword()
        {
            string salt = GetSaltFromDB();
            bool hashesMatch;

            if (salt != "")
            {
                byte[] saltBytes = Convert.FromBase64String(salt);
                Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(PWBox.Password, saltBytes);
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
            using (MyWorkoutRoutinesCtx ctx = new MyWorkoutRoutinesCtx())
            {
                return ctx.Users.Where(x => x.UserName == Username.Text).FirstOrDefault().HashPassword;
            }
        }

        private string GetSaltFromDB()
        {
            using (MyWorkoutRoutinesCtx ctx = new MyWorkoutRoutinesCtx())
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
                PWBox.Focus();
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
            PWBox.Clear();
        }

        private void Username_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Username.Clear();
        }

        public void LoginShow()
        {
            Login.Show();
        }

        private void PWBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Username.Text != "" && PWBox.Password != "" && CheckPassword())
                {

                    using (MyWorkoutRoutinesCtx ctx = new MyWorkoutRoutinesCtx())
                    {
                        mainWindow.userid = ctx.Users.Where(x => x.UserName == Username.Text).FirstOrDefault().UserID;
                        mainWindow.Show();
                        mainWindow.PanelHomeScreen(); 
                        this.Close();
                    }

                }

                else if (Username.Text == "")
                {
                    MessageBox.Show("Geben Sie Ihren Nutzernamen ein.");
                }

                else if (PWBox.Password == "")
                {
                    MessageBox.Show("Geben Sie Ihr Passwort ein.");
                }

                else
                {
                    MessageBox.Show("Falscher Nutzername oder Passwort. \nVersuchen Sie es erneut.");
                    PWBox.Password = "";
                }
            }
        }

        private void Username_GotFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Username.Text))
            {
                lUsername.Visibility = Visibility.Hidden;
            }
        }

        private void PWBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(PWBox.Password))
            {
                lPassword.Visibility = Visibility.Hidden;
            }
        }

        private void Username_LostFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Username.Text))
            {
                lUsername.Visibility = Visibility.Visible;
            }
        }

        private void PWBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(PWBox.Password))
            {
                lPassword.Visibility = Visibility.Visible;
            }
        }

        private void CheckboxPW_Checked(object sender, RoutedEventArgs e)
        {
            string passWord = PWBox.Password;
            showPassword.Content = passWord;
            lPassword.Visibility = Visibility.Hidden;
            PWBox.Foreground = Brushes.Transparent;
            showPassword.Visibility = Visibility.Visible;
            PWBox.IsHitTestVisible = false;
        }

        private void CheckboxPW_Unchecked(object sender, RoutedEventArgs e)
        {
            showPassword.Visibility = Visibility.Hidden;
            lPassword.Visibility = Visibility.Hidden;
            PWBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#404040"));
            PWBox.IsHitTestVisible = true;
            if (String.IsNullOrEmpty(PWBox.Password))
            {
                lPassword.Visibility = Visibility.Visible;
            }
        }

    }
}
