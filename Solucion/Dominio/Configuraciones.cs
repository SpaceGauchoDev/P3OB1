using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Configuraciones
    {
        public int IdConfig { get; set; }
        public int MinEdad { get; set; }
        public int MinMonto { get; set; }
        public int MaxMonto { get; set; }
        public int MinCuotas { get; set; }
        public int MaxCuotas { get; set; }
        public decimal PenalizacionPorIndividual { get; set; }
        public decimal BonoPorIntegrante { get; set; }
        public decimal MaxBonoTotal { get; set; }
        public DateTime FechaDeActualizacion { get; set; }

        public List<InteresPorCuotas> InteresPorCuotas { get; set; }

        public Configuraciones()
        {

        }
    }
}
