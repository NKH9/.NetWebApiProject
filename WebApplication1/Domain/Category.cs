using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category
    {
        [Key]
        [Description("Unique identified for the category")]
        public int Id { get; set; }
        [Description("Name of the category")]
        public string Name { get; set; }
    }
}
