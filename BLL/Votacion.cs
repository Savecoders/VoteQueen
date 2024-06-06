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
        public int CandidataID { get; private set; } = 0;
        public int UsuarioID { get; private set; } = 0;
        public DateTime Fecha { get; private set; } = DateTime.Now;

        public Votacion(int candidataID, int usuarioID)
        {
            SetCandidataID(candidataID);
            SetUsuarioID(usuarioID);
        }

        public void SetCandidataID(int candidataID)
        {
            if (candidataID <= 0)
            {
                throw new ArgumentException("La candidata no puede ser menor o igual a 0");
            }

            CandidataID = candidataID;
        }

        public void SetUsuarioID(int usuarioID)
        {
            if (usuarioID <= 0)
            {
                throw new ArgumentException("El usuario no puede ser menor o igual a 0");
            }

            UsuarioID = usuarioID;
        }   
    }
}
