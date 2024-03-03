using MedInstitution.Pages;
using System.Windows;

namespace MedInstitution.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
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

        }

        private void Button_Institution(object sender, RoutedEventArgs e)
        {

        }
    }
}
