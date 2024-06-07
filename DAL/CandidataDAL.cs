using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace UgVoteQueen.DAL
{
    class CandidataDAL
    {

        private readonly ConexionDb conexion;

        public CandidataDAL()
        {
            conexion = new ConexionDb();
        }

        public bool Registrar(
            string Nombre,
            byte[] FotoPrincipal,
            int edad,
            string DatosAcademicos,
            string Pasatiempos,
            string Habilidades,
            string Intereses,
            string Aspiraciones
        )
        {
            // consulta procedure
            string consulta = "sp_registrar_candidata";

            SqlParameter[] parametros = [
                new SqlParameter("@Nombre", Nombre),
                new SqlParameter("@FotoPrincipal", FotoPrincipal),
                new SqlParameter("@Edad", edad),
                new SqlParameter("@DatosAcademicos", DatosAcademicos),
                new SqlParameter("@Pasatiempos", Pasatiempos),
                new SqlParameter("@Habilidades", Habilidades),
                new SqlParameter("@Intereses", Intereses),
                new SqlParameter("@Aspiraciones", Aspiraciones)
            ];

            // ejecutar consulta
            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public bool Actualizar(
            int Id,
            string Nombre,
            byte[] FotoPrincipal,
            int edad,
            string DatosAcademicos,
            string Pasatiempos,
            string Habilidades,
            string Intereses,
            string Aspiraciones
        )
        {
            // consulta procedure
            string consulta = "sp_actualizar_candidata";

            SqlParameter[] parametros = [
                new SqlParameter("@Id", Id),
                new SqlParameter("@Nombre", Nombre),
                new SqlParameter("@FotoPrincipal", FotoPrincipal),
                new SqlParameter("@Edad", edad),
                new SqlParameter("@DatosAcademicos", DatosAcademicos),
                new SqlParameter("@Pasatiempos", Pasatiempos),
                new SqlParameter("@Habilidades", Habilidades),
                new SqlParameter("@Intereses", Intereses),
                new SqlParameter("@Aspiraciones", Aspiraciones)
            ];

            // ejecutar consulta
            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public bool Eliminar(int Id)
        {
            // consulta procedure
            string consulta = "sp_eliminar_candidata";

            SqlParameter[] parametros = [
                new SqlParameter("@CandidataID", Id)
            ];

            // ejecutar consulta
            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public DataSet Buscar(int Id)
        {
            string query = "SELECT * FROM Candidata WHERE CandidataID = " + Id;
            return conexion.EjecutarConsultaSelect(query);
        }

        public DataSet ListarCandidatas()
        {
            string query = "SELECT * FROM Candidata";
            return conexion.EjecutarConsultaSelect(query);
        }

    }

}