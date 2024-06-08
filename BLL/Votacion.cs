using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgVoteQueen.BLL
{
    public enum TipoVotacion
    {
        MissFotogenia,
        MissFMC,
    }

    public class Votacion
    {
        public int ID { get; set; }
        public Usuario Usuario { get; set; }
        public Candidata Candidata { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public TipoVotacion TipoVotacion { get; set; }

        public Votacion(Usuario usuario, Candidata candidata, TipoVotacion tipoVotacion)
        {
            SetUsuario(usuario);
            SetCandidata(candidata);
            SetTipoVotacion(tipoVotacion);
        }

        public void SetUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentException("El usuario no puede ser nulo");
            }

            Usuario = usuario;
        }

        public void SetCandidata(Candidata candidata)
        {
            if (candidata == null)
            {
                throw new ArgumentException("La candidata no puede ser nula");
            }

            Candidata = candidata;
        }

        public void SetTipoVotacion(TipoVotacion tipoVotacion)
        {
            TipoVotacion = tipoVotacion;
        }

    }
}
