using System;
using System.Globalization;

namespace Medida
{
    class Program
    {
        static void Main(string[] args)
        {
            double XA, XB, XC, YA, YB, YC;

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            XA = double.Parse(Console.ReadLine());
            XB = double.Parse(Console.ReadLine());
            XC = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            YA = double.Parse(Console.ReadLine());
            YB = double.Parse(Console.ReadLine());
            YC = double.Parse(Console.ReadLine());

            double p = (XA + XB + XC) / 2.0 ;

            double areaX = Math.Sqrt( p*(p- XA) * (p -XB) * (p - XC));

            p = (YA + YB + YC)/ 2.0;

            double areaY = Math.Sqrt(p * (p - YA) * (p - YB) * (p -YC));

            Console.WriteLine("Area de X igual a " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y igual a " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("a maior área é X " +areaX);
            }
            else
            {
                Console.WriteLine("A maior área é Y " + areaY);
            }
        }


    }
}
