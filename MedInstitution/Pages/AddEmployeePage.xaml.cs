using MedInstitution.Enums;
using MedInstitution.Models;
using MedInstitution.Services;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MedInstitution.Pages
{
    public partial class AddEmployeePage : Page
    {
        private readonly EmployeeService _employeeService;

        public AddEmployeePage()
        {
            _employeeService = new EmployeeService();

            InitializeComponent();

            comboboxJobTitle.ItemsSource = Enum.GetValues(typeof(JobTitles));
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeesPage());
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            var employee = new Employee
            {
                FirstName = textboxFirstName.Text,
                LastName = textboxLastName.Text,
                JobTitle = (JobTitles)comboboxJobTitle.SelectedItem,
                Birthday = datepickerBirthday.DisplayDate,
            };

            _employeeService.AddEmployee(employee);

            NavigationService.Navigate(new EmployeesPage());
        }
    }
}
