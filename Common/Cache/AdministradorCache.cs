using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public class AdministradorCache: UsuarioCache
    {
        public string Cargo { get; set; } = string.Empty;
    }
}
