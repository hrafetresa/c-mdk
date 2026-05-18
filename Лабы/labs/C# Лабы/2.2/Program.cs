namespace _2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // Генерация двумерного массива со случайными размерами (от 5 до 10 строк и столбцов).
            int[,] array = new int[random.Next(5, 11), random.Next(5, 11)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                // Переключатель обозначает является ли элемент первым в строке.
                bool first = true;

                for (int j = 0; j < array.GetLength(1); j++)
                {

                    array[i, j] = random.Next(1, 500);

                    // Условие окрашивания: 
                    bool toBeColored = array[i, j] % 5 == 0 && first;

                    // Логика окрашивания
                    if (toBeColored)
                    {
                        // Включаем пурпурный цвет.
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.Write($"{array[i, j],-8}");

                        Console.ResetColor();

                        // Сбрасываем переключатель первого элемента.
                        first = false;
                    }
                    else
                    {
                        Console.Write($"{array[i, j],-8}"); 
                    }
                }

                Console.WriteLine();

            }
        }
    }
}