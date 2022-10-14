using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Audio_Speaker.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)] 
        public DateTime ReleaseDate { get; set; }
        public string Type { get; set; }

        public string Company { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
