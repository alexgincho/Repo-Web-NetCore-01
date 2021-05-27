using System;
using System.Collections.Generic;

#nullable disable

namespace Repo_Web_01.Models.dbModels
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleVenta = new HashSet<DetalleVentum>();
        }

        public int IdProducto { get; set; }
        public string CodProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int? CantidadProducto { get; set; }
        public decimal? PrecioProducto { get; set; }
        public string ImagenProducto { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdMarca { get; set; }

        public virtual Categorium IdCategoriaNavigation { get; set; }
        public virtual Marca IdMarcaNavigation { get; set; }
        public virtual ICollection<DetalleVentum> DetalleVenta { get; set; }
    }
}
