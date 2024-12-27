using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleGraphQL.Models
{
    public class Order
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        //[Required]
        //[ForeignKey("ClientId")]
        //public int ClientId { get; set; } 
        //public Client? Client { get; set; } 

        //public DateTime? StartDate { get; set; } 
        //public DateTime? EndDate { get; set; } 
        //[Required]
        //[Column(TypeName = "decimal(18,2)")]  // Устанавливает точность и масштаб для decimal
        //[Range(0, double.MaxValue, ErrorMessage = "Total cost must be a positive value.")]
        //public decimal TotalCost { get; set; }
        //[Required]
        //public bool IsPaid { get; set; }
        //[Required]
        //public string? Description { get; set; }  
        //public DateTime? DatePerformed { get; set; }
        //[Required]
        //public bool WorkCompleted { get; set; }

        //public bool IsOverdue { get; set; }
        //public ICollection<Work>? Works { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [ForeignKey("ClientId")]
        public int ClientId { get; set; }

        public Client? Client { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]  // Устанавливает точность и масштаб для decimal
        [Range(0, double.MaxValue, ErrorMessage = "Total cost must be a positive value.")]
        public decimal TotalCost { get; set; }

        [Required]
        public bool IsPaid { get; set; }

        [Required]
        public string? Description { get; set; }

        public DateTime? DatePerformed { get; set; }

        [Required]
        public bool WorkCompleted { get; set; }

        public bool IsOverdue { get; set; }

        public ICollection<Work>? Works { get; set; }
    }

}
