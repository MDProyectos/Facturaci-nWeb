using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Cliente
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Nombre del cliente")]
        public string Nombre { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Cedula")]
        public string cedula { get; set; }
        [Required]
        [Display(Name = "Telefono")]
        public string telefono { get; set; }
        [Required]
        [Display(Name = "Dirreccion")]
        public string direccion { get; set; }
    }
}
