using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleGraphQL.Models
{
    public class Client
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        //[Required]
        //public string? Name { get; set; }
        //[Required]
        //public string? ContactInformation { get; set; }
        //[Required]
        //public string? Address { get; set; }
        //[Required]
        //public string? PhoneNumber { get; set; }
        //public ICollection<Order>? Orders { get; internal set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? ContactInformation { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }

}
