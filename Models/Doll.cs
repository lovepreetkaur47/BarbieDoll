using System;
using System.ComponentModel.DataAnnotations;


namespace BarbieDoll.Models
{
    public class Doll
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Type { get; set; }


        [Display(Name = "Lauch Date")]
        [DataType(DataType.Date)]
        public DateTime LaunchDate { get; set; }

        
        public string Color { get; set; }

        
       
        public decimal Price { get; set; }
        
        public string Rating { get; set; }


    }
}
