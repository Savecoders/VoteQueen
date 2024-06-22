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
    class GaleriaController
    {
        private readonly ConexionDb conexion;

        public GaleriaController()
        {
            conexion = new ConexionDb();
        }

        public bool RegistrarFotoGaleria(
            Foto foto,
            int GaleriaID
        )
        {
            string consulta = "sp_registrar_foto_galeria";

            SqlParameter[] parametros = [
                new SqlParameter("@Nombre", foto.Imagen),
                new SqlParameter("@GaleriaID", GaleriaID)
            ];

            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public bool ActualizarFoto(
            int FotoID,
            Foto nuevaFoto

        )
        {
            string consulta = "sp_actualizar_foto";

            SqlParameter[] parametros = [
                new SqlParameter("@FotoID", FotoID),
                new SqlParameter("@Imagen", nuevaFoto.Imagen)
            ];

            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public DataSet ObtenerFotosGaleria(Galeria galeria)
        {
            string consulta = "SELECT * FROM Foto WHERE GaleriaID = '" + galeria.ID + "'";
            return conexion.EjecutarConsultaSelect(consulta);
        }


    }
}