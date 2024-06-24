using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Program
    {
        public static int maxvalue = 50;
        public static int minvalue = 1;
        public static void Main(string[] args)
        {
            Console.WriteLine("Программа для нахождения значения в последовательноси Фибоначчи по его порядковому номеру");
            Fibonacci fibonachi = new();
            int res = 0;
            while (true)
            {
                Input(ref res);
                var num = fibonachi.FibonachiByIndex(res);
                Console.WriteLine(num);
            }
        }
        static void Input(ref int res)
        {
            bool flag = true;
            do
            {
                Console.Write("index : ");
                var input = Console.ReadLine();
                if (!int.TryParse(input, out res) || res > maxvalue || res < minvalue)
                {
                    Console.WriteLine("Введены некорректные данные");
                }
                else flag = false;
            }
            while (flag);
        }
    }
}

















/*bool flag = false;
bool exit = true;
int res = 0;
long value = 0;
start:
flag = false;
Console.Write("Введите порядковый номер: ");
string input = Console.ReadLine();
Fibonacci fibonacci = new();
InputParse(ref res);
value = fibonacci.FibonachiByIndex(fibonacci.res);
if (flag == true) Console.WriteLine("Значение в последовательности по порядковому номеру " + res + " равно " + value);
if (input == "e" || flag == true) goto start;*/