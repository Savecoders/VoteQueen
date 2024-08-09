using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Microsoft.Data.SqlClient;
using Models.DTO;


namespace Models.Repositories
{
    public class EstudianteRepository : IRepository<Estudiante>
    {

        public bool Add(
            Estudiante estudiante
        )
        {

            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_registrar_estudiante", connection))
                {

                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                        command.Parameters.AddWithValue("@Correo", estudiante.Correo);
                        command.Parameters.AddWithValue("@Contrasena", estudiante.Contrasena);
                        command.Parameters.AddWithValue("@FotoPerfil", estudiante.FotoPerfil);
                        command.Parameters.AddWithValue("@Matricula", estudiante.Matricula);

                        connection.Open();

                        return command.ExecuteNonQuery() > 0;

                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }
            }
        }

        public Estudiante LoginUsuario(Estudiante adminLogin)
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_login_estudiante", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Correo", adminLogin.Correo);
                    command.Parameters.AddWithValue("@Contrasena", adminLogin.Contrasena);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Estudiante estudiante = new();
                            estudiante.ID = Convert.ToInt32(reader["EstudianteID"]);
                            estudiante.Nombre = reader["Nombre"].ToString();
                            estudiante.Correo = reader["Correo"].ToString();
                            estudiante.FotoPerfil = (byte[])reader["FotoPerfil"];
                            estudiante.Matricula = reader["Matricula"].ToString();
                            estudiante.Estado = Convert.ToBoolean(reader["Estado"]);
                            return estudiante;
                        }
                    }
                }

            }

            return null;
        }

        public bool Update(
            Estudiante estudiante
        )
        {

            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_actualizar_estudiante", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EstudianteID", estudiante.ID);
                    command.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                    command.Parameters.AddWithValue("@Correo", estudiante.Correo);
                    command.Parameters.AddWithValue("@Contrasena", estudiante.Contrasena);
                    command.Parameters.AddWithValue("@FotoPerfil", estudiante.FotoPerfil);
                    command.Parameters.AddWithValue("@Matricula", estudiante.Matricula);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<Estudiante> GetAll()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_obtener_estudiantes_activos", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Estudiante estudiante = new();
                            estudiante.ID = Convert.ToInt32(reader["EstudianteID"]);
                            estudiante.Nombre = reader["Nombre"].ToString();
                            estudiante.Correo = reader["Correo"].ToString();
                            estudiante.FotoPerfil = (byte[])reader["FotoPerfil"];
                            estudiante.Matricula = reader["Matricula"].ToString();
                            estudiante.Estado = Convert.ToBoolean(reader["Estado"]);
                            estudiantes.Add(estudiante);
                        }
                    }
                }
            }

            return estudiantes;
        }

        public Estudiante Get(
            Estudiante estudiante
        )
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_obtener_estudiante", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Correo", estudiante.Correo);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            estudiante.ID = Convert.ToInt32(reader["EstudianteID"]);
                            estudiante.Nombre = reader["Nombre"].ToString();
                            estudiante.Correo = reader["Correo"].ToString();
                            estudiante.FotoPerfil = (byte[])reader["FotoPerfil"];
                            estudiante.Matricula = reader["Matricula"].ToString();
                            estudiante.Estado = Convert.ToBoolean(reader["Estado"]);
                            return estudiante;
                        }
                    }
                }
            }

            return null;
        }

        public List<Estudiante> FilterBy(string condicion)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_filtrar_estudiante", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Condicion", condicion);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Estudiante estudiante = new();
                            estudiante.ID = Convert.ToInt32(reader["EstudianteID"]);
                            estudiante.Nombre = reader["Nombre"].ToString();
                            estudiante.Correo = reader["Correo"].ToString();
                            estudiante.FotoPerfil = (byte[])reader["FotoPerfil"];
                            estudiante.Matricula = reader["Matricula"].ToString();
                            estudiante.Estado = Convert.ToBoolean(reader["Estado"]);
                            estudiantes.Add(estudiante);
                        }
                    }
                }
            }

            return estudiantes;
        }

        public bool Delete(
            Estudiante estudiante
        )
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_eliminar_estudiante", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EstudianteID", estudiante.ID);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UsuarioExiste(string correo)
        {
            string consulta = "sp_existe_estudiante";
            SqlParameter[] parametros = [
                new SqlParameter("@Correo", correo)
            ];
            return ConexionDb.ExecuteProcedureInputs(consulta, parametros);
        }

        public async Task<bool> VerificarVotoFMCF(int estudianteID)
        {
            try
            {

                using (SqlConnection connection = ConexionDb.GetConnection())
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand("sp_virificar_voto_fmcf", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@EstudianteID", estudianteID);

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                return (int)reader["Voto"] > 0;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            
            }catch(Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo verificar el voto " + e.Message);
            }

        }

        public async Task<bool> VerificarVotoFotogenia(int estudianteId)
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                await connection.OpenAsync();
                using (SqlCommand command = new SqlCommand("sp_virificar_voto_fotogenia", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EstudianteID", estudianteId);

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return (int)reader["Voto"] > 0;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

    }
}
