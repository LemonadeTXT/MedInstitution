using MedInstitution.Models;
using MedInstitution.Services;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MedInstitution.Pages
{
    public partial class AddMedicinePage : Page
    {
        private readonly MedicineService _medicineService;

        public AddMedicinePage()
        {
            _medicineService = new MedicineService();

            InitializeComponent();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MedicinesPage());
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            var medicine = new Medicine
            {
                Name = textboxName.Text,
                Manufacturer = textboxManufacturer.Text,
                Count = Int32.Parse(textboxCount.Text),
            };

            _medicineService.AddMedicine(medicine);

            NavigationService.Navigate(new MedicinesPage());
        }
    }
}
