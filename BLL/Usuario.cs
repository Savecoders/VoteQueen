using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UgVoteQueen.BLL
{
    public class Usuario
    {

        public int ID { get; set; }
        private string nombre = string.Empty;
        private string correo = string.Empty;
        private string contrasena = string.Empty;
        public byte[] FotoPerfil { get; set; } = [];
        public Rol Rol { get; set; }

        public Usuario(string nombre, string correo, string contrasena, Rol rol, byte[] fotoPerfil)
        {
            Nombre = nombre;
            Correo = correo;
            Contrasena = contrasena;
            Rol = rol;
            FotoPerfil = fotoPerfil;
        }


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

                nombre = value;
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

                correo = value;
            }
        }
        public string Contrasena
        {
            get { return contrasena; }
            set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("La contraseña debe tener al menos 6 caracteres");
                }

                contrasena = value;
            }
        }



        private static Regex Simbolos()
        {
            return new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
        }
    }
}