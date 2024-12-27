using ExampleGraphQL.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ExampleGraphQL.Models
{
    public class Team
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        //[Required]
        //public string? Name { get; set; }
        //[Required]
        //public string? Description { get; set; }
        //[Required]
        //public string? FullName { get; set; }
        //[Required]
        //public string? PhoneNumber { get; set; }
        //public List<Member>? Members { get; set; }
        //public List<Work>? Works { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string? FullName { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }

        public List<Member>? Members { get; set; }

        public List<Work>? Works { get; set; }
    }
}
