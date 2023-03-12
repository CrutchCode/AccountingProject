using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APDb.Models
{
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? ProjectName { get; set; }
        public string? Description { get; set; }
        [Required]
        public DateTime DateOfCreate { get; set; }
        public string? Owner { get; set; }

        public ICollection<Developer> Developers { get; set; }

        public Project()
        {
            Developers = new List<Developer>();
        }
    }
}
