using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;


namespace UgVoteQueen.DAL
{
    class UsuarioDAL
    {
        private readonly ConexionDb conexion;
        public UsuarioDAL()
        {
            conexion = new ConexionDb();
        }

        public bool RegistrarEstudiante(
            string nombre,
            string correo,
            string contrasena,
            byte[] fotoPerfil
        )
        {
            // consulta procedure
            string consulta = "RegistrarEstudiante";

            SqlParameter[] parametros = [
                new SqlParameter("@Nombre", nombre),
                new SqlParameter("@Correo", correo),
                new SqlParameter("@Contrasena", contrasena),
                new SqlParameter("@FotoPerfil", fotoPerfil)
            ];

            // ejecutar consulta
            return conexion.EjecutarConsulta(consulta, parametros);
        }

    }
}
