using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PegasusProject.Domain.Model
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? ProductCode { get; set; }
        [Required]
        public int idCategory { get; set; } // Foreign Key
        [Required]
        public string? ProductDescription { get; set; }
        [Required]
        public float ProductPriceBuy { get; set; }
        [Required]
        public float ProductPriceSell { get; set; }
        [Required]
        public float Utility { get; set; }
        [Required]
        public float ProductStock { get; set; }
        [Required]
        public DateTime ProductCreationDate { get; set; }
        [Required]
        public DateTime ProductUpdateDate { get; set; }
    }
}
