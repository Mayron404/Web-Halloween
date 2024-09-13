using Plataforma_Peliculas_de_Halloween.Controllers;
using Plataforma_Peliculas_de_Halloween.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Plataforma_Peliculas_de_Halloween.Filter
{
    public class VerificarUsuario : ActionFilterAttribute//
    {
        //Sobrecargamos el metodo

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var Actualuser = (Usuarios)HttpContext.Current.Session["User"];
            //Almacenamos la sesion, si esta se genero correctamente.
            if (Actualuser == null)
            {
                if (filterContext.Controller is LoginController == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/Login/Index");
                }
            }
            else
            {
                if (filterContext.Controller is LoginController == true)
                {
                    filterContext.HttpContext.Response.Redirect("~/Home/Index");
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}