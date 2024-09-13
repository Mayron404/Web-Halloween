using Plataforma_Peliculas_de_Halloween.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Plataforma_Peliculas_de_Halloween.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(string user, string password)
        {
            try
            {
               using (BDSFinalV4Entities db = new BDSFinalV4Entities())
                {
                    var list = from d in db.Usuarios where d.NombreUsuario == user && d.Contraseña == password select d;
                    if (list.Count() > 0)
                    {
                        Session["User"] = list.First();
                        return Content("1");
                    }
                    else
                    {
                        return Content("Usuario Invalido");
                    }
                }
            }
            catch (Exception ex)
            {
                return Content("Ha ocurrido un error" + ex.Message);
            }


        }

        // FIN ACTION ENTER



    }
}