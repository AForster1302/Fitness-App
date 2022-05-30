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
using System.Windows.Shapes;

namespace MyWorkoutRoutines
{
    /// <summary>
    /// Interaktionslogik für PanelStartRoutine.xaml
    /// </summary>
    public partial class PanelStartRoutine : UserControl
    {
        MainWindow mainWindow;
        MyWorkoutRoutinesCtx context = new MyWorkoutRoutinesCtx();
        ICollectionView CollectionView;
        int RoutineID;
        int ExerciseIndex = 0;
        List<Exercise> exercises;

        public PanelStartRoutine(MainWindow _mainWindow, int routineID)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            RoutineID = routineID;

            RoutineName.Content = context.Routine.Where(r => r.RoutineID == RoutineID).FirstOrDefault().RoutineName;

            var query =
                from routineExercise in context.RoutineExercises
                join exercise in context.Exercise on routineExercise.ExerciseID equals exercise.ExerciseID
                join routine in context.Routine on routineExercise.RoutineID equals routine.RoutineID
                where routine.RoutineID == routineID
                select exercise;
            exercises = query.ToList();

            ExerciseName.Content = exercises[0].ExerciseName;
            ExerciseDescription.Text = exercises[0].Description;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            context.Routine.Load();
            context.RoutineExercises.Load();
            context.Exercise.Load();
            CollectionView = CollectionViewSource.GetDefaultView(context.Routine.Local);
            ParentGrid.DataContext = CollectionView;
        }

        private void btnNextClick(object sender, RoutedEventArgs e)
        {
            if (ExerciseIndex < exercises.Count() - 1)
            {
                ExerciseIndex++;
                ExerciseName.Content = exercises[ExerciseIndex].ExerciseName;
                ExerciseDescription.Text = exercises[ExerciseIndex].Description;

                if (ExerciseIndex == exercises.Count() - 1)
                {
                    ExerciseIndex = exercises.Count() - 1;
                    btnFinish.Visibility = Visibility.Visible;
                }
            }
            if (exercises.Count() == 1)
            {
                btnFinish.Visibility = Visibility.Visible;
            }
        }

        private void btnPreviousClick(object sender, RoutedEventArgs e)
        {
            if (ExerciseIndex != 0)
            {
                ExerciseIndex--;
                if (ExerciseIndex >= exercises.Count())
                {
                    return;
                }
                ExerciseName.Content = exercises[ExerciseIndex].ExerciseName;
                ExerciseDescription.Text = exercises[ExerciseIndex].Description;
                btnFinish.Visibility = Visibility.Hidden;
            }
        }

        private void btnFinishClick(object sender, RoutedEventArgs e)
        {
            RoutineHistory rH = new RoutineHistory();
            rH.DateHistory = DateTime.Now;
            rH.RoutineID = RoutineID;
            rH.UserID = mainWindow.userid;
            context.RoutineHistory.Add(rH);
            context.SaveChanges();
            mainWindow.PanelRoutines();
            ExerciseIndex = 0;
        }

        private void btnBack(object sender, RoutedEventArgs e)
        {
            mainWindow.PanelRoutines();
        }
    }
}
