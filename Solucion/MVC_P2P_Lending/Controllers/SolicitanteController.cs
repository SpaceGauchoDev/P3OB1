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
            /*
            Usuario user = (Usuario)Session["usuario"];
            Empleado e = Admin.Instancia.ObtenerEmpleadoPorUsuario(user);

            List<string> infoProyectos = Admin.Instancia.ListarProyectosPorEmpleado(e);
            */
            return View(/*infoProyectos*/);
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