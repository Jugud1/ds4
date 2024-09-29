using System;
using System.Collections.Generic; // Necesario para usar Dictionary

class Program
{
    public static void Main(string[] args)
    {
        // Crear una instancia de la clase Capitales
        Capitales capitales = new Capitales();
        // Llamar al método que muestra las capitales
        capitales.MostrarCapitales();
    }
}

class Capitales
{
    private Dictionary<string, string> paisesYCapitales = new Dictionary<string, string>
    {
        {"Francia", "París" },
        {"España", "Madrid" },
        {"Italia", "Roma" }
    };

    public void MostrarCapitales()
    {
        foreach (KeyValuePair<string, string> par in paisesYCapitales)
        {
            Console.WriteLine("La capital de " + par.Key + " es " + par.Value + " . ");
        }
    }
}