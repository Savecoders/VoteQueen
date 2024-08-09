using Common.Cache;
using Models.DTO;
using Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class EstudianteController
    {

        private readonly EstudianteRepository estudianteRepository;

        public EstudianteController(EstudianteRepository estudianteRepository)
        {
            this.estudianteRepository = estudianteRepository;
        }

        public bool LoginEstudiante(
            Estudiante estudiante
        )
        {
            try
            {
                Estudiante estudianteLogin = estudianteRepository.LoginUsuario(estudiante);

                if (estudianteLogin != null)
                {

                    EstudianteCache estudianteCache = new EstudianteCache
                    {
                        ID = estudianteLogin.ID,
                        Nombre = estudianteLogin.Nombre,
                        Correo = estudianteLogin.Correo,
                        Contrasena = estudianteLogin.Contrasena,
                        FotoPerfil = estudianteLogin.FotoPerfil,
                    };

                    SessionManager.Login(estudianteCache);
                    
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo iniciar sesion " + e.Message);
            }

        }

        public bool RegistrarEstudiante(
            Estudiante estudiante
        )
        {
            try
            {
                return estudianteRepository.Add(estudiante);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo regristrar el Estudiante " + e.Message);
            }

        }

        public bool ActualizarEstudiante(
            Estudiante estudiante
        )
        {
            try
            {
                return estudianteRepository.Update(estudiante);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo actualizar el Estudiante " + e.Message);
            }

        }

        public bool EliminarEstudiante(
            Estudiante estudiante
        )
        {
            try
            {
                return estudianteRepository.Delete(estudiante);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo eliminar el Estudiante " + e.Message);
            }

        }

        public List<Estudiante> ListarEstudiantes()
        {
            try
            {
                return estudianteRepository.GetAll();
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo listar los Estudiantes " + e.Message);
            }
        }

        public Estudiante BuscarEstudiante(
            Estudiante estudiante
        )
        {
            try
            {
                return estudianteRepository.Get(estudiante);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo buscar el Estudiante " + e.Message);
            }
        }

        public List<Estudiante> FiltrarEstudiantes(
            string condicion
        )
        {
            try
            {
                return estudianteRepository.FilterBy(condicion);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo buscar los Estudiantes " + e.Message);
            }
        }

        public async Task<bool> VerificarVotoFMCF(
            int estudianteId
        )
        {
            try
            {
                return await estudianteRepository.VerificarVotoFMCF(estudianteId);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo verificar el voto " + e.Message);
            }
        }

        public async Task<bool> VerificarVotoFotogenia(
            int estudianteId
        )
        {
            try
            {
                return await estudianteRepository.VerificarVotoFotogenia(estudianteId);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo verificar el voto " + e.Message);
            }
        }
    }
}