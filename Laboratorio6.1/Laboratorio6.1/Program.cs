using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        int num;

        Console.WriteLine("DIGITE EL NUMERO DESEADO");


        num = Int16.Parse(Console.ReadLine());////////
        try
        {
           




        }
        catch (FormatException ex)
        {
            Console.WriteLine("No ha introducido un digito válido");
            num = -1;
        }


        Console.WriteLine(num);

    }
}