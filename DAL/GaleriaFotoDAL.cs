using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Microsoft.Data.SqlClient;
using UgVoteQueen.BLL;

namespace UgVoteQueen.DAL
{
    class GaleriaFotoDAL
    {
        private readonly ConexionDb conexion;

        public GaleriaFotoDAL()
        {
            conexion = new ConexionDb();
        }

        public bool RegistrarFotoGaleria(
            Foto foto,
            int CandidataID
        )
        {
            string consulta = "sp_registrar_foto_galeria";

            SqlParameter[] parametros = [
                new SqlParameter("@Nombre", foto.Imagen),
                new SqlParameter("@CandidataID", CandidataID)
            ];

            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public DataSet ObtenerGaleriasFoto()
        {
            string consulta = "SELECT * FROM GaleriaFoto";
            return conexion.EjecutarConsultaSelect(consulta);
        }

    }
}