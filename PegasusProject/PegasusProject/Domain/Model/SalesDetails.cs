using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PegasusProject.Domain.Model
{
    public class SalesDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? TicketNumer { get; set; }
        [Required]
        public int idProduct { get; set; } // Foreign Key
        [Required]
        public string? ProductCode { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public DateTime SalesDate { get; set; }
    }
}
