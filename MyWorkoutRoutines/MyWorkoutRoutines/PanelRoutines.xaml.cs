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
    /// Interaktionslogik für PanelRoutines.xaml
    /// </summary>
    public partial class PanelRoutines : UserControl
    {

        MainWindow mainWindow;
        MyWorkoutRoutinesEntities2 Context = new MyWorkoutRoutinesEntities2();
        ICollectionView CollectionView;

        public PanelRoutines(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;

        }

        public PanelRoutines()
        {
            InitializeComponent();
        }

        private void CreateRoutinePage_Loaded(object sender, RoutedEventArgs e)
        {
            Context.Routine.Load();
            CollectionView = CollectionViewSource.GetDefaultView(Context.Routine.Local);
            ParentGrid.DataContext = CollectionView;
        }
    }
}
