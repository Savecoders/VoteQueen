using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class Foto
    {
        public int ID { get; set; }
        private byte[] imagen = [];

        private string titulo;

        private string descripcion;

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        private List<Comentario> comentarios;

        public Foto()
        {
        }

        public Foto(int id, string titulo, string descripcion, byte[] imagen)
        {
            ID = id;
            Titulo = titulo;
            Descripcion = descripcion;
            Imagen = imagen;
        }

        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El titulo no puede estar vacio");
                }

                if (value.Length > 60)
                {
                    throw new ArgumentException("El titulo no puede tener mas de 60 caracteres");
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
            get { return descripcion; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La descripcion no puede estar vacia");
                }

                if (value.Length > 100)
                {
                    throw new ArgumentException("La descripcion no puede tener mas de 200 caracteres");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("La descripcion no puede tener menos de 3 caracteres");
                }

                descripcion = value;
            }
        }

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

        public List<Comentario> Comentarios
        {
            get { return comentarios; }
            set { comentarios = value; }
        }

        public void agregarComentario(Comentario comentario)
        {
            if (comentario == null)
            {
                throw new ArgumentException("El comentario no puede ser nulo");
            }

            Comentarios.Add(comentario);
        }

        public void eliminarComentario(Comentario comentario)
        {
            if (comentario == null)
            {
                throw new ArgumentException("El comentario no puede ser nulo");
            }

            Comentarios.Remove(comentario);
        }
    }
}
