using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Microsoft.Data.SqlClient;
using UgVoteQueen.Models.DTO;


namespace UgVoteQueen.Models.DAO
{
    class EstudianteDAO
    {
        private readonly ConexionDb conexion;
        public EstudianteDAO()
        {
            conexion = new ConexionDb();
        }

        public bool RegistrarEstudiante(
            Estudiante estudiante
        )
        {

            if (this.UsuarioExiste(estudiante))
            {
                throw new Exception("El usuario ya existe");
            }

            // consulta procedure
            string consulta = "sp_registrar_estudiante";

            SqlParameter[] parametros = [
                new SqlParameter("@Nombre", estudiante.Nombre),
                new SqlParameter("@Correo", estudiante.Correo),
                new SqlParameter("@Contrasena", estudiante.Contrasena),
                new SqlParameter("@FotoPerfil", estudiante.FotoPerfil),
                new SqlParameter("@Matricula", estudiante.Matricula)
            ];

            // ejecutar consulta
            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public DataSet LoginUsuario(Estudiante estudiante)
        {
            string query = "SELECT * FROM Estudiante WHERE Correo = '" + estudiante.Correo + "' AND Contrasena = '" + estudiante.Contrasena + "'";
            return conexion.EjecutarConsultaSelect(query);
        }

        public bool ActualizarEstudiante(
            Estudiante estudiante
        )
        {
            // consulta procedure
            string consulta = "sp_actualizar_estudiante";

            SqlParameter[] parametros = [
                new SqlParameter("@Id", estudiante.ID),
                new SqlParameter("@Nombre", estudiante.Nombre),
                new SqlParameter("@Correo", estudiante.Correo),
                new SqlParameter("@Contrasena", estudiante.Contrasena),
                new SqlParameter("@FotoPerfil", estudiante.FotoPerfil),
                new SqlParameter("@Matricula", estudiante.Matricula),
            ];

            // ejecutar consulta
            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public bool UsuarioExiste(Estudiante estudiante)
        {
            string query = "SELECT * FROM Estudiante WHERE Correo = '" + estudiante.Correo + "'";
            return conexion.EjecutarConsulta(query);
        }

    }
}
