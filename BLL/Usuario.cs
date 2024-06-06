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

        public string Nombre { get; private set; } = string.Empty;

        public string Correo { get; private set; } = string.Empty;

        public string Contrasena { get; private set; } = string.Empty;

        public byte[] FotoPerfil { get; set; } = [];

        // Constructor
        public Usuario(string nombre, string correo, string contrasena)
        {
            SetNombre(nombre);
            SetCorreo(correo);
            SetContrasena(contrasena);
        }

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre no puede estar vacio");
            }

            // regex simbolos
            if (Simbolos().IsMatch(nombre))
            {
                throw new ArgumentException("El nombre no puede contener simbolos");

            }

            var listchar = nombre.ToCharArray();
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

            Nombre = nombre;
        }

        public void SetCorreo(string correo)
        {
            if (!correo.Contains('@') || !correo.Contains('.') || !correo.Contains("ug.edu.ec"))
            {
                throw new ArgumentException("El correo debe ser de la Universidad de Guayaquil y debe ser válido");
            }

            Correo = correo;
        }

        public void SetContrasena(string contrasena)
        {
            if (contrasena.Length < 6)
            {
                throw new ArgumentException("La contraseña debe tener al menos 6 caracteres");
            }

            Contrasena = contrasena;
        }


        [GeneratedRegex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]")]
        private static partial Regex Simbolos();
    }
}