using MedInstitution.Models;
using MedInstitution.Services;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MedInstitution.Pages
{
    public partial class EditPatientPage : Page
    {
        private readonly PatientService _patientService;
        private readonly int _patientId;

        public EditPatientPage(Patient patient)
        {
            _patientService = new PatientService();

            InitializeComponent();

            _patientId = patient.Id;
            textboxFirstName.Text = patient.FirstName;
            textboxLastName.Text = patient.LastName;
            datepickerBirthday.SelectedDate = patient.Birthday.Value;
            textboxIllnesses.Text = patient.Illnesses;
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PatientsPage());
        }

        private void Button_Edit(object sender, RoutedEventArgs e)
        {
            var patient = new Patient
            {
                Id = _patientId,
                FirstName = textboxFirstName.Text,
                LastName = textboxLastName.Text,
                Birthday = datepickerBirthday.DisplayDate,
                Illnesses = textboxIllnesses.Text,
            };

            _patientService.EditPatient(patient);

            NavigationService.Navigate(new PatientsPage());
        }
    }
}
