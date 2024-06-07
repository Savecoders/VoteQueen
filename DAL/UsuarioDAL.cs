using System;
using System.Collections.Generic;
using System.Data;
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
            string consulta = "sp_registrar_estudiante";

            SqlParameter[] parametros = [
                new SqlParameter("@Nombre", nombre),
                new SqlParameter("@Correo", correo),
                new SqlParameter("@Contrasena", contrasena),
                new SqlParameter("@FotoPerfil", fotoPerfil)
            ];

            // ejecutar consulta
            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public DataSet LoginUsuario(string correo, string contrasena)
        {
            string query = "SELECT * FROM Usuario WHERE Correo = (Correo) AND Contrasena = (Contrasena)" + "VALUES (" + correo + "," + contrasena + ")";
            return conexion.EjecutarConsultaSelect(query);
        }

        public bool ActualizarEstudiante(
            int id,
            string nombre,
            string correo,
            string contrasena,
            byte[] fotoPerfil
        )
        {
            // consulta procedure
            string consulta = "sp_actualizar_estudiante";

            SqlParameter[] parametros = [
                new SqlParameter("@Id", id),
                new SqlParameter("@Nombre", nombre),
                new SqlParameter("@Correo", correo),
                new SqlParameter("@Contrasena", contrasena),
                new SqlParameter("@FotoPerfil", fotoPerfil)
            ];

            // ejecutar consulta
            return conexion.EjecutarProcedure(consulta, parametros);
        }

    }
}
