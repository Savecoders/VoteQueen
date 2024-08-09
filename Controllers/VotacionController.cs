using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DTO;
using Models.Repositories;

namespace Controllers
{
    public class VotacionController
    {
        private readonly VotacionRepository votacionRepository;
        public VotacionController(VotacionRepository votacionRepository)
        {
            this.votacionRepository = votacionRepository;
        }

        public bool RegistrarVotacion(
            Votacion votacion
        )
        {
            try
            {
                return votacionRepository.Votar(votacion);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo regristrar la Votacion " + e.Message);
            }

        }

        public bool DeleteVotacion(
            Votacion votacion
        )
        {
            try
            {
                return votacionRepository.Delete(votacion);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo eliminar la Votacion " + e.Message);
            }
        }

        public int GetVotos(
            Candidata candidata,
            TipoVotacion tipoVotacion
        )
        {
            try
            {
                return votacionRepository.GetVotos(candidata, tipoVotacion);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo obtener los votos " + e.Message);
            }
        }

        public DataSet GetVotaciones(TipoVotacion tipo)
        {
            try
            {
                return votacionRepository.GetVotaciones(tipo);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo obtener las votaciones " + e.Message);
            }
        }

    }
}