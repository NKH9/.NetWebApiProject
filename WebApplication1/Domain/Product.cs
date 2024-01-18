using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        [Key]
        [Description("Unique identifier for the product")]
        public int Id { get; set; } 
        [Description("name of the product")]
        public string Name  { get; set; }
        [Description("Price of the product")]
        public decimal Price { get; set; }
        [Description("Identifier indicating the category to which the product belongs")]
        public int CategoryId { get; set; }

    }
}
