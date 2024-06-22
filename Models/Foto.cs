using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgVoteQueen.BLL
{
    public class Foto
    {
        public int ID { get; set; }
        private byte[] imagen = [];

        public byte[] Imagen
        {
            get { return imagen; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Tiene que recibir una imagen");
                }

                imagen = value;
            }
        }
    }
}
