using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models.ViewModel
{
    public class TablaRegistroViewModel
    {
        public int id { get; set; }
        [Required]
        [Display(Name ="Nombre")]
        public string nombre { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "correo electronico")]
        public string email { get; set; }
        [Required]
        [Display(Name = "Compañia")]
        public string conpania { get; set; }
        [Required]
        [Display(Name = "Contacto")]
        public string contacto { get; set; }
        [Required]
        [Display(Name = "Celular")]
        public string celular { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string pass { get; set; }

    }
}