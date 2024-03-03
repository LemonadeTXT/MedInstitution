using MedInstitution.Models;
using MedInstitution.Services;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MedInstitution.Pages
{
    public partial class MedicinesPage : Page
    {
        private MedicineService _medicineService;

        public MedicinesPage()
        {
            _medicineService = new MedicineService();

            InitializeComponent();

            dataGrid.ItemsSource = _medicineService.GetAllMedicines();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddMedicinePage());
        }

        private void Button_Edit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditMedicinePage((Medicine)dataGrid.SelectedItem));
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            _medicineService.DeleteMedicines(dataGrid.SelectedItems.OfType<Medicine>().ToList());

            dataGrid.ItemsSource = _medicineService.GetAllMedicines();
        }
    }
}
