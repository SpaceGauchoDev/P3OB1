using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proyecto
    {
        public enum E_Equipo { Individual, Cooperativo }
        public enum E_Etapa { PendienteEvaluacion, Aprobado, Rechazado, SinInicializar }

        public class S_Filtros
        {
            public int sCI;
            public DateTime sFechaDePresentacion;
            public string sContieneTexto;
            public E_Etapa sEtapa;

            public S_Filtros()
            {
                sCI = -1;
                sFechaDePresentacion = new DateTime(1, 1, 1);
                sContieneTexto = "";
                sEtapa = E_Etapa.SinInicializar;
            }
        }

        public int IdProyecto { get; set; }
        public E_Etapa Etapa { get; set; }
        public E_Equipo Equipo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string ImgURL { get; set; }
        public int CantidadDeIntegrantes { get; set; }
        public string ExperienciaIndividual { get; set; }
        public DateTime FechaDePresentacion { get; set; }
        public int CISolicitante { get; set; }

        public Evaluacion Evaluacion { get; set; }
        public Evaluacion Financiacion { get; set; }

        public Proyecto()
        {

        }
    }
}
