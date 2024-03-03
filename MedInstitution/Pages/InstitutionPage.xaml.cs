using MedInstitution.Models;
using MedInstitution.Services;
using System.Windows.Controls;

namespace MedInstitution.Pages
{
    public partial class InstitutionPage : Page
    {
        private readonly InstitutionService _institutionService;

        public InstitutionPage(Institution institution)
        {
            _institutionService = new InstitutionService();

            InitializeComponent();

            var currentinstitution = _institutionService.GetCurrentInstitution(institution);

            labelLogin.Content = currentinstitution.Login;
            labelPassword.Content = currentinstitution.Password;
            labelAddress.Content = currentinstitution.Address;
            labelEmail.Content = currentinstitution.Email;
        }
    }
}
