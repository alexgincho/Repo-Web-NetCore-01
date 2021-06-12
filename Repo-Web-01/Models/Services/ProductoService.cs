using Repo_Web_01.Models.dbModels;
using Repo_Web_01.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repo_Web_01.Models.Services
{
    public class ProductoService : IProducto
    {
        public void AddProducto(Producto producto)
        {
            using (var db = new db_repo01Context())
            {
                try
                {
                    var objProduct = new Producto();
                    objProduct.CodProducto = producto.CodProducto;
                    objProduct.NombreProducto = producto.NombreProducto;
                    objProduct.DescripcionProducto = producto.DescripcionProducto;
                    objProduct.CantidadProducto = producto.CantidadProducto;
                    objProduct.PrecioProducto = producto.PrecioProducto;
                    objProduct.PrecioVenta = producto.PrecioVenta;
                    objProduct.ImagenProducto = producto.ImagenProducto;
                    objProduct.FechaRegistro = DateTime.Now;
                    objProduct.IdCategoria = producto.IdCategoria;
                    objProduct.IdMarca = producto.IdMarca;

                    db.Productos.Add(objProduct);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw new Exception("Error. Datos no Insertados");
                }
            }
        }
    }
}
