using System.Globalization;

namespace Lab4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<double> list = [];
            double element = 0;
            Console.WriteLine("Программа для нахождения позиции элемента в массиве при помощи бинарного поиска");
            while (true)
            {
                bool flag = true;
                list = [];
                element = 0;
                Console.WriteLine("Введите исходный массив через ;");
                InputArray(ref list, ref flag);
                if (flag)
                {
                    Console.WriteLine("Введите искомый элемент ");
                    InputElement(ref element);
                    var position = BinarySearch.FindElement([.. list], element);

                    switch (position)
                    {
                        case -1:
                            Console.WriteLine("Элемент не найден");
                            break;
                        case -2:
                            Console.WriteLine("Список пустой");
                            break;
                        default:
                            Console.WriteLine($"Позиция искомого элемента - {position + 1}");
                            break;
                    }
                }
                Console.WriteLine("Выход (e)");
                if (Console.ReadLine() == "e") break;
            }
        }
        static void InputElement(ref double res)
        {
            do
            {
                var input = Console.ReadLine();
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
                input = input.Replace('.', ',');
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
                if (!double.TryParse(input, out res))
                {
                    Console.WriteLine("Неверные данные,попробуйте еще раз");
                }
                else break;
            }
            while (true);
        }
        public static void InputElementTest(ref double res, string input)
        {
            do
            {
                input = input.Replace('.', ',');
                if (!double.TryParse(input, out res))
                {
                    throw new ArgumentException("Error");
                }
                else break;
            }
            while (true);
        }
        static void InputArray(ref List<double> list, ref bool flag)
        {
            try
            {
                double number = 0;
                var input = Console.ReadLine();
                input = input?.Replace('.', ',');
                var res = input?.Split(';');
                foreach (var item in res)
                {
                    if (!double.TryParse(item, NumberStyles.Float, CultureInfo.InvariantCulture, out number))
                    {
                        Console.WriteLine("Неверные данные,попробуйте еще раз");
                        flag = false;
                        break;
                    }
                    else
                    {
                        list.Add(number);
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Введенный список");
                    PrintList(list);
                    var sortedList = list;
                    sortedList.Sort();
                    Console.WriteLine("Отсортированный список");
                    PrintList(sortedList);
                }
            }
            catch
            {

            }
        }
        public static void InputArrayTest(ref List<double> list, ref bool flag, string input)
        {
            try
            {
                double number = 0;
                var res = input.Split(';');
                input = input.Replace('.', ',');
                foreach (var item in res)
                {
                    if (!double.TryParse(item, NumberStyles.Float, CultureInfo.InvariantCulture, out number))
                    {
                        Console.WriteLine("Неверные данные,попробуйте еще раз");
                        flag = false;
                        break;
                    }
                    else
                    {
                        list.Add(number);
                    }
                }
            }
            catch
            {

            }
        }
        static void PrintList(List<double> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + ";");
            }
            Console.WriteLine();
        }
    }
}

