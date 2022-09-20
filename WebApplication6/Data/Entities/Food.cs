using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication6.Data.Entities
{
    public class Food
    {
        public Food()
        {
            Name = String.Empty;
            ExpiationDate = String.Empty;
        }
        public int ID { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public decimal Price { get; set; }

        public string? ExpiationDate { get; set; }

        public int? Quantity { get; set; }
    }
}
