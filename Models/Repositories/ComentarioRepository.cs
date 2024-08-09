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

    public class ComentarioRepository
    {

        public ComentarioRepository()
        {

        }

        public bool Add(
            Comentario comentario,
            Foto foto
        )
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_registrar_comentario", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@texto", comentario.Texto);
                    command.Parameters.AddWithValue("@EstudianteID", comentario.Estudiante.ID);
                    command.Parameters.AddWithValue("@FotoID", foto.ID);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(
            Comentario comentario
        )
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_actualizar_comentario", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ComentarioID", comentario.ID);
                    command.Parameters.AddWithValue("@texto", comentario.Texto);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(
            Comentario comentario
        )
        {
            // consulta procedure
            string consulta = "sp_eliminar_comentario";

            SqlParameter[] parametros = [
                new SqlParameter("@ComentarioID", comentario.ID),
            ];

            // ejecutar consulta
            return ConexionDb.ExecuteProcedureInputs(consulta, parametros);
        }



        public List<Comentario> FilterByFoto(
            int fotoID
        )
        {
            List<Comentario> comentarios = new List<Comentario>();

            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_obtener_comentarios_por_foto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FotoID", fotoID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Comentario comentario = new Comentario();
                            comentario.ID = Convert.ToInt32(reader["ComentarioID"]);
                            comentario.Texto = reader["Texto"].ToString();
                            comentario.Fecha = Convert.ToDateTime(reader["FechaComentario"]);
                            comentario.Estudiante = new Estudiante();
                            comentario.Estudiante.ID = Convert.ToInt32(reader["EstudianteID"]);
                            comentarios.Add(comentario);
                        }
                    }
                }
            }

            return comentarios;
        }

        public bool AsignarComentarioFoto(Comentario comentario, int FotoID)
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_asignar_comentario_foto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ComentarioID", comentario.ID);
                    command.Parameters.AddWithValue("@FotoID", FotoID);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

    }

}