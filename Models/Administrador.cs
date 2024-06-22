using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UgVoteQueen.Models
{
    public class Administrador : Persona
    {

        private byte[] fotoPerfil = [];
        private string matricula;


        // Constructor
        public Administrador()
        {
        }

        public Administrador(
            string nombre,
            string correo,
            string contrasena,
            byte[] fotoPerfil,
            string matricula
        ) : base(nombre, correo, contrasena)
        {
            FotoPerfil = fotoPerfil;
            Matricula = matricula;
        }


        // getters y setters

        public byte[] FotoPerfil
        {
            get { return fotoPerfil; }
            set { fotoPerfil = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La matricula no puede estar vacia");
                }

                matricula = value;
            }

        }

    }
}