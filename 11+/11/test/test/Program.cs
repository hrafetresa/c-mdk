using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { -1, 12, 3, -2, 0, 5 };
            double[] expected = { -1, 5, 3, -2, 0, 2 };
            MyArray.ReversePositive(arr);
            foreach (double d in arr)
            {
                Console.WriteLine(d + "\t");
            }
            Console.WriteLine("qwtwtqwtqw");
        }
    }

    public class MyArray
    {
        public static void ReversePositive(double[] array)
        {
            bool notpos = true;
            int firstPos = 0;
            int lastPos = array.Length - 1;
            while (firstPos < lastPos)
            {
                while (firstPos < array.Length && array[firstPos] <= 0) firstPos++;
                while (lastPos >= 0 && array[lastPos] <= 0) lastPos--;
                if (firstPos < lastPos)
                {
                    double t = array[firstPos];
                    array[firstPos] = array[lastPos];
                    array[lastPos] = t;
                    firstPos++;
                    lastPos--;
                    notpos = false;
                }
            }
            if (notpos) throw new Exception("В массиве нет положительных!");
        }
    }
}
