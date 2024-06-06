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
        public string Nombre { get; private set; } = string.Empty;

        public byte[] FotoPrincipal { get; private set; } = [];

        public int Edad { get; private set; } = 0;

        public string DatosAcademicos { get; private set; } = string.Empty;

        public string Pasatiempos { get; private set; } = string.Empty;

        public string Habilidades { get; private set; } = string.Empty;

        public string Intereses { get; private set; } = string.Empty;

        public string Aspiraciones { get; private set; } = string.Empty;

        // Constructor

        public Candidata(string nombre, byte[] fotoPrincipal, int edad, string datosAcademicos, string pasatiempos, string habilidades, string intereses, string aspiraciones)
        {
            SetNombre(nombre);
            SetFotoPrincipal(fotoPrincipal);
            SetEdad(edad);
            SetDatosAcademicos(datosAcademicos);
            SetPasatiempos(pasatiempos);
            SetHabilidades(habilidades);
            SetIntereses(intereses);
            SetAspiraciones(aspiraciones);
        }

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre no puede estar vacio");
            }

            Nombre = nombre;
        }

        public void SetFotoPrincipal(byte[] fotoPrincipal)
        {
            if (fotoPrincipal.Length == 0)
            {
                throw new ArgumentException("La foto principal no puede estar vacia");
            }

            FotoPrincipal = fotoPrincipal;
        }

        public void SetEdad(int edad)
        {
            if (edad < 18)
            {
                throw new ArgumentException("La edad no puede ser menor a 18 años");
            }

            Edad = edad;
        }

        public void SetDatosAcademicos(string datosAcademicos)
        {
            if (string.IsNullOrWhiteSpace(datosAcademicos))
            {
                throw new ArgumentException("Los datos academicos no pueden estar vacios");
            }

            DatosAcademicos = datosAcademicos;
        }

        public void SetPasatiempos(string pasatiempos)
        {
            if (string.IsNullOrWhiteSpace(pasatiempos))
            {
                throw new ArgumentException("Los pasatiempos no pueden estar vacios");
            }

            Pasatiempos = pasatiempos;
        }

        public void SetHabilidades(string habilidades)
        {
            if (string.IsNullOrWhiteSpace(habilidades))
            {
                throw new ArgumentException("Las habilidades no pueden estar vacias");
            }

            Habilidades = habilidades;
        }

        public void SetIntereses(string intereses)
        {
            if (string.IsNullOrWhiteSpace(intereses))
            {
                throw new ArgumentException("Los intereses no pueden estar vacios");
            }

            Intereses = intereses;
        }

        public void SetAspiraciones(string aspiraciones)
        {
            if (string.IsNullOrWhiteSpace(aspiraciones))
            {
                throw new ArgumentException("Las aspiraciones no pueden estar vacias");
            }

            Aspiraciones = aspiraciones;
        }

    }
}