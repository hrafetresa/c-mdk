using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class MyArray
    {
        public double[] ReversePositive(double[] array)
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
            return array;
        }
    }
}
