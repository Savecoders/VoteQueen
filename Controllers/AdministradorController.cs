using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using Models.DTO;
using Models.Repositories;


namespace Controllers
{
    public class AdministradorController
    {
        private readonly AdministradorRepository administradorRepository;

        public AdministradorController(AdministradorRepository administradorRepository)
        {
            this.administradorRepository = administradorRepository;
        }

        public bool LoginAdministrador(
            Administrador administrador
        )
        {
            try
            {
                Administrador administradorLogin = administradorRepository.LoginUsuario(administrador);

                if (administradorLogin != null)
                {

                    AdministradorCache administradorCache = new AdministradorCache
                    {
                        ID = administradorLogin.ID,
                        Nombre = administradorLogin.Nombre,
                        Correo = administradorLogin.Correo,
                        Contrasena = administradorLogin.Contrasena,
                        FotoPerfil = administradorLogin.FotoPerfil,
                        Cargo = administradorLogin.Cargo
                    };

                    SessionManager.Login(administradorCache);

                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo iniciar sesion " + e.Message);
            }

        }

        public bool RegistrarAdministrador(
            Administrador administrador
        )
        {
            try
            {
                return administradorRepository.Add(administrador);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo regristrar el Administrador " + e.Message);
            }

        }

        public bool ActualizarAdministrador(
            Administrador administrador
        )
        {
            try
            {
                return administradorRepository.Update(administrador);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo actualizar el Administrador " + e.Message);
            }

        }

        public bool EliminarAdministrador(
            Administrador administrador
        )
        {
            try
            {
                return administradorRepository.Delete(administrador);
            }
            catch (Exception e)
            {
                throw new Exception("Error: Base de datos | No se pudo eliminar el Administrador " + e.Message);
            }

        }


    }
}