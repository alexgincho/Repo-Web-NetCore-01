using Microsoft.AspNetCore.Mvc;
using Repo_Web_01.Models.dbModels;
using Repo_Web_01.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repo_Web_01.Controllers
{
    public class ProductoController : Controller
    {
        private IProducto _product;
        public ProductoController(IProducto product)
        {
            this._product = product;
        }
        public IActionResult AddProducto(string nombre)
        {
            ViewData["Nombre"] = "Hola" + nombre;
            return View();
        }
        [HttpPost]
        public IActionResult AddProducto(Producto producto)
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                
            }
            return View();
        }
    }
}
