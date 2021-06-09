using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repo_Web_01.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult AddProducto(string nombre)
        {
            ViewData["Nombre"] = "Hola" + nombre;
            return View();
        }
    }
}
