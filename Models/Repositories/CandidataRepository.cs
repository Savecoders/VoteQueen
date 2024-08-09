using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;
using Models.DTO;

namespace Models.Repositories
{
    public class CandidataRepository : IRepository<Candidata>
    {
        public CandidataRepository()
        {
        }

        public bool Add(
            Candidata candidata
        )
        {

            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_registrar_candidata", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", candidata.Nombre);
                    command.Parameters.AddWithValue("@FotoPrincipal", candidata.FotoPrincipal);
                    command.Parameters.AddWithValue("@Edad", candidata.Edad);
                    command.Parameters.AddWithValue("@Telefono", candidata.Telefono);
                    command.Parameters.AddWithValue("@Fecha_Nacimiento", candidata.FechaNacimiento.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Pasatiempos", candidata.Pasatiempos);
                    command.Parameters.AddWithValue("@Habilidades", candidata.Habilidades);
                    command.Parameters.AddWithValue("@Intereses", candidata.Intereses);
                    command.Parameters.AddWithValue("@Aspiraciones", candidata.Aspiraciones);
                    command.Parameters.AddWithValue("@Carrera", candidata.Carrera);
                    command.Parameters.AddWithValue("@Nivel", candidata.Nivel);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(
            Candidata candidata
        )
        {

            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_actualizar_candidata", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", candidata.ID);
                    command.Parameters.AddWithValue("@Nombre", candidata.Nombre);
                    command.Parameters.AddWithValue("@FotoPrincipal", candidata.FotoPrincipal);
                    command.Parameters.AddWithValue("@Edad", candidata.Edad);
                    command.Parameters.AddWithValue("@Telefono", candidata.Telefono);
                    command.Parameters.AddWithValue("@Fecha_Nacimiento", candidata.FechaNacimiento);
                    command.Parameters.AddWithValue("@Pasatiempos", candidata.Pasatiempos);
                    command.Parameters.AddWithValue("@Habilidades", candidata.Habilidades);
                    command.Parameters.AddWithValue("@Intereses", candidata.Intereses);
                    command.Parameters.AddWithValue("@Aspiraciones", candidata.Aspiraciones);
                    command.Parameters.AddWithValue("@Carrera", candidata.Carrera);
                    command.Parameters.AddWithValue("@Nivel", candidata.Nivel);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(Candidata candidata)
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_eliminar_candidata", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CandidataID", candidata.ID);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public Candidata Get(Candidata candidata)
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_buscar_candidata", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CandidataID", candidata.ID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            candidata.ID = Convert.ToInt32(reader["CandidataID"]);
                            candidata.Nombre = reader["Nombre"].ToString();
                            candidata.FotoPrincipal = (byte[])reader["FotoPrincipal"];
                            candidata.Edad = Convert.ToInt32(reader["Edad"]);
                            candidata.Telefono = reader["Telefono"].ToString();
                            candidata.FechaNacimiento = Convert.ToDateTime(reader["Fecha_Nacimiento"]);
                            candidata.Pasatiempos = reader["Pasatiempos"].ToString();
                            candidata.Habilidades = reader["Habilidades"].ToString();
                            candidata.Intereses = reader["Intereses"].ToString();
                            candidata.Aspiraciones = reader["Aspiraciones"].ToString();
                            candidata.Carrera = reader["Carrera"].ToString();
                            candidata.Nivel = Convert.ToInt32(reader["Nivel"]);
                        }
                    }
                }
            }
            return candidata;
        }

        public List<Candidata> GetAll()
        {
            List<Candidata> candidatas = new();

            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_obtener_candidatas", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Candidata candidata = new();
                            candidata.ID = Convert.ToInt32(reader["CandidataID"]);
                            candidata.Nombre = reader["Nombre"].ToString();
                            candidata.FotoPrincipal = (byte[])reader["FotoPrincipal"];
                            candidata.Edad = Convert.ToInt32(reader["Edad"]);
                            candidata.Telefono = reader["Telefono"].ToString();
                            candidata.FechaNacimiento = Convert.ToDateTime(reader["Fecha_Nacimiento"]);
                            candidata.Pasatiempos = reader["Pasatiempos"].ToString();
                            candidata.Habilidades = reader["Habilidades"].ToString();
                            candidata.Intereses = reader["Intereses"].ToString();
                            candidata.Aspiraciones = reader["Aspiraciones"].ToString();
                            candidata.Carrera = reader["Carrera"].ToString();
                            candidata.Nivel = Convert.ToInt32(reader["Nivel"]);

                            candidatas.Add(candidata);
                        }
                    }
                }

            }
            return candidatas;
        }

        public List<Candidata> FilterBy(string condicion)
        {
            List<Candidata> candidatas = new();

            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_filtrar_candidatas", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Condicion", condicion);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Candidata candidata = new();
                            candidata.ID = Convert.ToInt32(reader["CandidataID"]);
                            candidata.Nombre = reader["Nombre"].ToString();
                            candidata.FotoPrincipal = (byte[])reader["FotoPrincipal"];
                            candidata.Edad = Convert.ToInt32(reader["Edad"]);
                            candidata.Telefono = reader["Telefono"].ToString();
                            candidata.FechaNacimiento = Convert.ToDateTime(reader["Fecha_Nacimiento"]);
                            candidata.Pasatiempos = reader["Pasatiempos"].ToString();
                            candidata.Habilidades = reader["Habilidades"].ToString();
                            candidata.Intereses = reader["Intereses"].ToString();
                            candidata.Aspiraciones = reader["Aspiraciones"].ToString();
                            candidata.Carrera = reader["Carrera"].ToString();
                            candidata.Nivel = Convert.ToInt32(reader["Nivel"]);

                            candidatas.Add(candidata);
                        }
                    }
                }

            }
            return candidatas;
        }

        public int GetCantidadGalerias(Candidata candidata)
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_obtener_total_galerias_candidata", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CandidataID", candidata.ID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Convert.ToInt32(reader["Total"]);
                        }
                    }
                }
            }

            return 0;
        }

        public int ObtenerCantidadFotos(Candidata candidata)
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_obtener_total_fotos_candidata", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CandidataID", candidata.ID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Convert.ToInt32(reader["Total"]);
                        }
                    }
                }
            }
            return 0;
        }
    }

}