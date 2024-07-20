using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Microsoft.Data.SqlClient;
using Models.DTO;

namespace Models.DAO
{

    public class ComentarioDAO
    {

        private readonly ConexionDb conexion;

        public ComentarioDAO()
        {

        }

        public bool AgregarComentario(
            int CandidataID,
            int EstudianteID,
            Comentario comentario
        )
        {
            // consulta procedure
            string consulta = "sp_registrar_comentario";

            SqlParameter[] parametros = [
                new SqlParameter("@texto", comentario.Texto),
                new SqlParameter("@EstudianteID", EstudianteID),
                new SqlParameter("@CandidataID", CandidataID)
            ];

            // ejecutar consulta
            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public bool EditarComentario(
            Comentario comentario
        )
        {
            // consulta procedure
            string consulta = "sp_actualizar_comentario";

            SqlParameter[] parametros = [
                new SqlParameter("@ComentarioID", comentario.ID),
                new SqlParameter("@texto", comentario.Texto),
            ];

            // ejecutar consulta
            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public bool EliminarComentario(
            Comentario comentario
        )
        {
            // consulta procedure
            string consulta = "sp_eliminar_comentario";

            SqlParameter[] parametros = [
                new SqlParameter("@ComentarioID", comentario.ID),
            ];

            // ejecutar consulta
            return conexion.EjecutarProcedure(consulta, parametros);
        }

    }

}