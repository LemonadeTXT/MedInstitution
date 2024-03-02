using MedInstitution.DAL;
using MedInstitution.Models;
using System.Linq;

namespace MedInstitution.Services
{
    public class InstitutionService
    {
        private readonly DataContext _dataContext;

        public InstitutionService()
        {
            _dataContext = new DataContext();
        }

        public bool Auth(Institution institution)
        {
            var findInstitution = _dataContext.Institutions.Any(i => i.Login == institution.Login && i.Password == institution.Password);

            return findInstitution;
        }
    }
}
