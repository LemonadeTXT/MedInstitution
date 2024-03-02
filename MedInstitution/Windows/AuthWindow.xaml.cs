using MedInstitution.Models;
using System.Windows;
using MedInstitution.Services;
using MedInstitution.Windows;

namespace MedInstitution
{
    public partial class AuthWindow : Window
    {
        private InstitutionService _institutionService;

        public AuthWindow()
        {
            _institutionService = new InstitutionService();

            InitializeComponent();
        }

        private void Button_Auth(object sender, RoutedEventArgs e)
        {
            var institution = new Institution
            {
                Login = textboxLogin.Text,
                Password = textboxPassword.Text,
            };

            var auth = _institutionService.Auth(institution);

            if (auth)
            {
                new MainWindow().Show();

                Close();
            }
        }
    }
}
