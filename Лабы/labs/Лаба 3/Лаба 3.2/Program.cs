using System;

namespace Лаба_3._2
{
    internal class Program
    {

        // Метод для подсчета количества максимальных элементов
        static int MaxCount(int[] array, out int max)
        {
            max = array[0];
            int count = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    count = 1;
                }
                else if (array[i] == max)
                {
                    count++; 
                }
            }
            return count;
        }

        // Метод для заполнения массива
        static void InputArray(int[] array)
        {
            Console.WriteLine($"Введите массив. Кол-во элементов: {array.Length}");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i + 1}-й элемент: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Метод для вывода массива с выделением максимумов желтым цветом
        static void PrintArray(int[] array, int max, bool colorMax)
        {
            foreach (int item in array)
            {
                if (item == max && colorMax)
                    Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write(item + "\t");
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Random random = new Random();

            // Создаем ступенчатый массив из трех строк
            int[][] arr = new int[3][];

            // Инициализация массивов и ввод данных
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[random.Next(3, 8)];
                InputArray(arr[i]);
            }

            // Вывод результатов 
            for (int i = 0; i < arr.Length; i++)
            {
                int counter = MaxCount(arr[i], out int max);

                Console.WriteLine($"\n--- Массив {i + 1} ---");
                Console.WriteLine($"Кол-во максимальных элементов: {counter}");

                PrintArray(arr[i], max, counter > 1);

            }
            Console.ReadKey();
        }
    }
}