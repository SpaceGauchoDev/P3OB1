using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class ModeloLogin
    {
        [Required(ErrorMessage = "Campo requerido!")]
        [Display(Name = "CI: ")]
        public string CI { get; set; }

        [Required(ErrorMessage = "Campo requerido!")]
        [Display(Name = "Contraseña: ")]
        [DataType(DataType.Password)]
        public string Pass { get; set; }
    }
}