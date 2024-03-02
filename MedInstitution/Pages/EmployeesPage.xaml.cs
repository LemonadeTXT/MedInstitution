using MedInstitution.Services;
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
    }
}
