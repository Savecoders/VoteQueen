using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UgVoteQueen.Models.DTO
{
    public class Administrador : Persona
    {

        private string cargo;


        // Constructor
        public Administrador()
        {
        }

        public Administrador(
            string nombre,
            string correo,
            string contrasena,
            byte[] fotoPerfil,
            string cargo
        ) : base(nombre, correo, contrasena, fotoPerfil)
        {
            Cargo = cargo;
        }


        // getters y setters

        public string Cargo
        {
            get { return cargo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El cargo no puede estar vacia");
                }

                cargo = value;
            }

        }

    }
}