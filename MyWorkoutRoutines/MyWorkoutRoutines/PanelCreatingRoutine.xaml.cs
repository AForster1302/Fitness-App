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

        ICollectionView collectionView;

        public MyWorkoutRoutinesCtx context = new MyWorkoutRoutinesCtx();

        public PanelCreatingRoutine(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;

        }

        private void CreateRoutinePage_Loaded(object sender, RoutedEventArgs e)
        {
            context.Exercise.Load();
            collectionView = CollectionViewSource.GetDefaultView(context.Exercise.Local);
            ParentGrid.DataContext = collectionView;
        }

        private void tBtnStomach_Checked(object sender, RoutedEventArgs e)
        {
            if (btnStomach.IsChecked == true)
            {
                collectionView.Filter = x => ((Exercise)x).Category == "Bauch";
                btnBack.IsHitTestVisible = false;
                btnChest.IsHitTestVisible = false;
                btnArms.IsHitTestVisible = false;
                btnShoulders.IsHitTestVisible = false;
                btnLegs.IsHitTestVisible = false;
            }
        }

        private void tBtnBack_Checked(object sender, RoutedEventArgs e)
        {

            if (btnBack.IsChecked == true)
            {
                collectionView.Filter = x => ((Exercise)x).Category == "Rücken";
                btnStomach.IsHitTestVisible = false;
                btnChest.IsHitTestVisible = false;
                btnArms.IsHitTestVisible = false;
                btnShoulders.IsHitTestVisible = false;
                btnLegs.IsHitTestVisible = false;
            }
        }

        private void tBtnChest_Checked(object sender, RoutedEventArgs e)
        {

            if (btnChest.IsChecked == true)
            {
                collectionView.Filter = x => ((Exercise)x).Category == "Brust";
                btnStomach.IsHitTestVisible = false;
                btnBack.IsHitTestVisible = false;
                btnArms.IsHitTestVisible = false;
                btnShoulders.IsHitTestVisible = false;
                btnLegs.IsHitTestVisible = false;
            }
        }

        private void tBtnArms_Checked(object sender, RoutedEventArgs e)
        {
            ;
            if (btnArms.IsChecked == true)
            {
                collectionView.Filter = x => ((Exercise)x).Category == "Arm";
                btnStomach.IsHitTestVisible = false;
                btnBack.IsHitTestVisible = false;
                btnChest.IsHitTestVisible = false;
                btnShoulders.IsHitTestVisible = false;
                btnLegs.IsHitTestVisible = false;
            }
        }

        private void tBtnShoulders_Checked(object sender, RoutedEventArgs e)
        {

            if (btnShoulders.IsChecked == true)
            {
                collectionView.Filter = x => ((Exercise)x).Category == "Schultern";
                btnStomach.IsHitTestVisible = false;
                btnBack.IsHitTestVisible = false;
                btnChest.IsHitTestVisible = false;
                btnArms.IsHitTestVisible = false;
                btnLegs.IsHitTestVisible = false;
            }
        }

        private void tBtnLegs_Checked(object sender, RoutedEventArgs e)
        {

            if (btnLegs.IsChecked == true)
            {
                collectionView.Filter = x => ((Exercise)x).Category == "Beine";
                btnStomach.IsHitTestVisible = false;
                btnBack.IsHitTestVisible = false;
                btnChest.IsHitTestVisible = false;
                btnArms.IsHitTestVisible = false;
                btnShoulders.IsHitTestVisible = false;
            }
        }


        private void tBtnStomach_Unchecked(object sender, RoutedEventArgs e)
        {
            collectionView.Filter = null;
            btnBack.IsHitTestVisible = true;
            btnChest.IsHitTestVisible = true;
            btnArms.IsHitTestVisible = true;
            btnShoulders.IsHitTestVisible = true;
            btnLegs.IsHitTestVisible = true;
        }

        private void tBtnBack_Unchecked(object sender, RoutedEventArgs e)
        {
            collectionView.Filter = null;
            btnStomach.IsHitTestVisible = true;
            btnChest.IsHitTestVisible = true;
            btnArms.IsHitTestVisible = true;
            btnShoulders.IsHitTestVisible = true;
            btnLegs.IsHitTestVisible = true;
        }

        private void tBtnChest_Unchecked(object sender, RoutedEventArgs e)
        {
            collectionView.Filter = null;
            btnStomach.IsHitTestVisible = true;
            btnBack.IsHitTestVisible = true;
            btnArms.IsHitTestVisible = true;
            btnShoulders.IsHitTestVisible = true;
            btnLegs.IsHitTestVisible = true;
        }

        private void tBtnArms_Unchecked(object sender, RoutedEventArgs e)
        {
            collectionView.Filter = null;
            btnStomach.IsHitTestVisible = true;
            btnBack.IsHitTestVisible = true;
            btnChest.IsHitTestVisible = true;
            btnShoulders.IsHitTestVisible = true;
            btnLegs.IsHitTestVisible = true;
        }

        private void tBtnShoulders_Unchecked(object sender, RoutedEventArgs e)
        {
            collectionView.Filter = null;
            btnStomach.IsHitTestVisible = true;
            btnBack.IsHitTestVisible = true;
            btnChest.IsHitTestVisible = true;
            btnArms.IsHitTestVisible = true;
            btnLegs.IsHitTestVisible = true;
        }

        private void tBtnLegs_Unchecked(object sender, RoutedEventArgs e)
        {
            collectionView.Filter = null;
            btnStomach.IsHitTestVisible = true;
            btnBack.IsHitTestVisible = true;
            btnChest.IsHitTestVisible = true;
            btnArms.IsHitTestVisible = true;
            btnShoulders.IsHitTestVisible = true;
        }

        private void lvExercises_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lvRoutine.Items.Add(lvExercises.SelectedItem);
            listExercise.Add((Exercise)lvExercises.SelectedItem);

        }

        private void lvRoutine_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lvRoutine.Items.Remove(lvRoutine.SelectedItem);
            listExercise.Remove((Exercise)lvRoutine.SelectedItem);
        }

        private void btnCreateRoutine(object sender, RoutedEventArgs e)
        {
            if (context.Routine.Any(r => r.RoutineName == RoutinenameBox.Text && r.UserID == mainWindow.userid))
            {
                MessageBox.Show("Dieser Name ist bereits vergeben.");
            }
            else
            {
                if (listExercise != null && listExercise.Count == 0)
                {
                    MessageBox.Show("Bitte fügen Sie Übungen hinzu.");
                }
                else
                {
                    Routine routine = new Routine();

                    if (RoutinenameBox.Text == "")
                    {
                        MessageBox.Show("Bitte geben Sie einen Namen an.");
                    }
                    else
                    {
                        routine.RoutineName = RoutinenameBox.Text;

                        foreach (Exercise ex in listExercise)
                        {
                            RoutineExercises routineExercise = new RoutineExercises();
                            routineExercise.ExerciseID = ex.ExerciseID;
                            routineExercise.RoutineID = routine.RoutineID;
                            routine.RoutineExercises.Add(routineExercise);
                        }

                        routine.UserID = mainWindow.userid;
                        context.Routine.Add(routine);
                        context.SaveChanges();
                        lvRoutine.Items.Clear();
                        RoutinenameBox.Text = "";
                    }
                }
            }
        }

        private void RoutinenameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Searchbox.Text))
            {
                lRoutineName.Visibility = Visibility.Hidden;
            }
        }

        private void Searchbox_GotFocus(object sender, RoutedEventArgs e)
        {
            lSuche.Visibility = Visibility.Hidden;
        }

        private void Searchbox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Searchbox.Text))
            {
                lSuche.Visibility = Visibility.Visible;
            }
        }

        private void lvExercises_Loaded(object sender, RoutedEventArgs e)
        {
            context.Exercise.Load();
            collectionView = CollectionViewSource.GetDefaultView(context.Exercise.Local);
            ParentGrid.DataContext = collectionView;
        }

        private void Searchbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string suchstr = Searchbox.Text.ToLower();
            collectionView.Filter = x => ((Exercise)x).ExerciseName.ToLower().Contains(suchstr);
        }

        private void RoutinenameBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(RoutinenameBox.Text))
            {
                lRoutineName.Visibility = Visibility.Visible;
            }
        }
    }
}