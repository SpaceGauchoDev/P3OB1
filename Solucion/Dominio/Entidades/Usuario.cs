using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario 
    {
        public enum E_Rol {Solicitante, Admin }

        public int CI { get; set; }
        public string Pass { get; set; }
        public E_Rol Rol { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }


        public Usuario()
        {

        }
    }
}
