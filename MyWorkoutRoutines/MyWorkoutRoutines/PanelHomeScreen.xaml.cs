using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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
    /// Interaktionslogik für PanelHomeScreen.xaml
    /// </summary>
    public partial class PanelHomeScreen : UserControl
    {
        MainWindow mainWindow;
        ICollectionView collectionView;
        DateTime dtSelectedDate;

        public MyWorkoutRoutinesCtx context = new MyWorkoutRoutinesCtx();

        public PanelHomeScreen(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;

            UserName.Text = "Eingeloggt als: " + context.Users.Where(u => u.UserID == mainWindow.userid).FirstOrDefault().UserName;
        }

        private void HomeScreenPage_Loaded(object sender, RoutedEventArgs e)
        {
            context.Users.Load();
            collectionView = CollectionViewSource.GetDefaultView(context.Users.Local);
            ParentGrid.DataContext = collectionView;
        }

        private void Calendar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Calendar.SelectedDate == null) return;
            dtSelectedDate = (DateTime)Calendar.SelectedDate;
            Calendar.SelectedDate = null;
            Calendar.BlackoutDates.Add(new CalendarDateRange(dtSelectedDate));
        }

        private void Calendar_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Calendar.SelectedDate != null) return;
            dtSelectedDate = (DateTime)Calendar.SelectedDate;
            Calendar.SelectedDate = null;
            Calendar.BlackoutDates.Remove(new CalendarDateRange(dtSelectedDate));
        }

        private void btnSafeDays_Click(object sender, RoutedEventArgs e)
        {
            Reminders reminders = new Reminders();
            reminders.CalendarDate = dtSelectedDate;
            context.SaveChanges();
        }
    }
}
