using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DTO;

namespace Models.DTO
{
    public class Votacion
    {
        public int ID { get; set; }
        private Estudiante usuario;
        private Candidata candidata;
        public DateTime Fecha { get; set; } = DateTime.Now;
        public TipoVotacion TipoVotacion { get; set; }

        public Votacion()
        {
        }

        public Votacion(Estudiante usuario, Candidata candidata, TipoVotacion tipoVotacion)
        {
            Usuario = usuario;
            Candidata = candidata;
            TipoVotacion = tipoVotacion;
        }


        public Estudiante Usuario
        {
            get { return usuario; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("El usuario no puede ser nulo");
                }

                usuario = value;
            }
        }

        public Candidata Candidata
        {
            get { return candidata; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("La candidata no puede ser nula");
                }

                candidata = value;
            }
        }



    }
}
