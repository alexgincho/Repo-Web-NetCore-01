using Repo_Web_01.Models.dbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repo_Web_01.Models.Interfaces
{
    public interface ICategoria
    {
        public void AddCategoria(Categorium categoria);
        public List<Categorium> GetAllCategoria();
    }
}
