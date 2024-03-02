using MedInstitution.DAL;
using MedInstitution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedInstitution.Services
{
    public class EmployeeService
    {
        private readonly DataContext _dataContext;

        public EmployeeService()
        {
            _dataContext = new DataContext();
        }

        public List<Employee> GetAllEmployees()
        {
            return _dataContext.Employees.ToList();
        }
    }
}
