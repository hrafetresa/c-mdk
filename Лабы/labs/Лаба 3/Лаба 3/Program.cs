namespace Лаба_3
{
    internal class Program
    {

        // Функция для расчета периметра.
        static double P(double a, double b)
        {
            return 2 * (a + b);
        }

        // Функция для расчета площади.
        static double S(double a, double b, double angleInRadians)
        {
            return a * b * (Math.Sin(angleInRadians));
        }

        // Функция для расчета обеих диагоналей.
        // Ключевое слово 'out' позволяет функции вернуть оба значения.
        static void Diagonals(double a, double b, double angleInRadians, out double d1, out double d2)
        {
            d1 = Math.Sqrt(a * a + b * b + 2 * a * b * Math.Cos(angleInRadians));
            d2 = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angleInRadians));
        }

        static void Main(string[] args)
        {
            // Блок try-catch для обработки ошибок ввода и логических исключений.
            try
            {
                double a, b, angle, angleInRadians;

                //Ввод сторон 
                Console.Write("Введите сторону a: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите сторону b: ");
                b = Convert.ToDouble(Console.ReadLine());

                // Проверка на корректность введенных данных для сторон (стороны > 0) и генерация исключения.
                if (!(a > 0) || !(b > 0))
                {
                    throw new Exception("Стороны должны быть больше нуля!");
                }

                // Ввод угла 
                Console.Write("Введите угол: ");
                angle = Convert.ToDouble(Console.ReadLine());

                // Проверка на то, что угол параллелограмма должен быть в диапазоне от 0 до 180).
                if (angle <= 0 || angle >= 180)
                {
                    throw new Exception("Угол должен быть в диапазоне от 0 до 180!");
                }

                // Преобразование градусов в радианы.
                angleInRadians = angle * Math.PI / 180;


                // Вызов функции P.
                Console.WriteLine($"Периметр равен: {(P(a, b)):F2}");

                // Вызов функции S.
                Console.WriteLine($"Площадь равна: {(S(a, b, angleInRadians)):F2}");

                // Вызов функции Diagonals, получение d1 и d2 через out-параметры.
                Diagonals(a, b, angleInRadians, out double d1, out double d2);

                Console.WriteLine($"Диагональ 1: {d1:F2}");
                Console.WriteLine($"Диагональ 2: {d2:F2}");

            }

            // Перехват ошибки, если пользователь ввел не число.
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}