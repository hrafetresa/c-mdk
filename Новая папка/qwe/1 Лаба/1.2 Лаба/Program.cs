using System;

class Program
{
    static void Main()
    {
        int correctAnswers = 0;
        int attempts = 0;
        double score = 0;
        string word;
        Console.WriteLine("Введите слово, у которого первая и последняя буквы одинаковы!");
        for (; ; )
        {

            Console.Write("Введите слово: ");
            word = Console.ReadLine();
            if (string.IsNullOrEmpty(word)) break;
            attempts++;
            if (char.ToLower(word[0]) == char.ToLower(word[word.Length - 1]))
            {
                correctAnswers++;
            }
        }
        score = (double)correctAnswers / attempts * 100;
        Console.WriteLine("Результаты: \n");
        Console.WriteLine("Вы набрали " + (int)score + " баллов из 100 \n");
        Console.WriteLine("Кол-во попыток: " + attempts);
    }
}