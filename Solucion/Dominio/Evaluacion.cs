using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Evaluacion
    {
        public int IdEvaluacion { get; set; }
        public bool FueEvaluado { get; set; }
        public int PuntajeDeEvaluacion { get; set; }
        public int IdProyecto { get; set; }
        public ulong CIAdmin { get; set; }

        public Evaluacion()
        {

        }
    }
}
