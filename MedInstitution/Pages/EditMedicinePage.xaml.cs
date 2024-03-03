using MedInstitution.Models;
using MedInstitution.Services;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MedInstitution.Pages
{
    public partial class EditMedicinePage : Page
    {
        private readonly MedicineService _medicineService;
        private readonly int _medicineId;

        public EditMedicinePage(Medicine medicine)
        {
            _medicineService = new MedicineService();
            _medicineId = medicine.Id;

            InitializeComponent();

            textboxName.Text = medicine.Name;
            textboxManufacturer .Text = medicine.Manufacturer;
            textboxCount.Text = medicine.Count.ToString();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MedicinesPage());
        }

        private void Button_Edit(object sender, RoutedEventArgs e)
        {
            var medicine = new Medicine
            {
                Id = _medicineId,
                Name = textboxName.Text,
                Manufacturer = textboxManufacturer.Text,
                Count = Int32.Parse(textboxCount.Text),
            };

            _medicineService.EditMedicine(medicine);

            NavigationService.Navigate(new MedicinesPage());
        }
    }
}
