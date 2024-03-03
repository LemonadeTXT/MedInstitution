using MedInstitution.DAL;
using MedInstitution.Models;
using System.Collections.Generic;
using System.Linq;

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

        public void AddEmployee(Employee employee)
        {
            _dataContext.Employees.Add(employee);
            _dataContext.SaveChanges();
        }

        public void EditEmployee(Employee employee)
        {
            _dataContext.Employees.Update(employee);
            _dataContext.SaveChanges();
        }

        public void DeleteEmployees(List<Employee> employees)
        {
            _dataContext.Employees.RemoveRange(employees);
            _dataContext.SaveChanges();
        }
    }
}
