using Repo_Web_01.Models.dbModels;
using Repo_Web_01.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repo_Web_01.Models.Services
{
    public class CategoriaService : ICategoria
    {
        public void AddCategoria(Categorium categoria)
        {
            throw new NotImplementedException();
        }

        public List<Categorium> GetAllCategoria()
        {
            List<Categorium> lstCategoria = new List<Categorium>();
            using (var db = new db_repo01Context())
            {
                try
                {
                    lstCategoria = db.Categoria.ToList();
                    if(lstCategoria == null)
                    {
                        throw new Exception("No Existe Categorias Registradas.");
                    }
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
            return lstCategoria;
        }
    }
}
