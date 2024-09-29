using System;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Suma(1.0, 2.0)); 
    }

    static int Suma(int x, int y)
    {
        return x + y;
    }

    static double Suma(double x, double y)
    {
        return x + y;
    }

    static long Suma(long x, long y)
    {
        return x + y;
    }

    // Si quieres manejar tres parámetros
    static double Suma(double x, double y, double z)
    {
        return x + y + z;
    }
}
