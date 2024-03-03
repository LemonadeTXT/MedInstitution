using MedInstitution.Models;
using MedInstitution.Pages;
using System.Windows;

namespace MedInstitution.Windows
{
    public partial class MainWindow : Window
    {
        private readonly Institution _institution;

        public MainWindow(Institution institution)
        {
            _institution = institution;

            InitializeComponent();
        }

        private void Button_Employees(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new EmployeesPage());
        }

        private void Button_Medicines(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new MedicinesPage());
        }

        private void Button_Patients(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new PatientsPage());
        }

        private void Button_Institution(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new InstitutionPage(_institution));
        }
    }
}
