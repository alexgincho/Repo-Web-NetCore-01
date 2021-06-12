using Repo_Web_01.Models.dbModels;
using Repo_Web_01.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repo_Web_01.Models.Services
{
    public class MarcaService : IMarca
    {
        public void AddMarca(Marca marca)
        {
            throw new NotImplementedException();
        }

        public List<Marca> GetMarcaByIdCategoria(int id)
        {
            List<Marca> lstMarcas = new List<Marca>();
            using (var db = new db_repo01Context())
            {
                try
                {
                    lstMarcas = db.Marcas.Where(c => c.IdCategoria == id).ToList();
                    if (lstMarcas == null)
                    {
                        throw new Exception("No Hay Marcas Pertenecientes a esa Categoria.");
                    }
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
            return lstMarcas;
        }
    }
}
