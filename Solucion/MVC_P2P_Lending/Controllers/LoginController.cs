using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/*
using MVC_P2P_Lending.Models;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
*/
using Dominio;
using Repositorios;

namespace MVC_P2P_Lending.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Login(string nombreUsuario = "", string contrasenia = "")
        {
            RUsuario rUsuario = new RUsuario();
            Usuario u = rUsuario.IntentoDeLogin(nombreUsuario, contrasenia);
            string msg = "";

            string siguienteControlador = "";

            if (u != null)
            {
                    switch (u.Rol)
                    {
                        case Usuario.E_Rol.Admin:
                            msg = "Los datos son correctos, bienvenido/a Administrador/a";
                            siguienteControlador = "Admin";
                            break;
                        case Usuario.E_Rol.Solicitante:
                            msg = "Los datos son correctos, bienvenido/a Empleado/a";
                            siguienteControlador = "Solicitante";
                            break;
                    }

                    ViewBag.Mensaje = msg;
                    Session["usuario"] = u;
                    return RedirectToAction("Index", siguienteControlador);
            }
            else
            {
                ViewBag.Mensaje = "Los datos no son correctos.";
            }

            return View();
        }

        public ActionResult Logout()
        {
            Session["usuario"] = null;
            return View("Login");
        }

    }
}