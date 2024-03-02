namespace MedInstitution.Models
{
    public class Institution
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
    }
}