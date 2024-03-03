using MedInstitution.Models;
using MedInstitution.Services;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MedInstitution.Pages
{
    public partial class AddPatientPage : Page
    {
        private readonly PatientService _patientService;

        public AddPatientPage()
        {
            _patientService = new PatientService();

            InitializeComponent();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PatientsPage());
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            var patient = new Patient
            {
                FirstName = textboxFirstName.Text,
                LastName = textboxLastName.Text,
                Birthday = datepickerBirthday.DisplayDate,
                Illnesses = textboxIllnesses.Text,
            };

            _patientService.AddPatient(patient);

            NavigationService.Navigate(new PatientsPage());
        }
    }
}
