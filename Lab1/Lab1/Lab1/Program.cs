using System;
using System.Globalization;

namespace Lab1
{

    class Program {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите коэффициенты a, b и c квадратного уравнения:");

                Console.Write("a: ");
                string inputA = Console.ReadLine();

                Console.Write("b: ");
                string inputB = Console.ReadLine();

                Console.Write("c: ");
                string inputC = Console.ReadLine();


                var a = ParseInput(inputA);
                var b = ParseInput(inputB);
                var c = ParseInput(inputC);


                if (a.Item2 == false || b.Item2 == false || c.Item2 == false)
                {
                    Console.WriteLine("Повторный ввод - некорректный ввод");
                    continue;
                }
                if (a.Item1 > 1e15 || b.Item1 > 1e15 || c.Item1 > 1e15 || a.Item1 < -1e15 || b.Item1 < -1e15 || c.Item1 < -1e15)
                {
                    Console.WriteLine("Повторный ввод - слишком большое число");
                    continue;
                }
                if (a.Item1 == 0)
                {
                    Console.WriteLine("Коэффициент a = 0");
                    continue;
                }
                double[] roots = SolveQuadraticEquation(a.Item1, b.Item1, c.Item1);

                if (roots.Length == 0)
                {
                    Console.WriteLine("Уравнение не имеет действительных корней.");
                    break;
                }
                else if (roots.Length == 1)
                {
                    Console.WriteLine($"Уравнение имеет один корень: {roots[0]:F2}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Уравнение имеет два корня: {roots[0]:F2} и {roots[1]:F2}");
                    break;
                }
            }
            Console.ReadLine();
        }
        static (double,bool) ParseInput(string input)
        {
            double result = 0;

            if (input.Contains(' ')) input = input.Replace(" ", "");
            //if (input.Contains(' ')) return (result, false);


            if (input.Contains(','))
            {
                if (double.TryParse(input, out result))
                {
                    result = double.Parse(input, new CultureInfo("ru-ru"));
                    return (result, true);
                }
            }

            if (input.Contains('.') || !input.Contains('.'))
            {
                try
                {
                    result = double.Parse(input, new CultureInfo("en-us"));
                    return (result, true);
                }
                catch
                {
                    return (result, false);
                }
            }
            return (result, false);
        }
        static double[] SolveQuadraticEquation(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return new double[0]; 
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return new double[] { Math.Round(root, 2) };
            }
            else
            {
                double root1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                return new double[] { Math.Round(root1, 2), Math.Round(root2, 2) };
            }
        }
    }
}
