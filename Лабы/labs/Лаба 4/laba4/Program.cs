using System;
using System.Collections.Generic;

namespace Lab_Structures
{
    class Program
    {
        // 1. Перечисляемый тип (как в примере)
        enum OrgType
        {
            Государственная = 1,
            Частная,
            Общественная,
            Благотворительная
        }

        // 2. Структура
        struct Organization
        {
            public string Name;
            public OrgType Type;
            public string Address;
            public string Phone;
        }

        // Список структур
        static List<Organization> OrgList = new List<Organization>();

        // МЕТОД: Добавление записи
        static void Add_To_List()
        {
            try
            {
                Organization org = new Organization();

                Console.WriteLine("--- Добавление новой записи ---");

                Console.Write("Название: ");
                org.Name = Console.ReadLine();

                Console.Write(
                        $"{"Государственная",18} - 1" +
                        $"\n{"Частная",18} - 2" +
                        $"\n{"Общественная",18} - 3" +
                        $"\n{"Благотворительная",18} - 4" +
                        $"\nВыберите тип организации (1-4): ");
                int type = Convert.ToInt32(Console.ReadLine());
                org.Type = (OrgType)type;

                Console.Write("Адрес: ");
                org.Address = Console.ReadLine();

                Console.Write("Телефон: ");
                org.Phone = Console.ReadLine();

                OrgList.Add(org);
                Console.WriteLine("Запись успешно добавлена!");
            }
            catch
            {
                Console.WriteLine("Ошибочные данные! Введите заново.");
                Add_To_List();
            }
        }

        // Метод для вывода одной организации
        static void Show(Organization org, int index)
        {
            Console.WriteLine($"{index + 1,-3} | {org.Name,-20} | {org.Type,-20} | {org.Address,-30} | {org.Phone,-15}");
        }

        // Метод вывода всего списка
        static void Show_List()
        {
            if (OrgList.Count == 0)
            {
                Console.WriteLine("Список пуст!");
                return;
            }

            Console.WriteLine("СПИСОК ОРГАНИЗАЦИЙ\n");
            Console.WriteLine($"{"№",-3} | {"Название",-20} | {"Тип",-20} | {"Адрес",-30} | {"Телефон",-15}");
            Console.WriteLine(new string('-', 100));

            for (int i = 0; i < OrgList.Count; i++)
            {
                Show(OrgList[i], i);
            }
        }

        // Метод удаления по индексу
        static void Delete_From_List()
        {
            Show_List();
            if (OrgList.Count == 0) return;

            Console.Write("\nВведите индекс элемента для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index - 1 >= 0 && index - 1 < OrgList.Count)
                {
                    OrgList.RemoveAt(index - 1);
                    Console.WriteLine("Запись удалена.");
                }
                else Console.WriteLine("Ошибка: неверный индекс.");
            }
            else Console.WriteLine("Ошибка: введено не число.");
        }



        // Метод изменения записи по названию
        static void Edit()
        {
            Console.WriteLine("Показать список организаций [Y(да)]?");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
                Show_List();


            Console.Write("Введите название организации для изменения: ");
            string searchName = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < OrgList.Count; i++)
            {
                if (OrgList[i].Name == searchName)
                {
                    found = true;
                    Organization temp = OrgList[i];

                    Console.WriteLine("\nРедактирование (нажмите Enter, чтобы не менять):");

                    // 1. Редактируем Название
                    Console.Write($"Название [{temp.Name}]: ");
                    string newName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newName)) temp.Name = newName;

                    // 2. Редактируем Тип
                    Console.Write($"Тип [{temp.Type}]" +
                        $"\n{"Государственная",18} - 1" +
                        $"\n{"Частная",18} - 2" +
                        $"\n{"Общественная",18} - 3" +
                        $"\n{"Благотворительная",18} - 4" +
                        $"\nВыберите тип (1-4): ");
                    string newTypeStr = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newTypeStr))
                    {
                        if (int.TryParse(newTypeStr, out int typeNum))
                            temp.Type = (OrgType)typeNum;
                    }

                    // 3. Редактируем Адрес
                    Console.Write($"Адрес [{temp.Address}]: ");
                    string newAddress = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newAddress)) temp.Address = newAddress;

                    // 4. Редактируем Телефон
                    Console.Write($"Телефон [{temp.Phone}]: ");
                    string newPhone = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newPhone)) temp.Phone = newPhone;

                    OrgList[i] = temp;
                    Console.WriteLine("\nДанные успешно обновлены!");
                    break;
                }
            }

            if (!found) Console.WriteLine("\nОрганизация не найдена.");
        }

        // Поиск по начальным заданным цифрам телефона
        static void Filter_By_Phone()
        {
            Console.Write("Введите начало номера (например, 8(812)): ");
            string code = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(code))
            {
                Console.WriteLine("\nПоиск отменен: введен пустой запрос.");
                return;
            }

            bool printHeader = true;
            int matchCounter = 0;

            for (int i = 0; i < OrgList.Count; i++)
            {
                if (OrgList[i].Phone.StartsWith(code))
                {
                    if (printHeader)
                    {
                        Console.WriteLine("\nРЕЗУЛЬТАТЫ ПОИСКА:\n");
                        Console.WriteLine($"{"№",-3} | {"Название",-20} | {"Тип",-20} | {"Адрес",-30} | {"Телефон",-15}");
                        Console.WriteLine(new string('-', 100));
                        printHeader = false;
                    }

                    Show(OrgList[i], i);
                    matchCounter++;
                }
            }

            if (matchCounter == 0)
                Console.WriteLine("\nСовпадений не найдено!");
        }

        // Поиск организаций определенного типа
        static void Count_By_Type()
        {
            Console.Write($"Введите тип для подсчета" +
                        $"\n{"Государственная",18} - 1" +
                        $"\n{"Частная",18} - 2" +
                        $"\n{"Общественная",18} - 3" +
                        $"\n{"Благотворительная",18} - 4" +
                        $"\nВыберите тип (1-4): ");
            int t = Convert.ToInt32(Console.ReadLine());
            OrgType searchType = (OrgType)t;
            int counter = 0;
            bool printHeader = true;
            for (int i = 0; i < OrgList.Count; i++)
            {
                if (OrgList[i].Type == searchType)
                {
                    if (printHeader)
                    {
                        Console.WriteLine("\nРЕЗУЛЬТАТЫ ПОИСКА:\n");
                        Console.WriteLine($"{"№",-3} | {"Название",-20} | {"Тип",-20} | {"Адрес",-30} | {"Телефон",-15}");
                        Console.WriteLine(new string('-', 100));
                    }
                    printHeader = false;
                    Show(OrgList[i], i);
                    counter++;
                }
            }
            Console.WriteLine($"\nНайдено организаций типа {searchType}: {counter}");
        }

        static void Main(string[] args)
        {
            OrgList.Add(new Organization
            {
                Name = "йцу11",
                Type = OrgType.Общественная,
                Address = "йцуйцу",
                Phone = "8(812)111-11-11"
            }
            );

            OrgList.Add(new Organization
            {
                Name = "йцу22",
                Type = OrgType.Государственная,
                Address = "йцуйцу",
                Phone = "8(800)222-22-22"
            }
            );

            OrgList.Add(new Organization
            {
                Name = "йцу33",
                Type = OrgType.Благотворительная,
                Address = "йцуйцу",
                Phone = "8(812)333-33-33"
            }
            );


            string[] menu = {
                "Добавить запись",
                "Удалить запись",
                "Показать весь список",
                "Редактировать по названию",
                "Поиск по коду телефона",
                "Подсчет по типу",
                "Выход"
            };

            int num = 0; 

            // МЕНЮ
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"\n МЕНЮ\n");

                // Рисуем меню
                for (int i = 0; i < menu.Length; i++)
                {
                    if (i == num)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($" {menu[i]} ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($" {menu[i]} ");
                    }
                }

                // Навигация 
                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.UpArrow)
                {
                    num = (num == 0) ? menu.Length - 1 : num - 1;
                }

                if (key == ConsoleKey.DownArrow)
                {
                    num = (num == menu.Length - 1) ? 0 : num + 1;
                }
                if (key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    if (num == 6) return;

                    switch (num)
                    {
                        case 0: Add_To_List(); break;
                        case 1: Delete_From_List(); break;
                        case 2: Show_List(); break;
                        case 3: Edit(); break;
                        case 4: Filter_By_Phone(); break;
                        case 5: Count_By_Type(); break;
                    }

                    Console.WriteLine("\nНажмите любую клавишу...");
                    Console.ReadKey();
                }
            }
        }
    }
}