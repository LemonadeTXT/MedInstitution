using MedInstitution.Models;
using MedInstitution.Services;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MedInstitution.Pages
{
    public partial class PatientsPage : Page
    {
        private PatientService _patientService;

        public PatientsPage()
        {
            _patientService = new PatientService();

            InitializeComponent();

            dataGrid.ItemsSource = _patientService.GetAllPatients();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPatientPage());
        }

        private void Button_Edit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPatientPage((Patient)dataGrid.SelectedItem));
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            _patientService.DeletePatients(dataGrid.SelectedItems.OfType<Patient>().ToList());

            dataGrid.ItemsSource = _patientService.GetAllPatients();
        }
    }
}
