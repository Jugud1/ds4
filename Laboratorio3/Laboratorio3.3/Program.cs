
public class CalculadoraDeRectangulos
{

    public static double RectanguloArea(double alto, double ancho)

    {



        return alto * ancho;



    }







    internal class Rectangulo
    {
        public static void Main(string[] args)

        {

            Console.WriteLine("INGRESA EL ALTO DEL RECTANGULO");
            double alto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("INGRESA EL ANCHO DEL RECTANGULO");
            double ancho = Convert.ToDouble(Console.ReadLine());


            double rectangulo = CalculadoraDeRectangulos.RectanguloArea(alto, ancho);

            Console.WriteLine("EL AREA DEL RECTANGULO ES {0}:" , rectangulo );





        }
    }
}