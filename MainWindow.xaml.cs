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

namespace pr23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student student = new Student();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = student;

            
            cmbCourse.Items.Add(1);
            cmbCourse.Items.Add(2);
            cmbCourse.Items.Add(3);
            cmbCourse.Items.Add(4);
            cmbCourse.Items.Add(5);

            cmbCourse.SelectedIndex = 0;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            student.Course = (int)cmbCourse.SelectedItem;

            MessageBox.Show( $"Студент сохранён: \n ФИО: {student.FullName}\n Группа: {student.Group}\n Возраст: {student.Age}\n Курс: {student.Course}");
        }
    }
}