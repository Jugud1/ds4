using System;


public class CalculosMatematicos
{
    //metodo para calcular circulo

    public static double AreaCirculo(double c)

    {
        const double PI = Math.PI;
        double area = PI * Math.Pow(c, 2);


        return area;

    }

    //metodo para calcular
    public static int Calcular(int a, int b)

    {

        return (a + b) * (a - b);

    }

}

//metodo principal del programa
internal class Program
{
    private static void Main(string[] args)

    {
        Console.Write("Ingrese el primer número: ");
        int a = Convert.ToInt32(Console.ReadLine());


        Console.Write("Ingrese el segundo número: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int suma = a + b;

        //Console.WriteLine("La suma de {0} y {1} es 2 ", a, b, suma);


        int resultado = CalculosMatematicos.Calcular(a, b);

        Console.WriteLine($"El resultado de la operación ({a} + {b}) * ({a} - {b}) es: {resultado}");

        Console.Write("Ingrese el radio: ");
        double c = Convert.ToDouble(Console.ReadLine());


        double rescirculo = CalculosMatematicos.AreaCirculo(c);

        Console.WriteLine(" EL AREA DEL CIRCULO ES: {0}", rescirculo);

    }


}
