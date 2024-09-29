using System;

public class Program
{
  private static void Main (string[] args)
  {
        Console.WriteLine("Corrio la aplicación");
  }

    class ClaseBase  // en esta parte quité el sealed ya que no puede heredar si la dejo asi
    {

        public void test()
        {

        }
        public void MoreTesting()
        {

        }

    }

    class ClaseHijo : ClaseBase
    {

    }
}
