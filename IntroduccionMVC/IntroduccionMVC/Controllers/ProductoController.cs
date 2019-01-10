using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionMVC.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Mensaje = "Este es un mensaje desde el controlador";
            ViewBag.Listado = new List<string>
            {
                "Colombia",
                "Argentina",
                "Brazil"
            };
            return View();
        }
    }
}