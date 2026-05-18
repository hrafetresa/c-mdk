using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arr A = new Arr(5);
            Arr B = new Arr(8);
            A.RndInput();
            B.RndInput(-10, 10);
            Console.WriteLine("Исходные массивы:");
            A.Print();
            B.Print();
            A++;
            B--;
            Console.WriteLine("Инкремент:");
            A.Print();
            Console.WriteLine("Декремент:");
            B.Print();
            Console.WriteLine("Сумма двух массивов:");
            Arr C = A + B;
            C.Print();

        }
    }
}
