using Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace WebApp.Controllers
{
    public class UsuarioController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {

            if (HttpContext.Session.GetString("TipoUsuario") == "Cliente")
            {
                return View(s.GetPublicaciones());
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Comprar(int id) 
        {
            if (HttpContext.Session.GetString("TipoUsuario") != "Cliente") { return RedirectToAction("Index", "Home");}

            return View(s.GetPubByID(id));
        }

        [HttpPost]
        public IActionResult ConfirmarCompra(int id)
        {
            try
            {
                int? num = HttpContext.Session.GetInt32("IdLogueado");
                Usuario u = s.GetUsuarioByID(num);
                Publicacion p = s.GetPubByID(id);

                p.CerrarPublicacion(u);
                ViewBag.msg = "Compra realizada correctamente";
            }
            catch (Exception e)
            {

                ViewBag.msg = e.Message;

            }
            return View("Comprar", s.GetPubByID(id));

        }

        public IActionResult Ofertar(int id)
        {
            if (HttpContext.Session.GetString("TipoUsuario") != "Cliente") { return RedirectToAction("Index", "Home"); }

            return View(s.GetPubByID(id));
        }

        [HttpPost]
        public IActionResult Ofertar(int id, int ofertaUsuario)
        {
            try
            {
                int? num = HttpContext.Session.GetInt32("IdLogueado");
                Usuario u = s.GetUsuarioByID(num);
                Oferta o = new Oferta(u as Cliente, ofertaUsuario);
                Publicacion p = s.GetPubByID(id);

                s.RealizarOferta(u, ofertaUsuario, p);
            }
            catch (Exception e)
            {

                ViewBag.msg = e.Message;

            }
            return View("Ofertar", s.GetPubByID(id));

        }

        public IActionResult CargarSaldo()
        {
            if (HttpContext.Session.GetString("TipoUsuario") != "Cliente") { return RedirectToAction("Index", "Home"); }

            try
            {
                if (TempData["MsjCargarSaldo"] != null)
                {
                    ViewBag.MsjCS = TempData["MsjCargarSaldo"].ToString();
                }
                else
                {
                    ViewBag.MsjCS = TempData["MsjCargarSaldo"] = string.Empty;
                }
                int? num = HttpContext.Session.GetInt32("IdLogueado");
                Usuario u = s.GetUsuarioByID(num);
                Cliente c = u as Cliente;

                return View(c);
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Home");
            }
         

        }

        [HttpPost]
        public IActionResult CargarSaldo(int monto)
        {
            try
            {
                int? num = HttpContext.Session.GetInt32("IdLogueado");
                Usuario u = s.GetUsuarioByID(num);
                Cliente c = u as Cliente;
                c.CargarSaldo(monto);
                TempData["MsjCargarSaldo"] = "Cargado con éxito";

            }
            catch (Exception e)
            {
                TempData["MsjCargarSaldo"] = e.Message;
            }
            return RedirectToAction("CargarSaldo", "Usuario");
        }

    }
}
