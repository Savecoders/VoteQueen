using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgVoteQueen.BLL
{
    public class Votacion
    {
        public int ID { get; set; }
        private Usuario usuario;
        private Candidata candidata;
        public DateTime Fecha { get; set; } = DateTime.Now;
        public TipoVotacion TipoVotacion { get; set; }

        public Votacion(Usuario usuario, Candidata candidata, TipoVotacion tipoVotacion, DateTime fecha)
        {
            Usuario = usuario;
            Candidata = candidata;
            TipoVotacion = tipoVotacion;
            Fecha = fecha;
        }


        public Usuario Usuario
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
