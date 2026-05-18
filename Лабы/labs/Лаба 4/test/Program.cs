namespace Структуры_и_коллекции
{
    class Program
    {
        enum Category
        {
            Без_категории,
            Друзья,
            Сотрудники,
            Родственники
        }
        struct Note
        {
            public string name;
            public string telefon;
            public DateTime birthday;
            public Category category;
        };

        static List<Note> MyList = new List<Note>();

        static void Add_To_List()
        {
            Note N = new Note();
            try
            {
                Console.WriteLine("Введите имя:");
                N.name = Console.ReadLine();
                Console.WriteLine("Введите телефон:");
                N.telefon = Console.ReadLine();
                Console.WriteLine("Введите день рождения:");
                N.birthday = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Введите категорию контакта:\n  1 - Друзья\n  2 - Сотрудники\n  3 - Родственники\n");
                N.category = (Category)(Convert.ToInt32(Console.ReadLine()));
                MyList.Add(N);
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Ошибочные данные! Введите заново.");
                Add_To_List();
            }
        }

        static void Show_List()
        {
            for (int i = 0; i < MyList.Count; i++)
            {
                Show(MyList[i]);
            }
            Console.WriteLine();
        }

        static void Show(Note N)
        {
            Console.WriteLine("Имя: " + N.name);
            Console.WriteLine("Телефон: " + N.telefon);
            Console.WriteLine("День рождения: " + N.birthday.ToShortDateString());
            Console.WriteLine("Категория контакта: " + N.category);
            Console.WriteLine("--------------------------------------");
        }

        static void Main(string[] args)
        {
            Add_To_List();
            Add_To_List();
            Add_To_List();
            Show_List();
            Console.ReadKey();
        }
    }
}
