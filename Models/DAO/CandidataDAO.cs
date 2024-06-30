using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;
using UgVoteQueen.Models.DTO;

namespace UgVoteQueen.Models.DAO
{
    class CandidataDAO
    {

        private readonly ConexionDb conexion;

        public CandidataDAO()
        {
            conexion = new ConexionDb();
        }

        public bool Registrar(
            Candidata candidata
        )
        {
            // consulta procedure
            string consulta = "sp_registrar_candidata";

            SqlParameter[] parametros = [
                new SqlParameter("@Nombre", candidata.Nombre),
                new SqlParameter("@FotoPrincipal", candidata.FotoPrincipal),
                new SqlParameter("@Edad", candidata.Edad),
                new SqlParameter("@DatosAcademicos", candidata.DatosAcademicos),
                new SqlParameter("@Pasatiempos", candidata.Pasatiempos),
                new SqlParameter("@Habilidades", candidata.Habilidades),
                new SqlParameter("@Intereses", candidata.Intereses),
                new SqlParameter("@Aspiraciones", candidata.Aspiraciones)
            ];

            // ejecutar consulta
            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public bool Actualizar(
            Candidata candidata
        )
        {
            // consulta procedure
            string consulta = "sp_actualizar_candidata";

            SqlParameter[] parametros = [
                new SqlParameter("@Id", candidata.ID),
                new SqlParameter("@Nombre", candidata.Nombre),
                new SqlParameter("@FotoPrincipal", candidata.FotoPrincipal),
                new SqlParameter("@Edad", candidata.Edad),
                new SqlParameter("@DatosAcademicos", candidata.DatosAcademicos),
                new SqlParameter("@Pasatiempos", candidata.Pasatiempos),
                new SqlParameter("@Habilidades", candidata.Habilidades),
                new SqlParameter("@Intereses", candidata.Intereses),
                new SqlParameter("@Aspiraciones", candidata.Aspiraciones)
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

        public DataSet Buscar(string Nombre)
        {
            string query = "SELECT * FROM Candidata WHERE Nombre = " + Nombre;
            return conexion.EjecutarConsultaSelect(query);
        }

        public DataSet ListarCandidatas()
        {
            string query = "SELECT * FROM Candidata";
            return conexion.EjecutarConsultaSelect(query);
        }

        public DataSet ListarComentariosCandidata(
            int CandidataID
        )
        {
            string query = "SELECT * FROM Comentario WHERE CandidataID = " + CandidataID;
            return conexion.EjecutarConsultaSelect(query);
        }

    }

}