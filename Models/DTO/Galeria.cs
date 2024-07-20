using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class Galeria
    {
        private string titulo;
        private string descripcion;
        public int ID { get; set; }
        public List<Foto> Fotos { get; set; }

        public Galeria(string titulo, string descripcion, List<Foto> fotos)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            Fotos = fotos;
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El titulo no puede estar vacio");
                }

                if (value.Length > 50)
                {
                    throw new ArgumentException("El titulo no puede tener mas de 50 caracteres");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("El titulo no puede tener menos de 3 caracteres");
                }

                titulo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La descripcion no puede estar vacia");
                }

                if (value.Length > 500)
                {
                    throw new ArgumentException("La descripcion no puede tener mas de 500 caracteres");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("La descripcion no puede tener menos de 3 caracteres");
                }

                descripcion = value;
            }
        }

        public void AgregarFoto(Foto foto)
        {
            Fotos.Add(foto);
        }

    }
}