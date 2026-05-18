using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
    public class MyException : Exception
    {
        public const string ArgumentError = "Неверный аргумент массива!";
        public const string SizeError = "Выход за границы массива!";

        public int Value { get; }

        public MyException(string message)
            : base(message)
        {
        }

        public MyException(string message, int value)
            : base(message)
        {
            Value = value;
        }
    }

    public class Arr
    {
        private int[] a;
        private int size;
        private static Random rnd = new Random();

        #region Конструкторы
        /// <summary>
        /// Конструктор класса по умолчанию
        /// </summary>
        public Arr()
        {
            size = 0;
            a = null;
        }

        /// <summary>
        /// Конструктор класса с одним параметром
        /// </summary>
        /// <param name="n">Размер массива</param>
        public Arr(int n)
        {
            a = new int[n];
            size = n;
        }

        /// <summary>
        /// Конструктор класса со множеством параметров
        /// </summary>
        /// <param name="x"></param>
        /// <exception cref="MyException"></exception>
        public Arr(params int[] x)
        {
            if (x == null) throw new MyException(MyException.ArgumentError);
            else
            {
                size = x.Length;
                a = new int[size];
                for (int i = 0; i < size; i++)
                    a[i] = x[i];
            }
        }

        /// <summary>
        /// Конструктор класса для копирования массива
        /// </summary>
        /// <param name="B">Массив, подлежащий копированию</param>
        /// <exception cref="Exception"></exception>
        public Arr(Arr B)
        {
            if (B.a == null)
            {
                throw new Exception(MyException.ArgumentError);
            }
            else
            {
                size = B.size;
                a = new int[size];
                for (int i = 0; i < size; i++)
                    a[i] = B.a[i];
            }
        }
        #endregion

        #region Ввод массива
        /// <summary>
        /// Метод заполнения массива случайными числами
        /// </summary>
        public void RndInput()
        {
            for (int i = 0; i < size; i++)
                a[i] = rnd.Next(-101, 100);
        }

        /// <summary>
        /// Метод заполнения массива случайными числами от 0 до введенного числа
        /// </summary>
        /// <param name="n1"></param>
        public void RndInput(int n1)
        {
            for (int i = 0; i < size; i++)
                a[i] = rnd.Next(n1 + 1);
        }

        public void RndInput(int n1, int n2)
        {
            try
            {
                for (int i = 0; i < size; i++)
                    a[i] = rnd.Next(n1 + 1, n2);
            }
            catch
            {
                if (n1 >= n2) MessageBox.Show("N1 не может быть больше или равно N2");
            }
        }
        
        /// <summary>
        /// Метод для загрузки массива из файла
        /// </summary>
        /// <param name="filePath">Путь к файлу</param>
        /// <exception cref="Exception"></exception>
        public void LoadFromFile(string filePath)
        {

            string content = File.ReadAllText(filePath).Trim();
            string[] numbers = content.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            this.size = numbers.Length;
            this.a = new int[size];

            for (int i = 0;i < size; i++)
            {
                if (!int.TryParse(numbers[i], out a[i]))
                {
                    throw new Exception("В массиве присутствует нецелочисленный элемент!");
                }
            }
        }

        #endregion

        #region Вывод массива
        /// <summary>
        /// Вывод массива
        /// </summary>
        public void Print()
        {
            Console.WriteLine(this.ToString());
            Console.WriteLine();
        }

        /// <summary>
        /// Вывод массива в label
        /// </summary>
        /// <param name="lbl">label, в котором будет отображаться массив</param>
        public void Print(System.Windows.Forms.Label lbl)
        {
            lbl.Text = this.ToString();
        }

        /// <summary>
        /// Метод распечатки массива в таблицу
        /// </summary>
        /// <param name="dgw"></param>
        public void Print(DataGridView dgw)
        {
            dgw.RowCount = 1;
            dgw.ColumnCount = this.size;
            for (int i = 0; i < this.size; i++)
            {
                dgw.Rows[0].Cells[i].Value = a[i];
            }
            if (a == null)
            {
                dgw.Rows.Clear();
                dgw.Columns.Clear();
            }
        }

        #endregion

        #region Методы
        /// <summary>
        /// Обнуление массива
        /// </summary>
        public void Reset()
        {
            for (int i = 0; i < size; i++)
            {
                a[i] = 0;
            }
        }

        /// <summary>
        /// Метод для очистки массива
        /// </summary>
        public void Clear()
        {
            {
                a = null;
                size = 0;
            }
        }

        /// <summary>
        /// Перезапись метода ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < size; i++)
            {
                s += $"{a[i],5}";
            }
            return s;
        }

        /// <summary>
        /// Метод, перезаписывающий стандартный метод Equals
        /// </summary>
        /// <param name="obj">Объект сравнения</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || obj as Arr == null)
                return false;

            if (size != ((Arr)obj).size)
                return false;

            for (int i = 0; i < size; i++)
                if (a[i] != ((Arr)obj).a[i])
                    return false;

            return true;
        }

        /// <summary>
        /// Перезапись стандартного метода GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Геттер для получения размера массива
        /// </summary>
        public int Size
        {
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Метод к заданию лабораторной работы
        /// </summary>
        /// <returns></returns>
        public void LabTask(out int last, out int first)
        {
            first = -1; 
            last = -1;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                if (a[i] % 3 == 0)
                {
                    if (first == -1) first = i; 
                    last = i; 
                }
            }

            if (first == -1)
            {
                MessageBox.Show("В массиве нет кратных трём элементов");
                return; 
            }

            if (first == last)
            {
                MessageBox.Show("В массиве только один элемент, кратный трём.");
                return;
            }
            else
            {
                for (int i = first + 1; i < last; i++)
                {
                    sum += a[i];
                }

                int temp = a[first];
                a[first] = a[last];
                a[last] = temp;
            }

            MessageBox.Show($"Сумма между первым ({a[last]}) и последним ({a[first]}) элементами: {sum}");
        }

        #endregion

        #region Операторы

        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        /// <exception cref="MyException"></exception>
        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < size)
                {
                    return a[i];
                }
                else
                    return 0;
            }
            set
            {
                if (i >= 0 && i < size)
                    a[i] = value;
                else
                    throw new MyException(MyException.SizeError);
            }
        }
        public static Arr operator ++(Arr A) // перегрузка оператора ++
        {
            Arr temp = new Arr(A);
            for (int i = 0;i < temp.size; i++)
            {
                temp.a[i]++;
            }
            return temp;
        }

        public static Arr operator --(Arr A) // перегрузка оператора --
        {
            Arr temp = new Arr(A);
            for (int i = 0; i < temp.size; i++)
            {
                temp.a[i]--;
            }
            return temp;
        }

        /// <summary>
        /// Оператор сложения
        /// </summary>
        /// <param name="X">Первый операнд</param>
        /// <param name="Y">Второй операнд</param>
        /// <returns></returns>
        public static Arr operator +(Arr X, Arr Y)
        {
            Arr temp;
            if (X.size > Y.size)
            {
                temp = new Arr(X.size);
            }
            else
            {
                temp = new Arr(Y.size);
            }
            for (int i = 0; i < temp.size; i++)
            {
                temp[i] = X[i] + Y[i];
            }
            return temp;
        }

        /// <summary>
        /// Оператор вычитания
        /// </summary>
        /// <param name="X">Первый операнд</param>
        /// <param name="Y">Второй операнд</param>
        /// <returns></returns>
        public static Arr operator -(Arr X, Arr Y)
        {
            Arr temp;
            if (X.size > Y.size)
            {
                temp = new Arr(X.size);
            }
            else
            {
                temp = new Arr(Y.size);
            }
            for (int i = 0; i < temp.size; i++)
            {
                temp[i] = X[i] - Y[i];
            }
            return temp;
        }

        /// <summary>
        /// К каждому элементу массива прибавляется заданное значение
        /// </summary>
        /// <param name="X">Массив</param>
        /// <param name="y">Значение, которое будет прибавляться к каждому элементу массива</param>
        /// <returns></returns>
        public static Arr operator +(Arr X, int y)
        {
            Arr temp =  new Arr(X.size);
            for (int i = 0; i < temp.size; i++)
                temp[i] = X[i] + y;
            return temp;
        }

        /// <summary>
        /// Заданное значение прибавляется к каждому элементу массива
        /// </summary>
        /// <param name="y">Значение, которое будет прибавляться к каждому элементу массива</param>
        /// <param name="X">Массив</param>
        /// <returns></returns>
        public static Arr operator +(int y, Arr X)
        {
            Arr temp = new Arr(X.size);
            for (int i = 0; i < temp.size; i++)
                temp[i] = X[i] + y;
            return temp;
        }

        /// <summary>
        /// Из каждого элемента массива будет вычтено значение
        /// </summary>
        /// <param name="X">Массив</param>
        /// <param name="y">Значение, которое будет вычтено из каждого элемента массива</param>
        /// <returns></returns>
        public static Arr operator -(Arr X, int y)
        {
            Arr temp = new Arr(X.size);
            for (int i = 0; i < temp.size; i++)
                temp[i] = X[i] - y;
            return temp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="y"></param>
        /// <param name="X"></param>
        /// <returns></returns>
        public static Arr operator -(int y, Arr X)
        {
            Arr temp = new Arr(X.size);
            for (int i = 0; i < temp.size; i++)
                temp[i] = X[i] - y;
            return temp;
        }


        #endregion
    }
}
