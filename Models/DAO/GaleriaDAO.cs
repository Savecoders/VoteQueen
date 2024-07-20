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
    public class GaleriaDAO
    {
        private readonly ConexionDb conexion;

        public GaleriaDAO()
        {
            conexion = new ConexionDb();
        }

        public bool RegistrarGaleria(
            Galeria galeria
        )
        {
            string consulta = "sp_registrar_galeria";

            SqlParameter[] parametros = [
                new SqlParameter("@Titulo", galeria.Titulo),
                new SqlParameter("@Descripcion", galeria.Descripcion)
            ];

            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public bool ActualizarGaleria(
            Galeria galeria
        )
        {
            string consulta = "sp_actualizar_galeria";

            SqlParameter[] parametros = [
                new SqlParameter("@GaleriaID", galeria.ID),
                new SqlParameter("@Titulo", galeria.Titulo),
                new SqlParameter("@Descripcion", galeria.Descripcion)
            ];

            return conexion.EjecutarProcedure(consulta, parametros);
        }

        public bool AgregarFotoGaleria(
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

        public bool ActualizarFotoGaleria(
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