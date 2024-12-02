using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment4_2_LMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUserId.Text == "Teacher" && txtPassword.Password == "Admin")
            {
                TeacherDashboard dashboard = new TeacherDashboard();
                dashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }
    }
}