using MedInstitution.Pages;
using System.Windows;

namespace MedInstitution.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Employees(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new EmployeesPage());
        }
    }
}
