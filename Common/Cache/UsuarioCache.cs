using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public abstract class UsuarioCache
    {
        public  int ID { get; set; }
        public  string Nombre { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public  byte[] FotoPerfil { get; set; } = null;
        public string Cargo { get; set; } = string.Empty;

    }
}
