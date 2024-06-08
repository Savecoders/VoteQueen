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
        public required byte[] Imagen { get; set; }

        public void SetImagen(byte[] imagen)
        {
            if (imagen == null)
            {
                throw new ArgumentException("La imagen no puede estar vacia");
            }
            Imagen = imagen;
        }
    }
}
