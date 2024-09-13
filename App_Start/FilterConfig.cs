using System.Web;
using System.Web.Mvc;

namespace Plataforma_Peliculas_de_Halloween
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Filter.VerificarUsuario());

        }
    }
}
