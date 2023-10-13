using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarbieDoll.Models
{
    public class Doll
    {
        
        public int Id { get; set; }
        [StringLength(75, MinimumLength = 5)]
        [Required]
        public string Name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(40)]
        public string Type { get; set; }


        [Display(Name = "Lauch Date")]
        [DataType(DataType.Date)]
        public DateTime LaunchDate { get; set; }

        [StringLength(80, MinimumLength = 4)]
        [Required]
        public string Color { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(20, 2)")]
       
        public decimal Price { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Rating must be a number with up to 2 decimal places")]
        [Required]
        public string Rating { get; set; }


    }
}
