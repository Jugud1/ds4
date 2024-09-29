// TRY CATCH ENFOCADO A DOS POSIBLES EXCEPECIONES

using System;

class Program

{
    static void Main(string[] args)
    {
        int num;

        Console.WriteLine("Digite el numero deseado");

        try
        {
            num = Int16.Parse(Console.ReadLine());


        }
        catch (OverflowException ex)
        {
            Console.WriteLine("No se ha introducido un numero valido");
            num = -1;
        }
        catch ( Exception ex)
        {
            Console.WriteLine("El numero Introducido es muy grande");
            num = -1;

        }

    }

}


