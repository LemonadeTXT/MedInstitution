using MedInstitution.DAL;
using MedInstitution.Models;
using System.Collections.Generic;
using System.Linq;

namespace MedInstitution.Services
{
    public class PatientService
    {
        private readonly DataContext _dataContext;

        public PatientService()
        {
            _dataContext = new DataContext();
        }

        public List<Patient> GetAllPatients()
        {
            return _dataContext.Patients.ToList();
        }

        public void AddPatient(Patient patient)
        {
            _dataContext.Patients.Add(patient);
            _dataContext.SaveChanges();
        }

        public void EditPatient(Patient patient)
        {
            _dataContext.Patients.Update(patient);
            _dataContext.SaveChanges();
        }

        public void DeletePatients(List<Patient> patients)
        {
            _dataContext.Patients.RemoveRange(patients);
            _dataContext.SaveChanges();
        }
    }
}
