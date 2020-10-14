using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proyecto
    {
        public enum E_Etapa { Individual, Cooperativo }
        public enum E_Equipo { PendienteEvaluacion, Aprobado, Rechazado }

        public int IdProyecto { get; set; }
        public E_Etapa Etapa { get; set; }
        public E_Equipo Equipo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int CantidadDeIntegrantes { get; set; }
        public string ExperienciaIndividual { get; set; }
        public DateTime FechaDePresentacion { get; set; }
        public ulong CISolicitante { get; set; }

        public Evaluacion Evaluacion { get; set; }
        public Evaluacion Financiacion { get; set; }

        public Proyecto()
        {

        }
    }
}
