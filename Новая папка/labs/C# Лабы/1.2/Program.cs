using System.Linq;

namespace _1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация счетчиков: правильные ответы, общее число попыток и итоговый балл.
            int correctAnswers = 0;
            int attempts = 0;
            double score = 0;
            string word;

            Console.WriteLine("Введите слово, у которого первая и последняя буквы одинаковы!");

            // Бесконечный цикл для многократного ввода слов.
            for (; ; )
            {
                Console.Write("Введите слово: ");
                word = Console.ReadLine();

                // Условие выхода из цикла: ввод пустой строки.
                if (word == "")
                    break;

                // Проверка всей строки на наличие в ней только букв
                if (!word.All(char.IsLetter))
                {
                    // Выводим ошибку и пропускаем текущую попытку, не увеличивая attempts.
                    Console.WriteLine("Ошибка: Введите только буквенные символы (без цифр и знаков).");
                    continue;
                }

                attempts++;

                // Сравнение первой и последней букв, не учитывая регистр.
                if (char.ToLower(word[0]) == char.ToLower(word[word.Length - 1]))
                {
                    correctAnswers++;
                }
            }

            // Расчет итогового балла: (Правильные ответы / Попытки) * 100.
            // Добавлена проверка, чтобы избежать деления на ноль, если attempts=0.
            if (attempts > 0)
            {
                score = (double)correctAnswers / attempts * 100;
            }

            // Вывод финальных результатов.
            Console.WriteLine("Результаты: \n");

            // Вывод балла, округленного до целого числа.
            Console.WriteLine("Вы набрали " + (int)score + " баллов из 100 \n");

            Console.WriteLine("Кол-во попыток: " + attempts);
        }
    }
}
