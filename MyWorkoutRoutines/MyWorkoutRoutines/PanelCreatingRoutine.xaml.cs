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

        List<Exercises> listExercises = new List<Exercises>();

        ICollectionView CollectionView;

        public MyWorkoutRoutines_Entities Context = new MyWorkoutRoutines_Entities();

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
            Pagee.Content = new CreatingRoutine();
        }

        private void CreateRoutinePage_Loaded(object sender, RoutedEventArgs e)
        {
            Context.Exercises.Load();
            CollectionView = CollectionViewSource.GetDefaultView(Context.Exercises.Local);
            ParentGrid.DataContext = CollectionView;
        }

        private void tBtn_Stomach(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = x => ((Exercises)x).Category == "Bauch";
        }


        private void tBtn_Back(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = x => ((Exercises)x).Category == "Rücken";
        }

        private void tBtn_Chest(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = x => ((Exercises)x).Category == "Brust";
        }

        private void tBtn_Arm(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = x => ((Exercises)x).Category == "Arm";
        }

        private void tBtn_Shoulders(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = x => ((Exercises)x).Category == "Schultern";
        }

        private void tBtn_Legs(object sender, RoutedEventArgs e)
        {
            CollectionView.Filter = x => ((Exercises)x).Category == "Beine";
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

        private void lbExercises_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lwRoutine.Items.Add(lwExercises.SelectedItem);
            //listExercises.Add((Exercises)lwExercises.SelectedItem);

        }

        //private void lbRoutine_Loaded(object sender, RoutedEventArgs e)
        //{
        //    Context.Exercises.Load();
        //    CollectionView = CollectionViewSource.GetDefaultView(Context.Exercises.Local);
        //    ParentGrid.DataContext = CollectionView;
        //}

        private void btnCreateRoutine(object sender, RoutedEventArgs e)
        {
            Routine routine = new Routine();
            routine.RoutineName = RoutinenameBox.Text;
            //routine.Exercises = listExercises;
            routine.UserID = mainWindow.userid;

            Context.Routine.Add(routine);
            Context.SaveChanges();
            lwRoutine.Items.Refresh();
        }

        private void tba()
        {
            tb.Text = mainWindow.userid.ToString();
        }

        private void RoutinenameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            RoutinenameBox.Text = "";
        }

        private void Searchbox_GotFocus(object sender, RoutedEventArgs e)
        {
            Searchbox.Text = "";
        }

        private void Searchbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //string suchstr = Searchbox.Text.ToLower();

            //CollectionView.Filter = null;
            //var list = CollectionView.Cast<Exercises>();
            //Exercises exer = list.FirstOrDefault(x => x.ExerciseName.ToLower().Contains(suchstr) || x.ExerciseName.ToLower().Contains(suchstr));
            //CollectionView.MoveCurrentTo(exer);

            string filter = Searchbox.Text.ToLower();

            CollectionView.Filter = x => ((Exercises)x).ExerciseName.ToLower().Contains(filter);
        }
    }
}
