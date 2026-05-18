namespace ArrayProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray();
            double[] array = { -1, 2, 3, -2, 4, 0, -5, 6, 7, 8, 9, -10 };
            myArray.ReversePositive(array);
            foreach (double value in array)
            {
                Console.Write(value + "\t");
            }
        }
    }

    public class MyArray
    {
        public double[] ReversePositive(double[] array)
        {
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
                }
            }
            return array;
        }
    }
}
