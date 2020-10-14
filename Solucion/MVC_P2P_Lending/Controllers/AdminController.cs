using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;
using Repositorios;

namespace MVC_P2P_Lending.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            if (Session["usuario"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return RedirectToAction("MainMenuAdmin", "Admin");
            }
        }

        public ActionResult MainMenuAdmin()
        {
            return View();
        }

        // ====================
        // acciones admin
        // vvvvvvvvvvvvvvvvvvvv


        public ActionResult AsignarEvaluacion()
        {
            /*
            Usuario user = (Usuario)Session["usuario"];
            Empleado e = Admin.Instancia.ObtenerEmpleadoPorUsuario(user);

            List<string> infoProyectos = Admin.Instancia.ListarProyectosPorEmpleado(e);
            */
            return View(/*infoProyectos*/);
        }

        public ActionResult ExportarInformacion()
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
        // acciones admin
        // ====================
    }
}