using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PegasusProject.Domain.Model
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? CategoryName { get; set; }
        [Required]
        public bool ApplyWeight { get; set; }
        [Required]
        public DateTime CategoryCreationDate { get; set; }
        [Required]
        public DateTime CategoryUpdateDate { get; set; }
    }
}
