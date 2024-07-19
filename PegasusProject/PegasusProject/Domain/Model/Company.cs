using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PegasusProject.Domain.Model
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? SocialReason { get; set; }
        [Required]
        public string? RFC { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? Brand { get; set; }
        [Required]
        public string? TickeckNumber { get; set; }
        [Required]
        public string? Email { get; set; }
    }
}
