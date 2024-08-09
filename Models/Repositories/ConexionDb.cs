using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace Models.Repositories
{
    public class ConexionDb
    {
        // Reemplazar por la cadena de conexión a la base de datos
        private static readonly string _connectionString = "Server=.\\DESARROLLO;Database=UgQueenDataBase;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // Ejecutar consultas
        public static bool ExecuteProcedureInputs(string consulta, SqlParameter[] parametros)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = new SqlCommand(
                    consulta, connection
                );
                {
                    command.Connection.Open();
                    command.Parameters.AddRange(parametros);
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Usuario registrado con éxito");
                    return true;
                }
            }

            return false;

        }

        public bool EjecutarConsulta(string consulta)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(consulta, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
