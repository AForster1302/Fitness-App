using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Data.Entity;

namespace MyWorkoutRoutines
{
    /// <summary>
    /// Interaktionslogik für PanelCreatingRoutine.xaml
    /// </summary>
    public partial class PanelCreatingRoutine : UserControl
    {
        MainWindow mainWindow;

        List<Exercise> listExercise = new List<Exercise>();

        ICollectionView CollectionView;

        public MyWorkoutRoutinesEntities2 Context = new MyWorkoutRoutinesEntities2();
        public PanelCreatingRoutine(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;

        }

        public PanelCreatingRoutine()
        {
            InitializeComponent();
        }

        private void btnCreatingRoutine(object sender, RoutedEventArgs e)
        {
            //Pagee.Content = new CreatingRoutine();
        }

        private void CreateRoutinePage_Loaded(object sender, RoutedEventArgs e)
        {
            Context.Exercise.Load();
            CollectionView = CollectionViewSource.GetDefaultView(Context.Exercise.Local);
            ParentGrid.DataContext = CollectionView;
        }

        private void tBtn_Stomach(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = x => ((Exercise)x).Category == "Bauch";
        }


        private void tBtn_Back(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = x => ((Exercise)x).Category == "Rücken";
        }

        private void tBtn_Chest(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = x => ((Exercise)x).Category == "Brust";
        }

        private void tBtn_Arm(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = x => ((Exercise)x).Category == "Arm";
        }

        private void tBtn_Shoulders(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = x => ((Exercise)x).Category == "Schultern";
        }

        private void tBtn_Legs(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = x => ((Exercise)x).Category == "Beine";
        }

        private void tBtn_WarmUp(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = null;
        }


        private void tBtnStomach_Unchecked(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = null;
        }

        private void tBtnBack_Unchecked(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = null;
        }

        private void tBtnChest_Unchecked(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = null;
        }

        private void tBtnArm_Unchecked(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = null;
        }

        private void tBtnShoulders_Unchecked(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = null;
        }

        private void tBtnLegs_Unchecked(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = null;
        }

        private void tBtnWarmUp_Unchecked(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = null;
        }

        private void lvExercises_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Exercise ex = (Exercise)lwExercise.SelectedItem;
            lvRoutine.Items.Add(lvExercises.SelectedItem);
            listExercise.Add((Exercise)lvExercises.SelectedItem);

        }


            


        private void btnCreateRoutine(object sender, RoutedEventArgs e)
        {
            if (listExercise != null && listExercise.Count == 0)
            {
                MessageBox.Show("Bitte fügen Sie Übungen hinzu.");
            }
            else
            {
                Routine routine = new Routine();

                routine.RoutineName = RoutinenameBox.Text;

                foreach (Exercise ex in listExercise)
                {
                    RoutineExercises routineExercise = new RoutineExercises();
                    routineExercise.ExerciseID = ex.ExerciseID;
                    routineExercise.RoutineID = routine.RoutineID;
                    routine.RoutineExercises.Add(routineExercise);
                }

                routine.UserID = mainWindow.userid;
                Context.Routine.Add(routine);
                Context.SaveChanges();
                lvRoutine.Items.Clear();
            }

        }

        private void RoutinenameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            RoutinenameBox.Text = "";
        }

        private void Searchbox_GotFocus(object sender, RoutedEventArgs e)
        {
            Searchbox.Text = "";
        }

        private void lvExercises_Loaded(object sender, RoutedEventArgs e)
        {
            Context.Exercise.Load();
            CollectionView = CollectionViewSource.GetDefaultView(Context.Exercise.Local);
            ParentGrid.DataContext = CollectionView;
        }

        private void Searchbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Searchbox.Text = "";
            string suchstr = Searchbox.Text.ToLower();
            CollectionView.Filter = x => ((Exercise)x).ExerciseName.ToLower().Contains(suchstr);


        }

        
    }
}