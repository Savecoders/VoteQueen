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
    public class FotoRepository
    {
        public FotoRepository()
        {

        }

        public bool Add(
            Foto foto,
            int GaleriaID
        )
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_registrar_foto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@GaleriaID", GaleriaID);
                    command.Parameters.AddWithValue("@Titulo", foto.Titulo);
                    command.Parameters.AddWithValue("@Descripcion", foto.Descripcion);
                    command.Parameters.AddWithValue("@Imagen", foto.Imagen);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(
            Foto foto
        )
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_actualizar_foto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FotoID", foto.ID);
                    command.Parameters.AddWithValue("@Titulo", foto.Titulo);
                    command.Parameters.AddWithValue("@Descripcion", foto.Descripcion);
                    command.Parameters.AddWithValue("@Imagen", foto.Imagen);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(
            Foto foto
        )
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_eliminar_foto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FotoID", foto.ID);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }


        public List<Foto> GetFotos(
            Galeria galeria
        )
        {
            List<Foto> fotos = new List<Foto>();

            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_obtener_fotos_por_galeria", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@GaleriaID", galeria.ID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fotos.Add(new Foto
                            {
                                ID = Convert.ToInt32(reader["FotoID"]),
                                Titulo = reader["Titulo"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Imagen = (byte[])reader["Imagen"],
                                FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"])
                            });
                        }
                    }
                }
            }

            return fotos;
        }


    }
}
