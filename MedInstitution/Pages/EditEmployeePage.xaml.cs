using MedInstitution.Enums;
using MedInstitution.Models;
using MedInstitution.Services;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MedInstitution.Pages
{
    public partial class EditEmployeePage : Page
    {
        private readonly EmployeeService _employeeService;
        private readonly int _employeeId;

        public EditEmployeePage(Employee employee)
        {
            _employeeService = new EmployeeService();
            _employeeId = employee.Id;

            InitializeComponent();

            textboxFirstName.Text = employee.FirstName;
            textboxLastName.Text = employee.LastName;
            comboboxJobTitle.ItemsSource = Enum.GetValues(typeof(JobTitles));
            comboboxJobTitle.SelectedItem = employee.JobTitle;
            datepickerBirthday.SelectedDate = employee.Birthday.Value;
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeesPage());
        }

        private void Button_Edit(object sender, RoutedEventArgs e)
        {
            var employee = new Employee
            {
                Id = _employeeId,
                FirstName = textboxFirstName.Text,
                LastName = textboxLastName.Text,
                JobTitle = (JobTitles)comboboxJobTitle.SelectedItem,
                Birthday = datepickerBirthday.DisplayDate,
            };

            _employeeService.EditEmployee(employee);

            NavigationService.Navigate(new EmployeesPage());
        }
    }
}
