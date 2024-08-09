using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models.DTO
{
    public class Comentario
    {
        public int ID { get; set; }
        private string texto;
        public DateTime Fecha { get; set; }

        public Estudiante Estudiante { get; set; }


        public Comentario() { }

        public Comentario(string texto)
        {
            Texto = texto;
        }

        public string Texto
        {
            get { return texto; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El comentario no puede estar vacio");
                }

                texto = value;
            }
        }

    }
}