using System;

namespace cs_1._24_AreaTriangulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            double a, b, c, p, area;

            Console.Write("Digite o primeiro lado do triângulo: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo lado do triângulo: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro lado do triângulo: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine();

            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);
            p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"\nÁrea do triângulo {area}");
        }
    }
}
