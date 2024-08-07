using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Models.DTO
{
    public class Persona
    {
        public int ID { get; set; }

        private string nombre;

        private string correo;

        private string contrasena;

        private byte[] fotoPerfil = [];

        // Constructor
        public Persona()
        {
        }

        public Persona(
            int id,
            string nombre,
            string correo,
            string contrasena,
            byte[] fotoPerfil
        )
        {
            ID = id;
            Nombre = nombre;
            Correo = correo;
            Contrasena = contrasena;
            FotoPerfil = fotoPerfil;
        }


        // getters y setters
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre no puede estar vacio");
                }

                // regex simbolos
                if (Simbolos().IsMatch(value))
                {
                    throw new ArgumentException("El nombre no puede contener simbolos");

                }

                var listchar = value.ToCharArray();
                bool isDigit = false;
                foreach (var item in listchar)
                {
                    if (char.IsDigit(item))
                    {
                        isDigit = true;
                        break;
                    }
                }

                if (isDigit)
                {
                    throw new ArgumentException("El nombre no puede contener números");
                }

                nombre = value.TrimEnd().ToLower();
            }
        }

        public string Correo
        {
            get { return correo; }
            set
            {
                if (!value.Contains('@') || !value.Contains('.') || !value.Contains("ug.edu.ec"))
                {
                    throw new ArgumentException("El correo debe ser de la Universidad de Guayaquil y debe ser válido");
                }

                correo = value.TrimEnd().ToLower();
            }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La contraseña no puede estar vacia");
                }

                if (value.Length < 8)
                {
                    throw new ArgumentException("La contraseña debe tener al menos 8 caracteres");
                }

                contrasena = value;
            }
        }

        public byte[] FotoPerfil
        {
            get { return fotoPerfil; }
            set { fotoPerfil = value; }
        }

        public override string ToString()
        {
            return "Nombre : " + Nombre + " Correo : " + Correo;
        }

        private static Regex Simbolos()
        {
            return new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
        }

    }

}