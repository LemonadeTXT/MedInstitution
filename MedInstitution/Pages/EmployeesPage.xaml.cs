using MedInstitution.Models;
using MedInstitution.Services;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MedInstitution.Pages
{
    public partial class EmployeesPage : Page
    {
        private EmployeeService _employeeService;

        public EmployeesPage()
        {
            _employeeService = new EmployeeService();

            InitializeComponent();

            dataGrid.ItemsSource = _employeeService.GetAllEmployees();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEmployeePage());
        }

        private void Button_Edit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditEmployeePage((Employee)dataGrid.SelectedItem));
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            _employeeService.DeleteEmployees(dataGrid.SelectedItems.OfType<Employee>().ToList());

            dataGrid.ItemsSource = _employeeService.GetAllEmployees();
        }
    }
}
