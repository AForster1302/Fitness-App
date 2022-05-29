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
        WindowLogin windowLogin;

        public WindowRegister(MainWindow _mainWindow, WindowLogin _windowLogin)
        { 
            InitializeComponent();
            windowLogin = _windowLogin;
            mainWindow = _mainWindow;

        }

        private void Register(object sender, RoutedEventArgs e)
        {
            bool passwordCheck = CheckPassword();
            bool usernameCheck = CheckUsername();

            if (!usernameCheck)
            {
                MessageBox.Show("Dieser Nutzername existiert bereits.");
            }

            else if (!passwordCheck)
            {
                MessageBox.Show("Die Passwörter müssen identisch sein.");
            }

            else
            {
                using (MyWorkoutRoutinesEntities2 ctx = new MyWorkoutRoutinesEntities2())
                {
                    Users newUser = new Users();
                    newUser.UserName = Username.Text;

                    Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(PWBox.Password, 32);
                    byte[] hash = rfc2898DeriveBytes.GetBytes(20);
                    byte[] salt = rfc2898DeriveBytes.Salt;

                    newUser.Salt = Convert.ToBase64String(salt);
                    newUser.HashPassword = Convert.ToBase64String(hash);
                    ctx.Users.Add(newUser);
                    ctx.SaveChanges();
                }

                MessageBox.Show("Ihr Account wurde erfolgreich erstellt.");
                
                Registration.Close();
                windowLogin.Show();
            }
        }

        private bool CheckPassword()
        {
            if (PWBox.Password != PWBoxRepeat.Password)
            {
                return false;
            }

            else if (PWBox.Password.Length == 0)
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
            using (MyWorkoutRoutinesEntities2 ctx = new MyWorkoutRoutinesEntities2())
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
                PWBox.Focus();
            }
        }

        private void PWBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                PWBoxRepeat.Focus();
            }
        }

        private void PWBoxRepeat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Register(sender, e);
            }
        }

        private void Close_Program(object sender, RoutedEventArgs e)
        {
            Close();
            windowLogin.Close();
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


        private void Back(object sender, RoutedEventArgs e)
        {
            mainWindow.WindowLogin();
            Registration.Close();
            windowLogin.Close();
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

        private void PWBoxRepeat_GotFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(PWBoxRepeat.Password))
            {
                lPasswordRepeat.Visibility = Visibility.Hidden;
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

        private void PWBoxRepeat_LostFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(PWBoxRepeat.Password))
            {
                lPasswordRepeat.Visibility = Visibility.Visible;
            }
        }

        private void CheckboxPW_Checked(object sender, RoutedEventArgs e)
        {
            string passWord = PWBox.Password;
            string passWordRepeat = PWBoxRepeat.Password;
            lshowPassword.Content = passWord;
            lshowPasswordRepeat.Content = passWordRepeat;
            lPassword.Visibility = Visibility.Hidden;
            lPasswordRepeat.Visibility = Visibility.Hidden;
            PWBox.Foreground = Brushes.Transparent;
            PWBoxRepeat.Foreground = Brushes.Transparent;
            lshowPassword.Visibility = Visibility.Visible;
            lshowPasswordRepeat.Visibility = Visibility.Visible;
            PWBox.IsHitTestVisible = false;
            PWBoxRepeat.IsHitTestVisible = false;
        }

        private void CheckboxPW_Unchecked(object sender, RoutedEventArgs e)
        {
            lshowPassword.Visibility = Visibility.Hidden;
            lshowPasswordRepeat.Visibility = Visibility.Hidden;
            lPassword.Visibility = Visibility.Hidden;
            lPasswordRepeat.Visibility = Visibility.Hidden;
            PWBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#404040"));
            PWBoxRepeat.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#404040"));
            PWBox.IsHitTestVisible = true;
            PWBoxRepeat.IsHitTestVisible = true;
            if (String.IsNullOrEmpty(PWBox.Password))
            {
                lPassword.Visibility = Visibility.Visible;
            }
            if (String.IsNullOrEmpty(PWBoxRepeat.Password))
            {
                lPasswordRepeat.Visibility = Visibility.Visible;
            }
        }
    }
}
