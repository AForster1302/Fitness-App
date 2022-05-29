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
    /// Interaktionslogik für PanelRoutineHistory.xaml
    /// </summary>
    public partial class PanelRoutineHistory : UserControl
    {

        
        MyWorkoutRoutinesEntities2 Context = new MyWorkoutRoutinesEntities2();
        ICollectionView CollectionView;
        MainWindow mainWindow;
        public PanelRoutineHistory(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;

            lwRoutineHistory.Items.Refresh();
        }

        private void RoutineHistoryPage_Loaded(object sender, RoutedEventArgs e)
        {
            Context.RoutineHistory.Load();
            CollectionView = CollectionViewSource.GetDefaultView(Context.RoutineHistory.Local);
            ParentGrid.DataContext = CollectionView;
        }

    }
}
