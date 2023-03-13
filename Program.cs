using System.Globalization;

namespace Atividade4___Triangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Insira o valor de um dos lados");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor de um dos lados");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor de um dos lados");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Nenhum dos valores deve ser negativo!");
                return;
            }

            Triangulo t = new Triangulo();
            t.a = a;
            t.b = b;
            t.c = c;

            t.ValidarTriangulo();

        }
    }
}