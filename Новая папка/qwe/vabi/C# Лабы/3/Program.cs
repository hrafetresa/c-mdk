using System.Drawing;

namespace _3
{
    internal class Program
    {
        static double P(double a, double b)
        {
            return 2 * (a + b);
        }

        static double S(double a, double b, double angleInRadians)
        {
            return a * b * (Math.Sin(angleInRadians));
        }

        static void Diagonals(double a, double b, double angleInRadians, out double d1, out double d2)
        {
            d1 = Math.Sqrt(a * a + b * b + 2 * a * b * Math.Cos(angleInRadians));
            d2 = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angleInRadians));
        }
        static void Main(string[] args)
        {
            try
            {
                double a, b, angle, angleInRadians;
                Console.Write("Введите сторону a: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите сторону b: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите угол: ");
                angle = Convert.ToDouble(Console.ReadLine());

                angleInRadians = angle * Math.PI / 180;

                Console.WriteLine($"Периметр равен: {(P(a, b)):F2}");
                Console.WriteLine($"Площадь равна: {(S(a, b, angleInRadians)):F2}");

                Diagonals(a, b, angleInRadians, out double d1, out double d2);

                Console.WriteLine($"Диагональ 1: {d1:F2}");
                Console.WriteLine($"Диагональ 2: {d2:F2}");

            }
            catch(FormatException)
            {
                Console.WriteLine("Не цифры вводишь малой");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
