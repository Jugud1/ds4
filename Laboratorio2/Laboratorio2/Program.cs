using System;
using static laboratorio2.Program;


namespace laboratorio2
{
    class Program
    {
       static void Main (string[] args)

        {
         Client client = new Client();
            //Ejemplo utilizando las variables de instancia de clase.

            client.FirstName = "Su-Nombre";
            client.LastName = "Su_Apellido";
            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());
            


        }

        public class Client
        { 
          public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public ushort Age { get; set; }

            public string GetFullName()

            {
                return FirstName + " " + LastName;

            }
        
          
        
        
        }

    }

   



}



internal class Program
{

    private static void Main(string[] args)

    {
        Client client = new Client();
        //Ejemplo utilizando las variables de instancia de clase.

        client.FirstName = "Su-Nombre";
        client.LastName = "Su_Apellido";
        client.Age = 15;
        client.Id = 1;

        Console.WriteLine(client.GetFullName());

    }


    public class MyClass
        {
        public static int Valor;  // declarando variable estátca
         
               
        }
    
    
    public void Sumar(int valor1, int valor2)
    {
        int variablelocal = valor1 + valor2;
        Console.WriteLine(variablelocal);

    }




}