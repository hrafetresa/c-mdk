namespace Лаба_3._2
{
    internal class Program
    {
        static void ColorMax(int[] array)
        {
            foreach (int item in array)
            {

            }
        }
        static int FindMax(int[] array)
        {
            int max = array[0];
            foreach (var item in array)
            {
                if (item > max) max = item;
            }
            return max;
        }
        static int MaxCount(int[] array)
        {
            int max = FindMax(array);
            int counter = 0;
            foreach (var item in array)
            {
                if (item == max) counter++;
            }
            return counter;
        }
        static void InputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i + 1} элемент: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void PrintArray(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr1 = new int[random.Next(1, 10)];

            int[] arr2 = new int[random.Next(1, 10)];

            int[] arr3 = new int[random.Next(1, 10)];

            Console.WriteLine("Первый массив");
            InputArray(arr1);
            PrintArray(arr1);

            Console.WriteLine("Второй массив");
            InputArray(arr2);
            PrintArray(arr2);

            Console.WriteLine("Третий массив");
            InputArray(arr3);
            PrintArray(arr3);


        }
    }
}
