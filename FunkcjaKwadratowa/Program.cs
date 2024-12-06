using System.Numerics;

namespace FunkcjaKwadratowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program do obliczania miejsc zerowych funkcji kwadratowej ax^2 + bx + c.");

            Console.Write("Podaj współczynnik a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj współczynnik b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj współczynnik c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("To nie jest równanie kwadratowe (a = 0).");
                return;
            }

            double delta = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine($"Delta: {delta}");

            if (delta >= 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Miejsca zerowe w dziedzinie liczb rzeczywistych:");
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else
            {
               double x1 = (-b - Math.Sqrt(Math.Abs(delta))) / (2 * a);
               double x2 = (-b + Math.Sqrt(Math.Abs(delta))) / (2 * a);

                Console.WriteLine("Miejsca zerowe w dziedzinie liczb zespolonych:");
                Console.WriteLine($"x1 = {x1}i, x2 = {x2}i <==> i = -1");
            }
        }
    }
}
