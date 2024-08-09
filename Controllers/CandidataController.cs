using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DTO;
using Models.Repositories;

namespace Controllers
{
    public class CandidataController
    {
        private readonly CandidataRepository candidataRepository;
        public CandidataController(CandidataRepository candidataRepository)
        {
            this.candidataRepository = candidataRepository;
        }

        public bool RegistrarCandidata(
            Candidata candidata
        )
        {
            try
            {
                return candidataRepository.Add(candidata);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo regristrar la Candidata " + e.Message);
            }

        }

        public bool ActualizarCandidata(
            Candidata candidata
        )
        {
            try
            {
                return candidataRepository.Update(candidata);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo actualizar la Candidata " + e.Message);
            }

        }

        public bool EliminarCandidata(
            Candidata candidata
        )
        {
            try
            {
                return candidataRepository.Delete(candidata);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo eliminar la Candidata " + e.Message);
            }

        }

        public List<Candidata> ListarCandidatas()
        {
            try
            {
                return candidataRepository.GetAll();
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo listar las Candidatas " + e.Message);
            }

        }

        public Candidata ObtenerCandidataId(
            Candidata candidata
        )
        {
            try
            {
                return candidataRepository.Get(candidata);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo obtener la Candidata " + e.Message);
            }

        }

        public List<Candidata> FiltrarCandidatas(
            string condicion
        )
        {
            try
            {
                return candidataRepository.FilterBy(condicion);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo buscar la Candidata " + e.Message);
            }

        }

        public int CantidadGaleriasCandidata(Candidata candidata)
        {
            try
            {
                return candidataRepository.GetCantidadGalerias(candidata);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo contar las galerias de la Candidata " + e.Message);
            }

        }

        public int CantidadFotosCandidata(Candidata candidata)
        {
            try
            {
                return candidataRepository.ObtenerCantidadFotos(candidata);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo contar los votos de la Candidata " + e.Message);
            }

        }
    }
}