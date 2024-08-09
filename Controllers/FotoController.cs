using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DTO;
using Models.Repositories;

namespace Controllers
{
    public class FotoController
    {
        private readonly FotoRepository fotoRepository;

        public FotoController(FotoRepository fotoRepository)
        {
            this.fotoRepository = fotoRepository;
        }

        public bool RegistrarFoto(
            Foto foto, int GaleriaID
        )
        {
            try
            {
                return fotoRepository.Add(foto, GaleriaID);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo regristrar la Foto " + e.Message);
            }

        }

        public bool ActualizarFoto(
            Foto foto
        )
        {
            try
            {
                return fotoRepository.Update(foto);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo actualizar la Foto " + e.Message);
            }

        }

        public bool EliminarFoto(
            Foto foto
        )
        {
            try
            {
                return fotoRepository.Delete(foto);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo eliminar la Foto " + e.Message);
            }
        }


        public List<Foto> ObtenerFotosGaleria(Galeria galeria)
        {

            try
            {
                return fotoRepository.GetFotos(galeria);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo obtener las fotos de la galeria " + e.Message);
            }

        } 


    }
}
