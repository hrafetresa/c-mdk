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

            // Заполняем массив
            for (int i = 0; i < n; i++)
            {
                //Присваиваем элементу случайное значение от -100 до 100
                numbers[i] = rnd.Next(-100, 100);

            }

            int firstIndex = -1;
            int lastIndex = -1;

            // Поиск индекса первого и последнего отрицательного элемента
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] < 0)
                {
                    // Если это самый первый отрицательный элемент (firstIndex еще -1)
                    if (firstIndex == -1)
                    {
                        firstIndex = i;
                    }
                    lastIndex = i;
                }
            }

            Console.WriteLine("\nМассив с выделенными элементами:");

            // Вывод массива
            for (int i = 0; i < n; i++)
            {
                // Проверка на вхождение в промежуток между первым и последним отрицательным числом
                if (i >= firstIndex && i <= lastIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{numbers[i],-6}");
                    Console.ResetColor(); 
                }
                else
                {
                    Console.Write($"{numbers[i],-6}");
                }
            }
            Console.WriteLine();
        }
    }
}