using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._1
{
    class Persona
    {
        public string Nombre;
        public int edad;
        public string NIF;

        void Cumpleaños()
        {


            edad++;
        }

        public Persona(string nombre, int edad, string nif)
        {
            Nombre = nombre;
            edad = edad;
            NIF = nif;
        }
    }
}
