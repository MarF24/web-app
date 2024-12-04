using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AdministradorController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("TipoUsuario") == "Administrador") //Verifica que sea administrador y retorna una vista diferente dependiendo del resultado
            {
                return View(s.GetPublicaciones());
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult Cerrar(int id) //Cierra una subasta
        {
            try
                {
                int? num = HttpContext.Session.GetInt32("IdLogueado"); //Obtiene el ID del usuario logueado
                Usuario adm = s.GetUsuarioByID(num); //Verifica que usuario logueado sea Administrador
                Publicacion sub = s.GetPubByID(id); //Obtiene la subasta a cerrar por ID
                sub.CerrarPublicacion(adm);
                return RedirectToAction("Index", "Administrador");
            }
            catch (Exception e)
            {
                TempData["MsjCerrar"] = e.Message;
            }
            return RedirectToAction("Index", "Administrador");
        }
    }
}
