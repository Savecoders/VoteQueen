using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgVoteQueen.BLL
{
    public class Comentario
    {
        public int ID { get; set; }
        public int CandidataID { get; private set; } = 0;
        public string Texto { get; private set; } = string.Empty;
        public DateTime Fecha { get; private set; } = DateTime.Now;

        public Comentario(string texto)
        {
            SetTexto(texto);
        }

        public void SetTexto(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                throw new ArgumentException("El comentario no puede estar vacio");
            }

            Texto = texto;
        }

    }
}