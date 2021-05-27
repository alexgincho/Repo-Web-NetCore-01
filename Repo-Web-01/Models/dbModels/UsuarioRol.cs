using System;
using System.Collections.Generic;

#nullable disable

namespace Repo_Web_01.Models.dbModels
{
    public partial class UsuarioRol
    {
        public int? IdRol { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
