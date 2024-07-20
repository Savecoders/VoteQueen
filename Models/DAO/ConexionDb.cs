using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace Models.DAO
{
    public class ConexionDb
    {
        // Reemplazar por la cadena de conexión a la base de datos
        private readonly string _connectionString = "Server=.\\DESARROLLO;Database=UgQueenDataBase;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True;";

        private readonly SqlConnection connection;

        public ConexionDb()
        {
            connection = new SqlConnection(_connectionString);
        }

        public SqlConnection AbrirConexion()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        // Ejecutar consultas
        public bool EjecutarProcedure(string consulta, SqlParameter[] parametros)
        {
            try
            {

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = consulta;
                command.Connection = connection;
                command.Connection.Open();
                command.Parameters.AddRange(parametros);
                command.ExecuteNonQuery();
                command.Connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EjecutarConsulta(string consulta)
        {
            try
            {
                SqlCommand command = new SqlCommand(consulta, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public DataSet EjecutarConsultaSelect(string consulta)
        {
            DataSet dataSet = new DataSet();
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = consulta;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);
                return dataSet;

            }
            catch
            {
                return dataSet;
            }

        }
    }
}
