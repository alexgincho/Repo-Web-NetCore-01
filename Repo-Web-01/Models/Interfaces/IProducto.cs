using Repo_Web_01.Models.dbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repo_Web_01.Models.Interfaces
{
    public interface IProducto
    {
        public void AddProducto(Producto producto);
    }
}
