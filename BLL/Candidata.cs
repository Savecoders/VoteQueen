using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgVoteQueen.BLL
{
    public class Candidata
    {
        public int ID { get; set; }
        private string nombre;
        private int edad;
        private string datosAcademicos;
        private string pasatiempos;
        private string habilidades;
        private string intereses;
        private string aspiraciones;
        public byte[] FotoPrincipal { get; set; } = [];
        public List<Foto> GaleriaFotos { get; set; }
        public List<Comentario> Comentarios { get; set; }


        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre no puede estar vacio");
                }

                nombre = value;
            }
        }


        public int Edad
        {
            get { return edad; }
            set
            {
                if (value < 18)
                {
                    throw new ArgumentException("La edad no puede ser menor a 18 años");
                }

                edad = value;
            }
        }

        public string DatosAcademicos
        {
            get { return datosAcademicos; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Los datos academicos no pueden estar vacios");
                }

                datosAcademicos = value;
            }
        }

        public string Pasatiempos
        {
            get { return pasatiempos; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Los pasatiempos no pueden estar vacios");
                }

                pasatiempos = value;
            }
        }

        public string Habilidades
        {
            get { return habilidades; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Las habilidades no pueden estar vacias");
                }

                habilidades = value;
            }
        }

        public string Intereses
        {
            get { return intereses; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Los intereses no pueden estar vacios");
                }

                intereses = value;
            }
        }

        public string Aspiraciones
        {
            get
            {
                return aspiraciones;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Las aspiraciones no pueden estar vacias");
                }

                aspiraciones = value;
            }
        }



        // Constructor

        public Candidata(string nombre, int edad, string datosAcademicos, string pasatiempos, string habilidades, string intereses, string aspiraciones)
        {
            Nombre = nombre;
            Edad = edad;
            DatosAcademicos = datosAcademicos;
            Pasatiempos = pasatiempos;
            Habilidades = habilidades;
            Intereses = intereses;
            Aspiraciones = aspiraciones;
        }


        public void SetFotoPrincipal(byte[] foto)
        {
            if (foto == null)
            {
                throw new ArgumentException("La foto no puede estar vacia");
            }

            FotoPrincipal = foto;
        }

        public void AgregarFotoGaleria(Foto foto)
        {
            if (foto == null)
            {
                throw new ArgumentException("La foto no puede estar vacia");
            }

            GaleriaFotos.Add(foto);
        }

        public void AgregarComentario(Comentario comentario)
        {
            if (comentario == null)
            {
                throw new ArgumentException("El comentario no puede estar vacio");
            }

            Comentarios.Add(comentario);
        }

    }
}