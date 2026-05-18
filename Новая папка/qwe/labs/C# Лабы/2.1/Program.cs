using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размер массива: ");
            // Считываем размер массива
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Некорректный размер массива. Установлено значение по умолчанию: 5.");
                n = 5;
            }

            int[] numbers = new int[n];

            Random rnd = new Random();

            Console.WriteLine($"Исходный массив: ");

            // Заполняем и выводим массив
            for (int i = 0; i < n; i++)
            {
                //Присваиваем элементу случайное значение от -100 до 100
                numbers[i] = rnd.Next(-100, 100);

                //Выводим элемент
                Console.Write($"{numbers[i],-6}");
            }

            int firstIndex = -1;
            int lastIndex = -1;

            // Поиск индекса первого отрицательного элемента
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < 0)
                {
                    firstIndex = i;
                    break;
                }
            }

            // Поиск индекса последнего отрицательного элемента (проход по массиву с конца)
            for (int i = n - 1; i >= 0; i--)
            {
                if (numbers[i] < 0)
                {
                    lastIndex = i;
                    break;
                }
            }

            Console.WriteLine("\nМассив с выделенными элементами:");

            // Проверяем, что в массиве есть хотя бы одно отрицательное число
            if (firstIndex != -1)
            {
                for (int i = 0; i < n; i++)
                {
                    // Проверка на вхождение в промежуток между первым и последним отрицательным числом
                    if (i >= firstIndex && i <= lastIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    // Выводим элемент
                    Console.Write($"{numbers[i], -6}");

                    // Сбрасываем цвет после вывода
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            else
            {
                // Если отрицательных чисел нет, выводим массив без выделения
                Console.WriteLine("Отрицательных элементов для выделения нет.");
                foreach (int number in numbers)
                {
                    Console.Write($"{number, -6}");
                }
                Console.WriteLine();
            }
        }
    }
}