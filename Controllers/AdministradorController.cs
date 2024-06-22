using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Microsoft.Data.SqlClient;
using UgVoteQueen.BLL;


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
            Usuario usuario
        )
        {

            if(this.UsuarioExiste(usuario))
            {
                throw new Exception("El usuario ya existe");
            }

            // consulta procedure
            string consulta = "sp_registrar_estudiante";

            SqlParameter[] parametros = [
                new SqlParameter("@Nombre", usuario.Nombre),
                new SqlParameter("@Correo", usuario.Correo),
                new SqlParameter("@Contrasena", usuario.Contrasena),
                new SqlParameter("@FotoPerfil", usuario.FotoPerfil)
            ];

            // ejecutar consulta
            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public DataSet LoginUsuario(Usuario usuario)
        {
            string query = "SELECT * FROM Usuario WHERE Correo = '" + usuario.Correo + "' AND Contrasena = '" + usuario.Contrasena + "'";
            return conexion.EjecutarConsultaSelect(query);
        }

        public bool ActualizarEstudiante(
            Usuario usuario
        )
        {
            // consulta procedure
            string consulta = "sp_actualizar_estudiante";

            SqlParameter[] parametros = [
                new SqlParameter("@Id", usuario.ID),
                new SqlParameter("@Nombre", usuario.Nombre),
                new SqlParameter("@Correo", usuario.Correo),
                new SqlParameter("@Contrasena", usuario.Contrasena),
                new SqlParameter("@FotoPerfil", usuario.FotoPerfil)
            ];

            // ejecutar consulta
            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public bool UsuarioExiste(Usuario usuario)
        {
            string query = "SELECT * FROM Usuario WHERE Correo = '" + usuario.Correo + "'";
            return conexion.EjecutarConsulta(query);
        }

    }
}
