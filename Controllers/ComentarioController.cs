using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DTO;
using Models.Repositories;

namespace Controllers
{
    public class ComentarioController
    {
        private readonly ComentarioRepository comentarioRepository;
        public ComentarioController(ComentarioRepository comentarioRepository)
        {
            this.comentarioRepository = comentarioRepository;
        }

        public bool RegistrarComentario(
            Comentario comentario,
            Foto foto
        )
        {
            try
            {
                return comentarioRepository.Add(comentario, foto);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo regristrar el Comentario " + e.Message);
            }

        }

        public bool ActualizarComentario(
            Comentario comentario
        )
        {
            try
            {
                return comentarioRepository.Update(comentario);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo actualizar el Comentario " + e.Message);
            }

        }

        public bool EliminarComentario(
            Comentario comentario
        )
        {
            try
            {
                return comentarioRepository.Delete(comentario);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo eliminar el Comentario " + e.Message);
            }
        }

        public List<Comentario> ObtenerPorFoto(
            int id
        )
        {
            try
            {
                return comentarioRepository.FilterByFoto(id);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo obtener los Comentarios " + e.Message);
            }
        }

        public bool AsignarComentarioFoto(
            Comentario comentario, int FotoID
        )
        {
            try
            {
                return comentarioRepository.AsignarComentarioFoto(comentario, FotoID);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo asignar el Comentario a la Foto " + e.Message);
            }
        }

    }
}