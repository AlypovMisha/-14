using _10LabDll;
using _12LabLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Лабораторная_14
{
    public static class Program
    {
        static void Main(string[] args)
        {
            ChoicePart();
        }

        public static void PrintMenu()
        {
            Console.WriteLine("\t|||Выберите часть|||");
            Console.WriteLine("1. Первая часть");
            Console.WriteLine("2. Вторая часть");
            Console.WriteLine("3. Вывести меню");
            Console.WriteLine("4. Выход");
        }

        public static void ChoicePart()
        {
            PrintMenu();
            string choice = null;
            Console.Write("Ваш выбор: ");
            while (choice != "4")
            {
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        PrintMenuForPart1();
                        ChoiceForPart1();
                        break;
                    case "2":
                        PrintMenuForPart2();
                        ChoiceForPart2();
                        break;
                    case "3":
                        Console.WriteLine();
                        PrintMenu();
                        break;
                    case "4":
                        break;
                    default:
                        Console.Write("Вы ввели не правильное значение, повторите ввод: ");
                        break;
                }
            }
        }

        public static void PrintMenuForPart1()
        {
            Console.WriteLine("\n\t|||Первая часть|||");
            Console.WriteLine("1. Сформировать коллекцию");
            Console.WriteLine("2. Вывести на экран все коллекции");
            Console.WriteLine("3. Вывести на экран машины определенного бренда (демонстрация Where LINQ)");
            Console.WriteLine("4. Найти одинаковые машины (демонстрация Intersect LINQ)");
            Console.WriteLine("5. Найти автомобиль с максимальной ценой (демонстрация Max LINQ)");
            Console.WriteLine("6. Сгруппировать по марке (демонстрация Group By LINQ)");
            Console.WriteLine("7. Адрес доставки автомобилей (демонстрация Join LINQ)");
            Console.WriteLine("8. Вывести на экран машины определенного бренда (демонстрация Where методом расширения)");
            Console.WriteLine("9. Найти одинаковые машины (демонстрация Intersect методом расширения)");
            Console.WriteLine("10. Найти автомобиль с максимальной ценой (демонстрация Max методом расширения)");
            Console.WriteLine("11. Сгруппировать по марке (демонстрация Group By методом расширения)");
            Console.WriteLine("12. Адрес доставки автомобилей (демонстрация Join методом расширения)");
            Console.WriteLine("13. Вывести меню");
            Console.WriteLine("14. Выход");
        }

        public static void PrintMenuForPart2()
        {
            Console.WriteLine("\n\t|||Вторая часть|||");
            Console.WriteLine("1. Сформировать коллекцию");
            Console.WriteLine("2. Вывести коллекцию на экран");
            Console.WriteLine("3. Вывести на экран машины определенного бренда (демонстрация Where LINQ)");
            Console.WriteLine("4. Посчитать количество желтых машин (демонстрация Count LINQ)");
            Console.WriteLine("5. Подсчитать сумму стоимостей всех автомобилей (демонстрация Sum LINQ)");
            Console.WriteLine("6. Сгруппировать по мпрке (демонстрация Group By LINQ)");
            Console.WriteLine("7. Вывести на экран машины определенного бренда (демонстрация Where методом расширения)");
            Console.WriteLine("8. Посчитать количество желтых машин (демонстрация Count методом расширения)");
            Console.WriteLine("9. Подсчитать сумму стоимостей всех автомобилей (демонстрация Sum методом расширения)");
            Console.WriteLine("10. Сгруппировать по марке (демонстрация Group By методом расширения)");
            Console.WriteLine("11. Вывести меню");
            Console.WriteLine("12. Выход");
        }

        public static void ChoiceForPart1()
        {
            string choice = null;
            Queue<List<Cars>> carFactory = new Queue<List<Cars>>();
            Queue<List<Cars>> carFactory1 = new Queue<List<Cars>>();
            while (choice != "14")
            {
                Console.Write("Ваш выбор: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        try
                        {
                            Console.Write("Введите количество автомобилей в цехах: ");
                            carFactory.Clear();
                            carFactory1.Clear();
                            int countOfAuto = int.Parse(Console.ReadLine());
                            List<Cars> carWorkShop = new List<Cars>(countOfAuto);
                            List<Cars> psCarWorkShop = new List<Cars>(countOfAuto);
                            List<Cars> trCarWorkShop = new List<Cars>(countOfAuto);
                            List<Cars> ofrCarWorkShop = new List<Cars>(countOfAuto);
                            List<Cars> carWorkShop1 = new List<Cars>(countOfAuto);
                            List<Cars> psCarWorkShop1 = new List<Cars>(countOfAuto);
                            List<Cars> trCarWorkShop1 = new List<Cars>(countOfAuto);
                            List<Cars> ofrCarWorkShop1 = new List<Cars>(countOfAuto);
                            for (int i = 0; i < countOfAuto; i++)
                            {
                                Cars car = new Cars();
                                car.RandomInit();
                                carWorkShop.Add(car);
                                PassengerCar psCar = new PassengerCar();
                                psCar.RandomInit();
                                psCarWorkShop.Add(psCar);
                                TruckCar truckCar = new TruckCar();
                                truckCar.RandomInit();
                                trCarWorkShop.Add(truckCar);
                                OffRoadCar offRoadCar = new OffRoadCar();
                                offRoadCar.RandomInit();
                                ofrCarWorkShop.Add(offRoadCar);
                            }
                            for (int i = 0; i < countOfAuto; i++)
                            {
                                Cars car = new Cars();
                                car.RandomInit();
                                carWorkShop1.Add(car);
                                PassengerCar psCar = new PassengerCar();
                                psCar.RandomInit();
                                psCarWorkShop1.Add(psCar);
                                TruckCar truckCar = new TruckCar();
                                truckCar.RandomInit();
                                trCarWorkShop1.Add(truckCar);
                                OffRoadCar offRoadCar = new OffRoadCar();
                                offRoadCar.RandomInit();
                                ofrCarWorkShop1.Add(offRoadCar);
                            }
                            //Добавляется автомобиль для метода Intersect
                            Cars specialCar = new Cars();
                            specialCar.RandomInit();
                            carWorkShop.Add(specialCar);
                            psCarWorkShop.Add(specialCar);
                            trCarWorkShop.Add(specialCar);
                            ofrCarWorkShop.Add(specialCar);
                            carWorkShop1.Add(specialCar);
                            psCarWorkShop1.Add(specialCar);
                            trCarWorkShop1.Add(specialCar);
                            ofrCarWorkShop1.Add(specialCar);
                            carFactory.Enqueue(carWorkShop);
                            carFactory.Enqueue(psCarWorkShop);
                            carFactory.Enqueue(trCarWorkShop);
                            carFactory.Enqueue(ofrCarWorkShop);
                            carFactory1.Enqueue(carWorkShop1);
                            carFactory1.Enqueue(psCarWorkShop1);
                            carFactory1.Enqueue(trCarWorkShop1);
                            carFactory1.Enqueue(ofrCarWorkShop1);
                            Console.WriteLine("Коллекции сформированы!");
                        }
                        catch
                        {
                            Console.WriteLine("Вы не правильно ввели число, попробуйте снова.");
                        }
                        break;
                    case "2":
                        if (carFactory.Count > 0)
                        {
                            int i = 1;
                            foreach (var workshop in carFactory)
                            {
                                Console.WriteLine($"\n\t\t Цех №{i}");
                                foreach (var car in workshop)
                                {
                                    Console.WriteLine(car.ToString());
                                }
                                i++;
                            }
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "3":
                        if (carFactory.Count > 0)
                        {
                            Console.Write("Введите марку которую хотите найти: ");
                            string brand = Console.ReadLine();
                            WhereDemonstrationLINQ(carFactory, brand);
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "4":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tОбщая машина");
                            IntersectDemonstrationLINQ(carFactory, carFactory1);
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "5":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tСамая дорогая машина на заводе");
                            MaxDemonstrationLINQ(carFactory);
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "6":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tГруппировка по марке");
                            GroupByDemonstrationLINQ(carFactory);
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "7":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tАдрес доставки дилеру для каждой марки");
                            JoinDemonstrationLINQ(carFactory);
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "8":
                        if (carFactory.Count > 0)
                        {
                            Console.Write("Введите марку которую хотите найти: ");
                            string brand = Console.ReadLine();
                            WhereDemonstrationExtension(carFactory, brand);
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "9":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tОбщая машина");
                            IntersectDemonstrationExtension(carFactory, carFactory1);
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "10":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tСамая дорогая машина на заводе");
                            MaxDemonstrationExtension(carFactory);
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "11":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tГруппировка по марке");
                            GroupByDemonstrationExtension(carFactory);
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "12":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tАдрес доставки дилеру для каждой марки");
                            JoinDemonstrationExtension(carFactory);
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "13":
                        PrintMenuForPart1();
                        break;
                    case "14":
                        Console.WriteLine();
                        ChoicePart();
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        public static void ChoiceForPart2()
        {
            string choice = null;
            SuperHashTable<Cars> superHashTable = null;

            while (choice != "12")
            {
                Console.Write("Ваш выбор: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        try
                        {
                            Console.Write("Введите количество ячеек: ");
                            int length = int.Parse(Console.ReadLine());
                            superHashTable = new SuperHashTable<Cars>(length);
                            Console.Write("Введите количество элементов, которых хотите создать: ");
                            int countOfElements = int.Parse(Console.ReadLine());
                            for (int i = 0; i < countOfElements; i++)
                            {
                                Cars car = new Cars();
                                car.RandomInit();
                                superHashTable.Add(car);
                            }
                            Console.WriteLine("Хеш-таблица сформирована");
                        }
                        catch
                        {
                            Console.WriteLine("Вы неправильно ввели данные о хеш-таблице.");
                        }
                        break;
                    case "2":
                        if (superHashTable != null)
                        {
                            superHashTable.PrintTable();
                        }
                        else
                        {
                            Console.WriteLine("Сначала сформируйте хеш-таблицу.");
                        }
                        break;
                    case "3":
                        if (superHashTable != null)
                        {
                            Console.Write("Введите марку которую хотите найти: ");
                            string brand = Console.ReadLine();
                            WhereDemonstrationLINQPart2(superHashTable, brand);
                        }
                        else
                        {
                            Console.WriteLine("Сначала сформируйте хеш-таблицу.");
                        }
                        break;
                    case "4":
                        if (superHashTable != null)
                        {
                            CountDemonstrationLINQPart2(superHashTable);
                        }
                        else
                        {
                            Console.WriteLine("Сначала сформируйте хеш-таблицу.");
                        }
                        break;
                    case "5":
                        if (superHashTable != null)
                        {
                            SumDemonstrationLINQPart2(superHashTable);
                        }
                        else
                        {
                            Console.WriteLine("Сначала сформируйте хеш-таблицу.");
                        }
                        break;
                    case "6":
                        if (superHashTable != null)
                        {
                            Console.WriteLine("\t\tГруппировка по марке");
                            GroupByDemonstrationLINQPart2(superHashTable);
                        }
                        else
                        {
                            Console.WriteLine("Сначала сформируйте хеш-таблицу.");
                        }
                        break;
                    case "7":
                        if (superHashTable != null)
                        {
                            Console.Write("Введите марку которую хотите найти: ");
                            string brand = Console.ReadLine();
                            WhereDemonstrationExtensionPart2(superHashTable, brand);
                        }
                        else
                        {
                            Console.WriteLine("Сначала сформируйте хеш-таблицу.");
                        }
                        break;
                    case "8":
                        if (superHashTable != null)
                        {
                            CountDemonstrationExtensionPart2(superHashTable);
                        }
                        else
                        {
                            Console.WriteLine("Сначала сформируйте хеш-таблицу.");
                        }
                        break;
                    case "9":
                        if (superHashTable != null)
                        {
                            SumDemonstrationExtensionPart2(superHashTable);
                        }
                        else
                        {
                            Console.WriteLine("Сначала сформируйте хеш-таблицу.");
                        }
                        break;
                    case "10":
                        if (superHashTable != null)
                        {
                            Console.WriteLine("\t\tГруппировка по марке");
                            GroupByDemonstrationExtensionPart2(superHashTable);
                        }
                        else
                        {
                            Console.WriteLine("Сначала сформируйте хеш-таблицу.");
                        }
                        break;
                    case "11":
                        PrintMenuForPart2();
                        break;
                    case "12":
                        Console.WriteLine();
                        PrintMenu();
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        public static void WhereDemonstrationLINQ(Queue<List<Cars>> carFactory, string brand)
        {
            var result = from workshop in carFactory
                         from car in workshop
                         where car.Brand == brand
                         select car;
            if (result.Count() > 0)
            {
                foreach (var car in result) { Console.WriteLine(car.ToString()); }
            }
            else
            {
                Console.WriteLine("Такой марки нет в цехах");
            }
        }

        public static void WhereDemonstrationLINQPart2(SuperHashTable<Cars> carFactory, string brand)
        {
            var result = from car in carFactory
                         where car.Brand == brand
                         select car;
            if (result.Count() > 0)
            {
                foreach (var car in result) { Console.WriteLine(car.ToString()); }
            }
            else
            {
                Console.WriteLine("Такой марки нет в цехе");
            }
        }

        public static void WhereDemonstrationExtension(Queue<List<Cars>> carFactory, string brand)
        {
            var result = carFactory
                .SelectMany(workshop => workshop)
                .Where(car => car.Brand == brand);
            if (result.Count() > 0)
            {
                foreach (var car in result) { Console.WriteLine(car.ToString()); }
            }
            else
            {
                Console.WriteLine("Такой марки нет в цехах");
            }
        }

        public static void WhereDemonstrationExtensionPart2(SuperHashTable<Cars> carFactory, string brand)
        {
            var result = carFactory.Where(car => car.Brand == brand);
            if (result.Count() > 0)
            {
                foreach (var car in result) { Console.WriteLine(car.ToString()); }
            }
            else
            {
                Console.WriteLine("Такой марки нет в цехах");
            }
        }

        public static void IntersectDemonstrationLINQ(Queue<List<Cars>> carFactory, Queue<List<Cars>> carFactory1)
        {
            IEnumerable<Cars> cars = (from workshops in carFactory
                                      from car in workshops
                                      select car).Intersect(from workshops1 in carFactory1 from car1 in workshops1 select car1);

            foreach (var car in cars)
            { Console.WriteLine(car.ToString()); }
        }

        public static void IntersectDemonstrationExtension(Queue<List<Cars>> carFactory, Queue<List<Cars>> carFactory1)
        {
            var cars = carFactory
           .SelectMany(workshop => workshop)
           .Intersect(carFactory1.SelectMany(workshop => workshop));

            foreach (var car in cars)
            { Console.WriteLine(car.ToString()); }
        }

        public static void MaxDemonstrationLINQ(Queue<List<Cars>> carFactory)
        {
            var exCar = (from workshop in carFactory
                         from car in workshop
                         select car).Max();
            Console.WriteLine($"Самый дорогой автомобиль: {exCar}");
        }

        public static void MaxDemonstrationExtension(Queue<List<Cars>> carFactory)
        {
            var exCar = carFactory.SelectMany(workshop => workshop).Max();
            Console.WriteLine($"Самый дорогой автомобиль: {exCar}");
        }

        public static void GroupByDemonstrationLINQ(Queue<List<Cars>> carFactory)
        {
            var result = from workshop in carFactory
                         from car in workshop
                         group car by car.Brand;
            foreach (var gr in result)
            {
                Console.WriteLine("\t\t" + gr.Key);
                foreach (var car in gr)
                {
                    Console.WriteLine(car.ToString());
                }
            }
        }

        public static void GroupByDemonstrationExtension(Queue<List<Cars>> carFactory)
        {
            var result = carFactory.SelectMany(workshops => workshops).GroupBy(car => car.Brand);
            foreach (var gr in result)
            {
                Console.WriteLine("\t\t" + gr.Key);
                foreach (var car in gr)
                {
                    Console.WriteLine(car.ToString());
                }
            }
        }

        public static void GroupByDemonstrationLINQPart2(SuperHashTable<Cars> carFactory)
        {
            var result = from car in carFactory
                         group car by car.Brand;
            foreach (var gr in result)
            {
                Console.WriteLine("\t\t" + gr.Key);
                foreach (var car in gr)
                {
                    Console.WriteLine(car.ToString());
                }
            }
        }

        public static void GroupByDemonstrationExtensionPart2(SuperHashTable<Cars> carFactory)
        {
            var result = carFactory.GroupBy(car => car.Brand);
            foreach (var gr in result)
            {
                Console.WriteLine("\t\t" + gr.Key);
                foreach (var car in gr)
                {
                    Console.WriteLine(car.ToString());
                }
            }
        }

        public static void JoinDemonstrationLINQ(Queue<List<Cars>> carFactory)
        {
            List<Customer> orders = new List<Customer>
            {
                new Customer("Москва", "Улица им.Пушкина 52", "Ford"),
                new Customer("Санкт-Петербург", "Улица им.Ленина 37", "BMW"),
                new Customer("Нижний Новгород", "Улица Пролетарская 22", "Chevrolet"),
                new Customer("Пермь", "Улица Старцева", "Honda"),
                new Customer("Казань", "Улица Баумана 15", "Toyota"),
                new Customer("Новосибирск", "Улица Ленина 5", "Mercedes"),
                new Customer("Екатеринбург", "Улица Малышева 14", "Volkswagen"),
                new Customer("Воронеж", "Улица Коминтерна 20", "Audi"),
                new Customer("Самара", "Улица Куйбышева 8", "Nissan"),
                new Customer("Уфа", "Улица Октября 17", "Hyundai")
            };

            var result = (from workshop in carFactory
                          from car in workshop
                          join t in orders on car.Brand equals t.Brand
                          select new { car.Brand, Address = t.City + " " + t.Address }).Distinct();
            foreach (var gr in result)
            {
                Console.WriteLine(gr.ToString());
            }
        }

        public static void JoinDemonstrationExtension(Queue<List<Cars>> carFactory)
        {
            List<Customer> orders = new List<Customer>
            {
                new Customer("Москва", "Улица им.Пушкина 52", "Ford"),
                new Customer("Санкт-Петербург", "Улица им.Ленина 37", "BMW"),
                new Customer("Нижний Новгород", "Улица Пролетарская 22", "Chevrolet"),
                new Customer("Пермь", "Улица Старцева", "Honda"),
                new Customer("Казань", "Улица Баумана 15", "Toyota"),
                new Customer("Новосибирск", "Улица Ленина 5", "Mercedes"),
                new Customer("Екатеринбург", "Улица Малышева 14", "Volkswagen"),
                new Customer("Воронеж", "Улица Коминтерна 20", "Audi"),
                new Customer("Самара", "Улица Куйбышева 8", "Nissan"),
                new Customer("Уфа", "Улица Октября 17", "Hyundai")
            };

            var result = carFactory
                        .SelectMany(workshop => workshop)
                        .Join(orders, car => car.Brand, order => order.Brand,
                        (car, order) => new { car.Brand, Address = order.City + " " + order.Address })
                        .Distinct();
            foreach (var gr in result)
            {
                Console.WriteLine(gr.ToString());
            }
        }

        public static void CountDemonstrationLINQPart2(SuperHashTable<Cars> carFactory)
        {
            var result = (from car in carFactory
                          where car.Color == "Yellow"
                          select car).Count();
            if (result > 0)
            {
                Console.WriteLine($"Количество желтых автомобилей: {result}");
            }
            else
            {
                Console.WriteLine("В цеху нет желтых автомобилей");
            }
        }

        public static void CountDemonstrationExtensionPart2(SuperHashTable<Cars> carFactory)
        {
            var result = carFactory
                        .Where(car => car.Color == "Yellow")
                        .Count();
            if (result > 0)
            {
                Console.WriteLine($"Количество желтых автомобилей: {result}");
            }
            else
            {
                Console.WriteLine("В цеху нет желтых автомобилей");
            }
        }

        public static void SumDemonstrationLINQPart2(SuperHashTable<Cars> carFactory)
        {
            var result = (from car in carFactory
                          select car.Cost).Sum();
            if (result > 0)
            {
                Console.WriteLine($"Сумма стоимостей всех автомобилей: {result}");
            }
            else
            {
                Console.WriteLine("Стоимость равна 0");
            }
        }

        public static void SumDemonstrationExtensionPart2(SuperHashTable<Cars> carFactory)
        {
            var result = carFactory.Sum(car => car.Cost);
            if (result > 0)
            {
                Console.WriteLine($"Сумма стоимостей всех автомобилей: {result}");
            }
            else
            {
                Console.WriteLine("Стоимость равна 0");
            }
        }
    }
}
