using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class productos
    {
        public int Id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string detalle { get; set; }
        public int cantidad  { get; set; }
        [Required]
        public int precio { get; set; }
        
    }
}
