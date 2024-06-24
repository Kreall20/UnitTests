using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;

namespace Lab6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите массив черер пробел");
            var list = InputArray();
            var positivelist = PositivEelements(list);
            Console.WriteLine("Положительные элементы массива");
            PrintList(positivelist);
            Console.WriteLine("Введите матрицу");
            var matrix = InputMatrix();
            PrintMatrix(matrix);
            var columnsum = Columnsum(matrix);
            Console.WriteLine("Суммы столбцов матрицы");
            PrintList(columnsum);
        }
        public static List<double> InputArray()
        {
            var list = new List<double>();
            var input = Console.ReadLine();
            var StringArr = input.Split(' ');
            foreach (var item in StringArr)
            {
                if (!double.TryParse(item, NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                {
                    Console.WriteLine("Неверные данные,попробуйте еще раз");
                    break;
                }
                else
                {
                    list.Add(number);
                }
            }
            return list;
        }
        public static List<double> PositivEelements(List<double> list,int m = -1)
        {
            if (m == -1) m = list.Count;
            
            var newlist = new List<double>();
            /*foreach(var item in list)
            {
                if (item > 0) newlist.Add(item);
            }*/
            for(int i = 0; i < m; i++)
            {
                if (list[i] > 0) newlist.Add(list[i]);
            }
            return newlist;
        }
        public static double[,] InputMatrix()
        {
            Console.WriteLine("Введите размер матрицы");
            var sizestr = Console.ReadLine();
            int size = int.Parse(sizestr);
            double[,] matrix = new double[size, size];
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write("Введите элемент: ");
                    var element = Console.ReadLine();
                    matrix[i, j] = double.Parse(element);
                }
            }
            return matrix;
        }
        public static List<double> Columnsum(double[,] matrix, int m = -1, int k = -1)
        {
            if (m == -1 || k == -1)
            {
                m = matrix.GetLength(0);
                k = matrix.GetLength(1);
            }
            var columnsum = new List<double>();
            double sum = 0;
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < k; j++)
                {
                    sum += matrix[j, i];
                }
                columnsum.Add(sum);
                sum = 0;
            }
            return columnsum;
        }
        static void PrintList(List<double> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}