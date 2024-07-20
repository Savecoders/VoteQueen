using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Models.DTO
{
    public class Estudiante : Persona
    {

        private string matricula;


        // Constructor
        public Estudiante()
        {
        }

        public Estudiante(
            string nombre,
            string correo,
            string contrasena,
            byte[] fotoPerfil,
            string matricula
        ) : base(nombre, correo, contrasena, fotoPerfil)
        {
            Matricula = matricula;
        }


        // getters y setters



        public string Matricula
        {
            get { return matricula; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La matricula no puede estar vacia");
                }

                // regex simbolos
                if (Simbolos().IsMatch(value))
                {
                    throw new ArgumentException("La matricula no puede contener simbolos");

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

                if (!isDigit)
                {
                    throw new ArgumentException("La matricula debe contener al menos un digito");
                }

                matricula = value;
            }

        }



        private static Regex Simbolos()
        {
            return new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
        }
    }
}