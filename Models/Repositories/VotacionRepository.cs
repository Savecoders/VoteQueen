using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;
using Models.DTO;

namespace Models.Repositories
{
    public class VotacionRepository
    {

        public VotacionRepository()
        {
        }

        public bool Votar(
            Votacion votacion
        )
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_registrar_votacion", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EstudianteID", votacion.Usuario.ID);
                    command.Parameters.AddWithValue("@CandidataID", votacion.Candidata.ID);
                    command.Parameters.AddWithValue("@TipoVotacion", votacion.TipoVotacion.ToString());

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(
            Votacion votacion
        )
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_eliminar_votacion", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@VotacionID", votacion.ID);

                    connection.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public int GetVotos(
            Candidata candidata,
            TipoVotacion tipoVotacion
        )
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("sp_obtener_votaciones_por_candidata_tipo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CandidataID", candidata.ID);
                    command.Parameters.AddWithValue("@TipoVotacion", tipoVotacion);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                        else
                        {
                            return 0;
                        }
                    }

                }
            }
        }

        public DataSet GetVotaciones(TipoVotacion tipo)
        {
            using (SqlConnection connection = ConexionDb.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("ObtenerCandidatasYVotos", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TipoVotacion", tipo.ToString());


                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        return dataSet;
                    }
                }
            }
        }



    }
}