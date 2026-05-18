namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размер массива:  ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i+1} Элемент: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int firstIndex=-1, lastIndex=-1;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < 0)
                {
                    firstIndex = i;
                    break;
                }
            }

            for (int i = n-1; i >= 0; i--)
            {
                if (numbers[i] < 0)
                {
                    lastIndex = i;
                    break;
                }
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i < n; i++)
            {
                if (i == firstIndex) Console.ForegroundColor = ConsoleColor.Blue;
                if (i == lastIndex)
                {
                    Console.Write(numbers[i] + "\t");
                    Console.ResetColor();
                    continue;
                }
                Console.Write(numbers[i] + "\t");
            }
        }
    }
}
