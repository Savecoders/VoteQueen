using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class Candidata
    {
        public int ID { get; set; }
        private string nombre;
        private int edad;
        private string telefono;
        private DateTime fechaNacimiento;
        private string pasatiempos;
        private string habilidades;
        private string intereses;
        private string aspiraciones;
        private string carrera;
        private int nivel;
        public byte[] FotoPrincipal { get; set; } = [];
        public Galeria GaleriaFotos { get; set; }
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

                if (value.Length > 60)
                {
                    throw new ArgumentException("El nombre no puede tener mas de 50 caracteres");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("El nombre no puede tener menos de 3 caracteres");
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

        public string Carrera
        {
            get { return carrera; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La carrera no pueden tener vacios");
                }

                if (value.Length > 100)
                {
                    throw new ArgumentException("Los datos academicos no pueden tener mas de 100 caracteres");
                }

                carrera = value;
            }
        }

        public int Nivel
        {
            get { return nivel; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentException("El nivel debe estar entre 1 y 10");
                }

                nivel = value;
            }
        }

        public string Telefono
        {
            get { return telefono; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El telefono no puede estar vacio");
                }

                if (value.Length > 10 || value.Length < 10)
                {
                    throw new ArgumentException("El telefono no puede tener mas ni menos de 10 caracteres");
                }

                if (!value.StartsWith("09"))
                {
                    throw new ArgumentException("El telefono debe empezar con 09");
                }

                telefono = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("La fecha de nacimiento no puede estar vacia");
                }

                fechaNacimiento = value;
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

                if (value.Length > 50)
                {
                    throw new ArgumentException("Los pasatiempos no pueden tener mas de 50 caracteres");
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

                if (value.Length > 50)
                {
                    throw new ArgumentException("Las habilidades no pueden tener mas de 50 caracteres");
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

                if (value.Length > 50)
                {
                    throw new ArgumentException("Los intereses no pueden tener mas de 50 caracteres");
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

                if (value.Length > 80)
                {
                    throw new ArgumentException("Las aspiraciones no pueden tener mas de 80 caracteres");
                }

                aspiraciones = value;
            }
        }



        // Constructor
        public Candidata()
        {
        }

        public Candidata(string nombre, int edad, string carrera, string pasatiempos, string habilidades, string intereses, string aspiraciones, Galeria galeriaFotos)
        {
            Nombre = nombre;
            Edad = edad;
            Carrera = carrera;
            Pasatiempos = pasatiempos;
            Habilidades = habilidades;
            Intereses = intereses;
            Aspiraciones = aspiraciones;
            GaleriaFotos = galeriaFotos;
        }


        public void SetFotoPrincipal(byte[] foto)
        {
            if (foto == null)
            {
                throw new ArgumentException("La foto no puede estar vacia");
            }

            FotoPrincipal = foto;
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