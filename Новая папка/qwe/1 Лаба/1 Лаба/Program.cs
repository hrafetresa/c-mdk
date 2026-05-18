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
            Console.WriteLine("Enter 4 numbers:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter {i} number: ");
                numbers[i] = int.Parse(Console.ReadLine());
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

            foreach (int number in numbers)
            {

                if (number >= -10 && number <= 10)
                {
                    if (number < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition((negativeCounter - 1) * 2, Console.WindowHeight - 1);
                        Console.WriteLine($"{number} ");
                        negativeCounter--;
                    }
                    else if (number == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition((Console.WindowWidth / 2) + zeroCounter * 2, Console.WindowHeight / 2);
                        Console.WriteLine("0 ");
                        zeroCounter--;
                    }
                    else if (number > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition((positiveCounter - 1) * 2, 0);
                        Console.WriteLine($"{number} ");
                        positiveCounter--;
                    }
                }
                Console.ResetColor();
            }
            Console.SetCursorPosition(0, Console.WindowHeight);
        }
    }
}
