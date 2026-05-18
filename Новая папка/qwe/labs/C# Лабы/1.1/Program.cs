using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _1_Лаба
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positiveCounter = 0;
            int negativeCounter = 0;
            int zeroCounter = 0;
            int[] numbers = new int[4];

            // Цикл для ввода массива
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter {i} number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                //Считаем кол-во положительных, отрицательных и равных нулю чисел
                if (numbers[i] >= -10 && numbers[i] <= 10)
                {
                    if (numbers[i] < 0)
                    {
                        negativeCounter++;
                    }
                    if (numbers[i] > 0)
                    {
                        positiveCounter++;
                    }
                    if (numbers[i] == 0)
                    {
                        zeroCounter++;
                    }
                }
            }

            Console.Clear();

            //Цикл для вывода чисел на экран
            foreach (int number in numbers)
            {
                if (number >= -10 && number <= 10)
                {
                    // Если число отрицательное, цвет текста меняется на синий, выводися внизу окна
                    if (number < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition((negativeCounter - 1) * 4, Console.WindowHeight - 1);
                        Console.Write($"{number, -4}");
                        negativeCounter--;
                    }
                    // Если число равно нулю, цвет текста меняется на желтый, выводится в центре окна
                    else if (number == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition((Console.WindowWidth / 2) + zeroCounter * 2, Console.WindowHeight / 2);
                        Console.WriteLine("0 ");
                        zeroCounter--;
                    }
                    // Если число положительное, цвет текста меняется на красный, выводится вверху окна
                    else if (number > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition((positiveCounter - 1) * 3, 0);
                        Console.Write($"{number, -3}");
                        positiveCounter--;
                    }
                }
                Console.ResetColor();
            }
            Console.SetCursorPosition(100, Console.WindowHeight - 1);
        }
    }
}
