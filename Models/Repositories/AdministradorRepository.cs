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
    public class AdministradorRepository : IRepository<Administrador>
    {
        public AdministradorRepository()
        {
        }

        public bool Add(
            Administrador administrador
        )
        {

            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_registrar_administrador", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", administrador.Nombre);
                    command.Parameters.AddWithValue("@Correo", administrador.Correo);
                    command.Parameters.AddWithValue("@Contrasena", administrador.Contrasena);
                    command.Parameters.AddWithValue("@FotoPerfil", administrador.FotoPerfil);
                    command.Parameters.AddWithValue("@Cargo", administrador.Cargo);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public Administrador LoginUsuario(Administrador administrador)
        {

            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_login_administrador", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Correo", administrador.Correo);
                    command.Parameters.AddWithValue("@Nombre", administrador.Nombre);
                    command.Parameters.AddWithValue("@Contrasena", administrador.Contrasena);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Administrador admin = new();
                            admin.ID = Convert.ToInt32(reader["AdministradorID"]);
                            admin.Nombre = reader["Nombre"].ToString();
                            admin.Correo = reader["Correo"].ToString();

                            try
                            {
                                admin.FotoPerfil = (byte[])reader["FotoPerfil"];

                            }catch (Exception e)
                            {
                                admin.FotoPerfil = null;
                            }
                            
                            admin.Cargo = reader["Cargo"].ToString();

                            return admin;
                        }
                    }
                }

            }
            return null;
        }

        public bool Update(
            Administrador administrador
        )
        {

            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_actualizar_administrador", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AdministradorID", administrador.ID);
                    command.Parameters.AddWithValue("@Nombre", administrador.Nombre);
                    command.Parameters.AddWithValue("@Correo", administrador.Correo);
                    command.Parameters.AddWithValue("@Contrasena", administrador.Contrasena);
                    command.Parameters.AddWithValue("@FotoPerfil", administrador.FotoPerfil);
                    command.Parameters.AddWithValue("@Cargo", administrador.Cargo);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UsuarioExiste(String correo)
        {
            string consulta = "sp_existe_estudiante";
            SqlParameter[] parametros = [
                new SqlParameter("@Correo", correo)
            ];
            return ConexionDb.ExecuteProcedureInputs(consulta, parametros);
        }

        public bool Delete(Administrador admin)
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_eliminar_administrador", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AdministradorID", admin.ID);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        Administrador IRepository<Administrador>.Get(Administrador t)
        {
            throw new NotImplementedException();
        }

        List<Administrador> IRepository<Administrador>.GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Administrador> FilterBy(string condicion)
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_obtener_administradores", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Condicion", condicion);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Administrador> administradores = new();
                        while (reader.Read())
                        {
                            Administrador administrador = new();
                            administrador.ID = Convert.ToInt32(reader["AdministradorID"]);
                            administrador.Nombre = reader["Nombre"].ToString();
                            administrador.Correo = reader["Correo"].ToString();
                            administrador.FotoPerfil = (byte[])reader["FotoPerfil"];
                            administrador.Cargo = reader["Cargo"].ToString();

                            administradores.Add(administrador);
                        }
                        return administradores;
                    }
                }
            }
        }
    }
}
