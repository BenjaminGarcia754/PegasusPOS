using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PegasusProject.Domain.Model
{
    public class SalesHeader
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? TicketNumer { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public float Subtotal { get; set; }
        [Required]
        public float IVA { get; set; }
        [Required]
        public float Total { get; set; }
        [Required]
        public DateTime SalesDate { get; set; }
    }
}
