namespace _1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correctAnswers = 0;
            int attempts = 0;
            string word;
            Console.WriteLine("Введите слово, у которого первая и последняя буквы одинаковы!");
            //Ввода слов, пока не будет введена пустая строка
            for (; ; )
            {
                Console.Write("Введите слово: ");
                word = Console.ReadLine();

                //Цикл прерывается
                if (string.IsNullOrEmpty(word)) 
                    break;

                attempts++;

                if (char.ToLower(word[0]) == char.ToLower(word[word.Length - 1]))
                {
                    correctAnswers++;
                }
            }
            //Формула подсчета код-ва баллов
            double score = correctAnswers / attempts * 100;

            Console.WriteLine("Результаты: \n");

            Console.WriteLine("Вы набрали " + (int)score + " баллов из 100 \n");

            Console.WriteLine("Кол-во попыток: " + attempts);
        }
    }
}
