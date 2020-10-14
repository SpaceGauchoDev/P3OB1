using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;
using Repositorios;

namespace MVC_P2P_Lending.Controllers
{
    public class SolicitanteController : Controller
    {
        // GET: Solicitante
        public ActionResult Index()
        {
            if (Session["usuario"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return RedirectToAction("MainMenuSolicitante", "Solicitante");
            }
        }

        public ActionResult MainMenuSolicitante()
        {
            return View();
        }

        // ====================
        // acciones solicitante
        // vvvvvvvvvvvvvvvvvvvv


        public ActionResult ProyectosPorSolicitante()
        {
            
            Usuario user = (Usuario)Session["usuario"];
            /*
            Empleado e = Admin.Instancia.ObtenerEmpleadoPorUsuario(user);

            List<string> infoProyectos = Admin.Instancia.ListarProyectosPorEmpleado(e);
            */

            RProyecto rProyecto = new RProyecto();

            Proyecto.S_Filtros filtros = new Proyecto.S_Filtros();
            filtros.sCI = user.CI;

            IEnumerable<Proyecto> proyectosPorUsuario = rProyecto.FindAllConFiltro(filtros);
            List<string> proyectosPorUsuarioParseados = new List<string>();
            foreach (Proyecto pro in proyectosPorUsuario)
            {
                string fila = pro.CISolicitante + " | " + pro.Titulo + " | " + pro.Etapa.ToString();
                proyectosPorUsuarioParseados.Add(fila);
            }

            return View(proyectosPorUsuarioParseados);
        }

        public ActionResult PresentarProyecto()
        {
            /*
            Usuario user = (Usuario)Session["usuario"];
            Empleado e = Admin.Instancia.ObtenerEmpleadoPorUsuario(user);

            List<string> infoAusencias = Admin.Instancia.AusenciasPorEmpleado(e);
            */
            return View(/*infoAusencias*/);
        }

        public ActionResult Logout()
        {
            Session["usuario"] = null;
            return RedirectToAction("Index", "Login");
        }

        // ^^^^^^^^^^^^^^^^^^^^
        // acciones solicitante
        // ====================


    }
}