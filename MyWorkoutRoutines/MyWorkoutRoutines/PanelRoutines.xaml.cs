using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
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
    /// Interaktionslogik für PanelRoutines.xaml
    /// </summary>
    public partial class PanelRoutines : UserControl
    {

        
        MyWorkoutRoutinesCtx context = new MyWorkoutRoutinesCtx();
        ICollectionView CollectionView;

        MainWindow mainWindow;
        public PanelRoutines(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }


        private void CreateRoutinePage_Loaded(object sender, RoutedEventArgs e)
        {
            context.Routine.Load();
            CollectionView = CollectionViewSource.GetDefaultView(context.Routine.Where(r => r.UserID == mainWindow.userid).ToList());
            ParentGrid.DataContext = CollectionView;
        }

        private void btnPlayRoutine(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Routine r = button.DataContext as Routine;
            mainWindow.PanelStartRoutines(r.RoutineID);
        }

        private void delRoutine_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Routine ra = button.DataContext as Routine;

            var routineExerciseQuery =
                from routineExercise in context.RoutineExercises
                where routineExercise.RoutineID == ra.RoutineID
                select routineExercise;

            var routineHistoryQuery =
                from routineHistory in context.RoutineHistory
                where routineHistory.RoutineID == ra.RoutineID
                select routineHistory;

            context.RoutineExercises.RemoveRange(routineExerciseQuery.ToList());
            context.RoutineHistory.RemoveRange(routineHistoryQuery.ToList());
            context.Routine.Remove(ra);
            context.SaveChanges();
            routineList.ItemsSource = null;
            context.Routine.Load();
            CollectionView = CollectionViewSource.GetDefaultView(context.Routine.Where(r => r.UserID == mainWindow.userid).ToList());
            routineList.ItemsSource = CollectionView;

        }

    }
}