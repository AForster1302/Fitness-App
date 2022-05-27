﻿using System;
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

                    Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Password.Text, 32);
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
            Username.Text = string.Empty;
            Username.GotFocus -= Username_GotFocus;
        }

        private void Password_GotFocus(object sender, RoutedEventArgs e)
        {
            Password.Text = string.Empty;
            Password.GotFocus -= Password_GotFocus;
        }

        private void RepeatPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            RepeatPassword.Text = string.Empty;
            RepeatPassword.GotFocus -= RepeatPassword_GotFocus;
        }

    }
}
