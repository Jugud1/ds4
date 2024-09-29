using Laboratorio8._1;
using System;


class Program

{
    class Trabajador : Persona
    {

        public int Sueldo;

        public Trabajador(string nombre, int edad, string nif, int sueldo)
            : base(nombre, edad, nif)
        {

            Sueldo = sueldo;
        }


    }

    public static void main()
    {

        Trabajador p = new Trabajador("Josan", 22, "77588260-z", 100000);
        Console.WriteLine("Nombre=" + p.Nombre);
        Console.WriteLine("Edad=" + p.edad);
        Console.WriteLine("NIF=" + p.NIF);
        Console.WriteLine("Sueldo=" + p.Sueldo);
        Console.ReadKey();

    }


}