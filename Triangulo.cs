using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4___Triangulos
{
    public class Triangulo
    {
        public double a, b, c;

        public void ValidarTriangulo()
        {
            if(a == b && a == c)
            {
                Console.WriteLine("Triango EQUILATERO");
            }
            else if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a) )
            {
                Console.WriteLine("Triango ISOSCELES");
            }
            else if ( a >= (b+c) )
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if ( (a * a) == ( (b*b) + (c*c) ) )
            {
                Console.WriteLine("Triango RETANGULO");
            }
            else if ((a * a) > ((b * b) + (c * c)))
            {
                Console.WriteLine("Triango OBTUSANGULO");
            }
            else if ((a * a) < ((b * b) + (c * c)))
            {
                Console.WriteLine("Triango ACUTANGULO");
            }
        }
    }
}
