using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DTO;
using Models.Repositories;

namespace Controllers
{
    public class GaleriaController
    {
        private readonly GaleriaRepository galeriaRepository;
        public GaleriaController(GaleriaRepository galeriaRepository)
        {
            this.galeriaRepository = galeriaRepository;
        }

        public int RegistrarGaleria(
            Galeria galeria, int CandidataID
        )
        {
            try
            {
                return galeriaRepository.Add(galeria, CandidataID);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo regristrar la Galeria " + e.Message);
            }

        }

        public bool ActualizarGaleria(
            Galeria galeria
        )
        {
            try
            {
                return galeriaRepository.Update(galeria);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo actualizar la Galeria " + e.Message);
            }

        }

        public bool EliminarGaleria(
            Galeria galeria
        )
        {
            try
            {
                return galeriaRepository.Delete(galeria);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo eliminar la Galeria " + e.Message);
            }

        }

        public Galeria ObtenerGaleria(
            Galeria galeria
        )
        {
            try
            {
                return galeriaRepository.Get(galeria);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo obtener la Galeria " + e.Message);
            }

        }

        public List<Galeria> ListarGaleriasCandidatas(
            Candidata candidata
        )
        {
            try
            {
                return galeriaRepository.GetAllByCandidata(candidata.ID);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo listar las Galerias " + e.Message);
            }

        }

        public List<Galeria> FiltrarGaleriasCandidata(
            string condicion,
            int candidataID
        )
        {
            try
            {
                return galeriaRepository.FilterByCandidatas(
                    condicion,
                    candidataID
                );
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo listar las Galerias " + e.Message);
            }

        }

    }
}