using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class SessionManager
    {

        private static UsuarioCache usuario;

        public static void Login(UsuarioCache user)
        {
            usuario = user;
        }

        public static UsuarioCache GetUsuario()
        {
            return usuario;
        }

        public static bool IsLogged()
        {
            return usuario != null;
        }

        public static void Logout()
        {
            usuario = null;
        }

    }
}
