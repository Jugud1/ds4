using System;

class ClaseBase
{

    public void prueba()
    {

    }
    public  void masTests()
    {

    }

}
class ClaseHijo : ClaseBase
{

    public  void masTests()
    {


    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Corrió la aplicación");
        }
    }
}