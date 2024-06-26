using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;
using UgVoteQueen.Models.DTO;

namespace UgVoteQueen.Models.DAO
{
    class VotacionDAO
    {
        private readonly ConexionDb conexion;

        public VotacionDAO()
        {
            conexion = new ConexionDb();
        }

        public bool Votar(
            Votacion votacion
        )
        {
            string consulta = "sp_registrar_votacion";

            SqlParameter[] parametros = [
                new SqlParameter("@UsuarioID", votacion.Usuario.ID),
                new SqlParameter("@CandidataID", votacion.Candidata.ID),
                new SqlParameter("@TipoVotacion", votacion.TipoVotacion)
            ];

            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public DataSet ObtenerVotosPorCandidata(
            int CandidataID
        )
        {
            string consulta = "SELECT COUNT(*) FROM Votacion WHERE CandidataID = " + CandidataID;

            return conexion.EjecutarConsultaSelect(consulta);

        }

        public DataSet VotosTotales()
        {
            string consulta = "SELECT COUNT(*) FROM Votacion";

            return conexion.EjecutarConsultaSelect(consulta);
        }

    }
}