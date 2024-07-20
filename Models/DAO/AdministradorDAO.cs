using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Microsoft.Data.SqlClient;
using Models.DTO;


namespace Models.DAO
{
    public class AdministradorDAO
    {
        private readonly ConexionDb conexion;
        public AdministradorDAO()
        {
            conexion = new ConexionDb();
        }

        public bool RegistrarEstudiante(
            Administrador administrador
        )
        {

            if (this.UsuarioExiste(administrador))
            {
                throw new Exception("El Administrador ya existe");
            }

            // consulta procedure
            string consulta = "sp_registrar_administrador";

            SqlParameter[] parametros = [
                new SqlParameter("@Nombre", administrador.Nombre),
                new SqlParameter("@Correo", administrador.Correo),
                new SqlParameter("@Contrasena", administrador.Contrasena),
                new SqlParameter("@FotoPerfil", administrador.FotoPerfil),
                new SqlParameter("@Cargo", administrador.Cargo)
            ];

            // ejecutar consulta
            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public DataSet LoginUsuario(Administrador administrador)
        {
            string query = "SELECT * FROM Administrador WHERE Correo = '" + administrador.Correo + "' AND Contrasena = '" + administrador.Contrasena + "'";
            return conexion.EjecutarConsultaSelect(query);
        }

        public bool ActualizarEstudiante(
            Administrador administrador
        )
        {
            // consulta procedure
            string consulta = "sp_actualizar_administrador";

            SqlParameter[] parametros = [
                new SqlParameter("@Id", administrador.ID),
                new SqlParameter("@Nombre", administrador.Nombre),
                new SqlParameter("@Correo", administrador.Correo),
                new SqlParameter("@Contrasena", administrador.Contrasena),
                new SqlParameter("@FotoPerfil", administrador.FotoPerfil),
                new SqlParameter("@Cargo", administrador.Cargo)
            ];

            // ejecutar consulta
            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public bool UsuarioExiste(Administrador usuario)
        {
            string query = "SELECT * FROM Administrador WHERE Correo = '" + usuario.Correo + "'";
            return conexion.EjecutarConsulta(query);
        }

    }
}
