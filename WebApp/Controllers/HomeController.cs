using Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{

    public class HomeController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            if (HttpContext.Session.GetInt32("IdLogueado") != null) { return RedirectToAction("Index", "Home"); }
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string contrasenia)
        {
            try
            {
                Usuario u = s.Login(email, contrasenia); //Verifica credenciales
                HttpContext.Session.SetString("TipoUsuario", u.GetType().Name); //Setea el tipo de usuario
                HttpContext.Session.SetInt32("IdLogueado", u.Id); //Setea el ID del usuario logueado
                HttpContext.Session.SetString("NombreUsuario", u.Nombre + " " + u.Apellido);

                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                ViewBag.msg = e.Message;
            }
            return View();
        }


        public IActionResult Registro()
        {
            if (HttpContext.Session.GetInt32("IdLogueado") != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Registro(string nombre, string apellido, string email, string contrasenia)
        {
            try
            {
                s.DatosCorrectos(nombre, apellido, email, contrasenia); //Verifica datos
                Cliente C = new Cliente();
                C.Apellido = apellido;
                C.Nombre = nombre;
                C.Email = email;
                C.Contrasenia = contrasenia;
                s.AltaUsuario(C); //Da de alta al usuario como cliente

                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                ViewBag.msg = e.Message;
            }

            return View();
        }


    }


}

