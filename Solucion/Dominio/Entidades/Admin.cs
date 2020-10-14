using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Admin: Usuario
    {

        public List<Evaluacion> Evaluaciones { get; set; }

        public Admin()
        {

        }
    }
}
