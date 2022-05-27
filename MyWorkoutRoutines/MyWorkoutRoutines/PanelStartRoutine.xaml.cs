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
        MyWorkoutRoutinesEntities2 context = new MyWorkoutRoutinesEntities2();
        ICollectionView CollectionView;
        int RoutineID;
        int ExerciseIndex = 0;
        int exid;
        List<Exercise> exercises;

        public PanelStartRoutine(MainWindow _mainWindow, int routineID)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            RoutineID = routineID;

            RoutineName.Content = context.Routine.Where(r => r.RoutineID == RoutineID).FirstOrDefault().RoutineName;
            //ExerciseName.Content = "Übung: " + context.Exercise.Where(re => re.ExerciseID == RoutineID ).FirstOrDefault().ExerciseName;
            
            //ExerciseName.Content = context.Exercise.Where(r => r.RoutineID == RoutineID).FirstOrDefault().RoutineName;
            //ExerciseDescription.Text = context.Exercise.Where(e => e.ExerciseID == RoutineID).FirstOrDefault().Description;
            
            //exid = context.RoutineExercises.Where(re => re.RoutineID == RoutineID).FirstOrDefault().ExerciseID;
            //context.Routine.Where(r => r.RoutineID == RoutineID).
            var query =
                from routineExercise in context.RoutineExercises
                join exercise in context.Exercise on routineExercise.ExerciseID equals exercise.ExerciseID
                join routine in context.Routine on routineExercise.RoutineID equals routine.RoutineID
                where routine.RoutineID == routineID
                select exercise;
            exercises = query.ToList();

            ExerciseName.Content = exercises[ExerciseIndex].ExerciseName;
            ExerciseDescription.Text = exercises[ExerciseIndex].Description;

            List<RoutineExercises> routineExercises = context.RoutineExercises.Where(routineExercise => routineExercise.ExerciseID == exid).ToList();
            //List<Exercise> exercises = context.Exercise.SelectMany(x => x.RoutineExercises.Where(y => y.RoutineID == routineID))
            //RoutineName.Content = "Routine: " + listRoutineExercise[ExerciseIndex];

            //loadContent();
            
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

            ExerciseIndex++;
            if (ExerciseIndex >= exercises.Count())
            {
                return;
            }
            ExerciseName.Content = exercises[ExerciseIndex].ExerciseName;
            ExerciseDescription.Text = exercises[ExerciseIndex].Description;

            //if (ExerciseIndex == exercises.())
            //{
            //    RoutineFinish.Content = "                     Glückwunsch!\nSie haben Ihr Training abegeschlossen.";
            //    ExerciseName.Content = "";
            //    ExerciseDescription.Text = "";
            //    btnFinish.Visibility = Visibility.Visible;
            //}
            //ExerciseIndex = exercises.Count();
        }

        private void btnPreviousClick(object sender, RoutedEventArgs e)
        {
            ExerciseIndex--;
            if (ExerciseIndex >= exercises.Count())
            {
                return;
            }
            ExerciseIndex = 0;
            ExerciseName.Content = exercises[ExerciseIndex].ExerciseName;
            ExerciseDescription.Text = exercises[ExerciseIndex].Description;
            
        }

        private void btnFinishClick(object sender, RoutedEventArgs e)
        {
            RoutineHistory rH = new RoutineHistory();
            rH.DateHistory = DateTime.Now;
            rH.RoutineID = RoutineID;
            context.RoutineHistory.Add(rH);
            context.SaveChanges();
            mainWindow.PanelRoutines();
        }

        private void btnBack(object sender, RoutedEventArgs e)
        {
            mainWindow.PanelRoutines();
        }

        //private void loadContent()
        //{
        //    ExerciseName.Content = "Übung: " + context.Exercise.Where(e => e.ExerciseID == listRoutineExercise[ExerciseIndex].ExerciseID).FirstOrDefault().ExerciseName;
        //}
    }
}
