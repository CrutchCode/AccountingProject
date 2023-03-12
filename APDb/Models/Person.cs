using System.ComponentModel.DataAnnotations;

namespace APDb.Models
{
    public class Person
    {
        [Required]
        public int Age { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }

    }
}
