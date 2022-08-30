using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WebApplication6
{
    public class Food
    { 
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string ExpiationDate { get; set; }
        [Required]
        public int Quantity { get; set; }
        
    }
}
