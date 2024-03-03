using MedInstitution.DAL;
using MedInstitution.Models;
using System.Collections.Generic;
using System.Linq;

namespace MedInstitution.Services
{
    public class MedicineService
    {
        private readonly DataContext _dataContext;

        public MedicineService()
        {
            _dataContext = new DataContext();
        }

        public List<Medicine> GetAllMedicines()
        {
            return _dataContext.Medicines.ToList();
        }

        public void AddMedicine(Medicine medicine)
        {
            _dataContext.Medicines.Add(medicine);
            _dataContext.SaveChanges();
        }

        public void EditMedicine(Medicine medicine)
        {
            _dataContext.Medicines.Update(medicine);
            _dataContext.SaveChanges();
        }

        public void DeleteMedicines(List<Medicine> medicines)
        {
            _dataContext.Medicines.RemoveRange(medicines);
            _dataContext.SaveChanges();
        }
    }
}
