namespace _2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта Random для всех случайных операций.
            Random random = new Random();

            // Флаг обозначает является ли элемент первым в строке.
            bool first = true;

            // Генерация двумерного массива со случайными размерами (от 5 до 9 строк и столбцов).
            int[,] array = new int[random.Next(5, 11), random.Next(5, 11)];

            // Итерация по строкам
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // Итерация по столбцам j в текущей строке.
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

                        // Сбрасываем флаг первого элемента.
                        first = false;
                    }

                    // Вывод числа с левым выравниванием (-8) в поле шириной 8 символов.
                    Console.Write($"{array[i, j],-8}");

                    // Сброс цвета если он был установлен
                    if (toBeColored) Console.ResetColor();
                }

                Console.WriteLine();

                // Сбрасываем флаг в true для поиска первого кратного 5 элемента в следующей строке.
                first = true;
            }
        }
    }
}