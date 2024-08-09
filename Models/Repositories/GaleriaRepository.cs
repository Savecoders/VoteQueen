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
    public class GaleriaRepository
    {

        public GaleriaRepository()
        {
        }

        public int Add(
            Galeria galeria, int CandidataID
        )
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_registrar_galeria", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CandidataID", CandidataID);
                    command.Parameters.AddWithValue("@Titulo", galeria.Titulo);
                    command.Parameters.AddWithValue("@Descripcion", galeria.Descripcion);
                    command.Parameters.AddWithValue("@Portada", galeria.Portada);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return Convert.ToInt32(reader["GaleriaID"]);
                        }
                    }
                }
            }

            return 0;
        }

        public bool Update(
            Galeria galeria
        )
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_actualizar_galeria", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@GaleriaID", galeria.ID);
                    command.Parameters.AddWithValue("@Titulo", galeria.Titulo);
                    command.Parameters.AddWithValue("@Descripcion", galeria.Descripcion);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }

        }

        public Galeria Get(
            Galeria galeriaid
        )
        {
            Galeria galeria = new Galeria();
            using (SqlConnection conexion = ConexionDb.GetConnection())
            {
                using (SqlCommand comando = new SqlCommand("sp_obtener_galeria", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@GaleriaID", galeriaid.ID);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            galeria.ID = Convert.ToInt32(reader["GaleriaID"]);
                            galeria.Titulo = reader["Titulo"].ToString();
                            galeria.Descripcion = reader["Descripcion"].ToString();
                            galeria.Portada = (byte[])reader["Portada"];
                            galeria.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);

                            galeria.Fotos = new List<Foto>();
                        }

                    }
                }
            }

            return galeria;
        }

        public List<Galeria> GetAllByCandidata(int CandidataID)
        {
            List<Galeria> galerias = new List<Galeria>();

            using (SqlConnection conexion = ConexionDb.GetConnection())
            {
                using (SqlCommand comando = new SqlCommand("sp_obtener_galerias_candidata", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@CandidataID", CandidataID);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Galeria galeria = new Galeria();
                            galeria.ID = Convert.ToInt32(reader["GaleriaID"]);
                            galeria.Titulo = reader["Titulo"].ToString();
                            galeria.Descripcion = reader["Descripcion"].ToString();
                            galeria.Portada = (byte[])reader["Portada"];
                            galeria.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                            galeria.Fotos = new List<Foto>();

                            galerias.Add(galeria);
                        }

                    }
                }
            }

            return galerias;
        }


        public List<Galeria> FilterByCandidatas(string condicion, int CandidataID)
        {
            List<Galeria> galerias = new List<Galeria>();
        
            using (SqlConnection conexion = ConexionDb.GetConnection())
            {
                using (SqlCommand comando = new SqlCommand("sp_filtrar_galeria", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Condicion", condicion);
                    comando.Parameters.AddWithValue("@CandidataID", CandidataID);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Galeria galeria = new Galeria();
                            galeria.ID = Convert.ToInt32(reader["GaleriaID"]);
                            galeria.Titulo = reader["Titulo"].ToString();
                            galeria.Descripcion = reader["Descripcion"].ToString();
                            galeria.Portada = (byte[])reader["Portada"];
                            galeria.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);

                            galeria.Fotos = new List<Foto>();

                            galerias.Add(galeria);
                        }

                    }
                }
            }

            return galerias;
        }

        public bool Delete(
            Galeria galeria
        )
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_eliminar_galeria", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@GaleriaID", galeria.ID);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}