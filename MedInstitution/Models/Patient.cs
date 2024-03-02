using System;

namespace MedInstitution.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Illnesses { get; set; }
    }
}
