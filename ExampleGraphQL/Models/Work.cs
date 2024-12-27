using ExampleGraphQL.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ExampleGraphQL.Models
{
    public class Work
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        //[Required]
        //public string? Description { get; set; }
        //[Required]
        //[Column(TypeName = "decimal(18,2)")]  // Устанавливает точность и масштаб для decimal
        //[Range(0, double.MaxValue, ErrorMessage = "Total cost must be a positive value.")]
        //public decimal Cost { get; set; }
        //public DateTime? Date { get; set; }
        //[Required]
        //[ForeignKey("TeamId")]
        //public int TeamId { get; set; }
        //public Team? Team { get; set; }
        //[Required]
        //public bool WorkCompleted { get; set; }
        //[Required]
        //[ForeignKey("OrderId")]
        //public int OrderId { get; set; }
        //public Order? Order { get; set; }
        //public DateTime? DatePerformed { get; internal set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]  // Устанавливает точность и масштаб для decimal
        [Range(0, double.MaxValue, ErrorMessage = "Cost must be a positive value.")]
        public decimal Cost { get; set; }

        public DateTime? Date { get; set; }

        [Required]
        [ForeignKey("TeamId")]
        public int TeamId { get; set; }

        public Team? Team { get; set; }

        [Required]
        public bool WorkCompleted { get; set; }

        [Required]
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }

        public Order? Order { get; set; }

        public DateTime? DatePerformed { get; internal set; }
    }
}