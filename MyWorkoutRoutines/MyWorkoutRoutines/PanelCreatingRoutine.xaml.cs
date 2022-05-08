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

namespace MyWorkoutRoutines
{
    /// <summary>
    /// Interaktionslogik für PanelCreatingRoutine.xaml
    /// </summary>
    public partial class PanelCreatingRoutine : UserControl
    {
        MainWindow mainWindow;
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

        }

        private void ListBox_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = "Data Source=(local); Database=MyWorkoutRoutines;Initial Catalog=messenger;" +
            "Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Exercises", con);
            da.Fill(dt);

            foreach (DataRow dataRow in dt.Rows)
            {
                listboxExercises.Items.Add(dataRow["ExerciseName"].ToString());
            }

        }
    }
}
