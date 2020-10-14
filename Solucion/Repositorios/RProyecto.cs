using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Configuration;
using System.Data.SqlClient;
using Dominio;

namespace Repositorios
{
    public class RProyecto : IRepositorio<Proyecto>
    {
        public bool Add(Proyecto pT)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proyecto> FindAll()
        {
            throw new NotImplementedException();
        }

        public Proyecto FindById(object pId)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Proyecto pT)
        {
            throw new NotImplementedException();
        }

        public bool Update(Proyecto pT)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proyecto> FindAllConFiltro(Proyecto.S_Filtros pFiltros)
        {
            Conexion conexion = new Conexion();
            SqlConnection cn = conexion.CrearConexion();
            string cmdString = InterpretarFiltros(pFiltros);

            SqlCommand cmd = new SqlCommand(cmdString, cn);

            try
            {
                if (conexion.AbrirConexion(cn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Proyecto> proyectos = new List<Proyecto>();
                    while (dr.Read())
                    {
                        Proyecto.E_Etapa etapa;
                        if (dr["Etapa"].ToString() == "A")
                        {
                            etapa = Proyecto.E_Etapa.Aprobado;
                        } else if (dr["Etapa"].ToString() == "R")
                        {
                            etapa = Proyecto.E_Etapa.Rechazado;
                        }
                        else
                        {
                            etapa = Proyecto.E_Etapa.PendienteEvaluacion;
                        }

                        Proyecto.E_Equipo equipo;
                        if (dr["TipoDeEquipo"].ToString() == "I")
                        {
                            equipo = Proyecto.E_Equipo.Individual;
                        }
                        else
                        {
                            equipo = Proyecto.E_Equipo.Cooperativo;
                        }


                        Proyecto p = new Proyecto()
                        {
                            IdProyecto = (int)dr["IdProyecto"],
                            Etapa = etapa,
                            Equipo = equipo,
                            Titulo = dr["Titulo"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
                            ImgURL = dr["ImgURL"].ToString(),
                            CantidadDeIntegrantes = (int)dr["CantidadDeIntegrantes"],
                            ExperienciaIndividual = dr["ExperienciaIndividual"].ToString(),
                            FechaDePresentacion = (DateTime)dr["FechaDePresentacion"],
                            CISolicitante = (int)dr["CISolicitante"]
                        };

                        proyectos.Add(p);
                    }
                    return proyectos;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally

            {
                conexion.CerrarConexion(cn);
            }
        }

        private string InterpretarFiltros(Proyecto.S_Filtros pFiltros)
        {
            bool unFiltroFueAplicado = false; 
            string result = "SELECT * FROM Proyecto WHERE ";

            Proyecto.S_Filtros sinInicializar = new Proyecto.S_Filtros();

            if (pFiltros.sCI != sinInicializar.sCI) {
                result += "Proyecto.CISolicitante =" + pFiltros.sCI;
                unFiltroFueAplicado = true;
            }

            if (pFiltros.sEtapa != sinInicializar.sEtapa)
            {
                
                string etapa = "";
                switch (pFiltros.sEtapa)
                {
                    case Proyecto.E_Etapa.PendienteEvaluacion:
                        etapa = "P";
                        break;
                    case Proyecto.E_Etapa.Aprobado:
                        etapa = "A";
                        break;
                    case Proyecto.E_Etapa.Rechazado:
                        etapa = "R";
                        break;
                }

                if (unFiltroFueAplicado)
                {
                    result += " AND Proyecto.Etapa =" + etapa;
                }
                else
                {
                    result += " Proyecto.Etapa =" + etapa;
                }

                

                unFiltroFueAplicado = true;
            }

            
            if (pFiltros.sFechaDePresentacion != sinInicializar.sFechaDePresentacion)
            {
                if (unFiltroFueAplicado)
                {
                    result += " AND Proyecto.FechaDePresentacion =" + pFiltros.sFechaDePresentacion.ToString("yyyyMMdd");
                }
                else
                {
                    result += " Proyecto.FechaDePresentacion =" + pFiltros.sFechaDePresentacion.ToString("yyyyMMdd");
                }
                unFiltroFueAplicado = true;
            }

            if (pFiltros.sContieneTexto != sinInicializar.sContieneTexto)
            {
                if (unFiltroFueAplicado)
                {
                    result += " AND (Proyecto.Titulo LIKE " + pFiltros.sContieneTexto +" OR "+ "Proyecto.Descripcion LIKE " + pFiltros.sContieneTexto + ")";
                }
                else
                {
                    result += " Proyecto.Titulo LIKE " + pFiltros.sContieneTexto + " OR " + "Proyecto.Descripcion LIKE " + pFiltros.sContieneTexto;
                }

                unFiltroFueAplicado = true;
            }

            if (unFiltroFueAplicado)
            {
                return result;
            }
            else {
                return " SELECT * FROM Proyecto";
            }
        }
    }
}
