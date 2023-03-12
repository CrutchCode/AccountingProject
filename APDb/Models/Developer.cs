using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APDb.Models
{
    public class Developer : Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? Position { get; set; }
        [Required]
        public DateTime DateOfEmployment { get; set; }
        public int? Salary { get; set; }
        public string? Description { get; set; }
        public ICollection<Project> Projects { get; set; }

        public Developer() 
        { 
            Projects = new List<Project>();
        }
    }
}
