using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Financiacion
    {
        public int IdFinanciacion { get; set; }
        public int Cuotas { get; set; }
        public decimal PrecioPorCuota { get; set; }
        public decimal MontoSolicitado { get; set; }
        public decimal PorcentajeDeInteres { get; set; }

        public int IdProyecto { get; set; }
        public int IdConfig { get; set; }

        public Financiacion()
        {

        }
    }
}
