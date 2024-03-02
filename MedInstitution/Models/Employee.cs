using MedInstitution.Enums;
using System;

namespace MedInstitution.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public JobTitles? JobTitle { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
