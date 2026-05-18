namespace _2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rows = new Random();
            Random cols = new Random();
            Random random = new Random();

            int[,] array = new int[rows.Next(5, 10), cols.Next(5, 10)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 500);
                    if (array[i, j] % 5 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(array[i, j] + "\t");
                        Console.ResetColor();
                        continue;
                    }
                    Console.Write(array[i,j] + "\t ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
