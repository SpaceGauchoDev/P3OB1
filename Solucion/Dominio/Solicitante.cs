using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Solicitante: Usuario
    {

        public List<Proyecto> Proyectos { get; set; }

        public Solicitante()
        {

        }
    }
}
