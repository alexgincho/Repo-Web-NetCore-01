using System;
using System.Collections.Generic;

#nullable disable

namespace Repo_Web_01.Models.dbModels
{
    public partial class Marca
    {
        public Marca()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }
        public int? IdCategoria { get; set; }

        public virtual Categorium IdCategoriaNavigation { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
