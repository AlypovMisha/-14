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
            Console.WriteLine("5. Найти автомобиль/и с максимальной ценой (демонстрация Max LINQ)");
            Console.WriteLine("6. Сгруппировать по марке (демонстрация Group By LINQ)");
            Console.WriteLine("7. Адрес доставки автомобилей (демонстрация Join LINQ)");
            Console.WriteLine("8. Вывести на экран машины определенного бренда (демонстрация Where методом расширения)");
            Console.WriteLine("9. Найти одинаковые машины (демонстрация Intersect методом расширения)");
            Console.WriteLine("10. Найти автомобиль/и с максимальной ценой (демонстрация Max методом расширения)");
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
            Console.WriteLine("6. Сгруппировать по марке (демонстрация Group By LINQ)");
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
                        ProcessInputAndGenerateCars(carFactory, carFactory1);
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
                            var result = WhereDemonstrationLINQ(carFactory, brand);
                            if (result.Count() > 0)
                            {
                                foreach (var car in result) { Console.WriteLine(car.ToString()); }
                            }
                            else
                            {
                                Console.WriteLine("Такой марки нет в цехах");
                            }
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "4":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tОбщая машина");
                            var cars = IntersectDemonstrationLINQ(carFactory, carFactory1);
                            foreach (var car in cars)
                            { Console.WriteLine(car.ToString()); }
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "5":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tСамая(ые) дорогая(ие) машина(ы) на заводе");
                            var exCar = MaxDemonstrationLINQ(carFactory);
                            foreach (var car in exCar)
                                Console.WriteLine($"Самый дорогой автомобиль: {car.ToString()}");
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "6":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tГруппировка по марке");
                            var result = GroupByDemonstrationLINQ(carFactory);
                            foreach (var gr in result)
                            {
                                int i = 0;
                                Console.WriteLine("\t\t" + gr.Key);
                                foreach (var car in gr)
                                {
                                    i++;
                                    Console.WriteLine(car.ToString());
                                }
                                Console.WriteLine($"Количество машин с маркой {gr.Key} в данной группе {i}");
                            }
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "7":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tАдрес доставки дилеру для каждой марки");
                            var result = JoinDemonstrationLINQ(carFactory);
                            foreach (var gr in result)
                            {
                                Console.WriteLine(gr.ToString());
                            }
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "8":
                        if (carFactory.Count > 0)
                        {
                            Console.Write("Введите марку которую хотите найти: ");
                            string brand = Console.ReadLine();
                            var result = WhereDemonstrationExtension(carFactory, brand);
                            if (result.Count() > 0)
                            {
                                foreach (var car in result) { Console.WriteLine(car.ToString()); }
                            }
                            else
                            {
                                Console.WriteLine("Такой марки нет в цехах");
                            }
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "9":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tОбщая машина");
                            var cars = IntersectDemonstrationExtension(carFactory, carFactory1);
                            foreach (var car in cars)
                            { Console.WriteLine(car.ToString()); }
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "10":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tСамая(ые) дорогая(ие) машина(ы) на заводе");
                            var exCar = MaxDemonstrationExtension(carFactory);
                            foreach (var car in exCar)
                                Console.WriteLine($"Самый дорогой автомобиль: {car.ToString()}");
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "11":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tГруппировка по марке");
                            var result = GroupByDemonstrationExtension(carFactory);
                            foreach (var gr in result)
                            {
                                int i = 0;
                                Console.WriteLine("\t\t" + gr.Key);
                                foreach (var car in gr)
                                {
                                    i++;
                                    Console.WriteLine(car.ToString());
                                }
                                Console.WriteLine($"Количество машин с маркой {gr.Key} в данной группе {i}");
                            }
                        }
                        else
                            Console.WriteLine("Сначала сформируйте коллекции");
                        break;
                    case "12":
                        if (carFactory.Count > 0)
                        {
                            Console.WriteLine("\t\tАдрес доставки дилеру для каждой марки");
                            var result = JoinDemonstrationExtension(carFactory);
                            foreach (var gr in result)
                            {
                                Console.WriteLine(gr.ToString());
                            }
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
                            var result = WhereDemonstrationLINQPart2(superHashTable, brand);
                            if (result.Count() > 0)
                            {
                                foreach (var car in result) { Console.WriteLine(car.ToString()); }
                            }
                            else
                            {
                                Console.WriteLine("Такой марки нет в цехе");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Сначала сформируйте хеш-таблицу.");
                        }
                        break;
                    case "4":
                        if (superHashTable != null)
                        {
                            var result = CountDemonstrationLINQPart2(superHashTable);
                            if (result > 0)
                            {
                                Console.WriteLine($"Количество желтых автомобилей: {result}");
                            }
                            else
                            {
                                Console.WriteLine("В цеху нет желтых автомобилей");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Сначала сформируйте хеш-таблицу.");
                        }
                        break;
                    case "5":
                        if (superHashTable != null)
                        {
                            var result = SumDemonstrationLINQPart2(superHashTable);
                            if (result > 0)
                            {
                                Console.WriteLine($"Сумма стоимостей всех автомобилей: {result}");
                            }
                            else
                            {
                                Console.WriteLine("Стоимость равна 0");
                            }
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
                            var result = GroupByDemonstrationLINQPart2(superHashTable);
                            foreach (var gr in result)
                            {
                                int i = 0;
                                Console.WriteLine("\t\t" + gr.Key);
                                foreach (var car in gr)
                                {
                                    i++;
                                    Console.WriteLine(car.ToString());
                                }
                                Console.WriteLine($"Количество машин с маркой {gr.Key} в данной группе {i}");
                            }
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
                            var result = WhereDemonstrationExtensionPart2(superHashTable, brand);
                            if (result.Count() > 0)
                            {
                                foreach (var car in result) { Console.WriteLine(car.ToString()); }
                            }
                            else
                            {
                                Console.WriteLine("Такой марки нет в цехах");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Сначала сформируйте хеш-таблицу.");
                        }
                        break;
                    case "8":
                        if (superHashTable != null)
                        {
                            var result = CountDemonstrationExtensionPart2(superHashTable);
                            if (result > 0)
                            {
                                Console.WriteLine($"Количество желтых автомобилей: {result}");
                            }
                            else
                            {
                                Console.WriteLine("В цеху нет желтых автомобилей");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Сначала сформируйте хеш-таблицу.");
                        }
                        break;
                    case "9":
                        if (superHashTable != null)
                        {
                            var result = SumDemonstrationExtensionPart2(superHashTable);
                            if (result > 0)
                            {
                                Console.WriteLine($"Сумма стоимостей всех автомобилей: {result}");
                            }
                            else
                            {
                                Console.WriteLine("Стоимость равна 0");
                            }
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
                            var result = GroupByDemonstrationExtensionPart2(superHashTable);
                            foreach (var gr in result)
                            {
                                int i = 0;
                                Console.WriteLine("\t\t" + gr.Key);
                                foreach (var car in gr)
                                {
                                    i++;
                                    Console.WriteLine(car.ToString());
                                }
                                Console.WriteLine($"Количество машин с маркой {gr.Key} в данной группе {i}");
                            }
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

        public static IEnumerable<Cars> WhereDemonstrationLINQ(Queue<List<Cars>> carFactory, string brand)
        {
            var result = from workshop in carFactory
                         from car in workshop
                         where car.Brand == brand
                         select car;
            return result;
        }

        public static IEnumerable<Cars> WhereDemonstrationLINQPart2(SuperHashTable<Cars> carFactory, string brand)
        {
            var result = from car in carFactory
                         where car.Brand == brand
                         select car;
            return result;
        }

        public static IEnumerable<Cars> WhereDemonstrationExtension(Queue<List<Cars>> carFactory, string brand)
        {
            var result = carFactory
                .SelectMany(workshop => workshop)
                .Where(car => car.Brand == brand);
            return result;
        }

        public static IEnumerable<Cars> WhereDemonstrationExtensionPart2(SuperHashTable<Cars> carFactory, string brand)
        {
            var result = carFactory.Where(car => car.Brand == brand);
            return result;
        }

        public static IEnumerable<Cars> IntersectDemonstrationLINQ(Queue<List<Cars>> carFactory, Queue<List<Cars>> carFactory1)
        {
            IEnumerable<Cars> cars = (from workshops in carFactory
                                      from car in workshops
                                      select car).Intersect(from workshops1 in carFactory1 from car1 in workshops1 select car1);

            return cars;
        }

        public static IEnumerable<Cars> IntersectDemonstrationExtension(Queue<List<Cars>> carFactory, Queue<List<Cars>> carFactory1)
        {
            var cars = carFactory
           .SelectMany(workshop => workshop)
           .Intersect(carFactory1.SelectMany(workshop => workshop));

            return cars;
        }

        public static IEnumerable<Cars> MaxDemonstrationLINQ(Queue<List<Cars>> carFactory)
        {
            var maxCost = (from workshop in carFactory
                           from car in workshop
                           select car.Cost).Max();
            var exCar = (from workshop in carFactory
                         from car in workshop
                         where car.Cost == maxCost
                         select car);
            return exCar;
        }

        public static IEnumerable<Cars> MaxDemonstrationExtension(Queue<List<Cars>> carFactory)
        {
            var maxCost = carFactory
                .SelectMany(workshop => workshop)
                .Max(car => car.Cost);

            var exCars = carFactory
                .SelectMany(workshop => workshop)
                .Where(car => car.Cost == maxCost);
            return exCars;
        }

        public static IEnumerable<IGrouping<string, Cars>> GroupByDemonstrationLINQ(Queue<List<Cars>> carFactory)
        {
            var result = from workshop in carFactory
                         from car in workshop
                         group car by car.Brand;

            return result;
        }

        public static IEnumerable<IGrouping<string, Cars>> GroupByDemonstrationExtension(Queue<List<Cars>> carFactory)
        {
            var result = carFactory.SelectMany(workshops => workshops).GroupBy(car => car.Brand);
            return result;
        }

        public static IEnumerable<IGrouping<string, Cars>> GroupByDemonstrationLINQPart2(SuperHashTable<Cars> carFactory)
        {
            var result = from car in carFactory
                         group car by car.Brand;
            return result;
        }

        public static IEnumerable<IGrouping<string, Cars>> GroupByDemonstrationExtensionPart2(SuperHashTable<Cars> carFactory)
        {
            var result = carFactory.GroupBy(car => car.Brand);
            return result;
        }

        public static IEnumerable<CarWithAddress> JoinDemonstrationLINQ(Queue<List<Cars>> carFactory)
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
                          select new CarWithAddress { Brand = car.Brand, Address = t.City + " " + t.Address }).Distinct();
            return result;
        }

        public static IEnumerable<CarWithAddress> JoinDemonstrationExtension(Queue<List<Cars>> carFactory)
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
                        (car, order) => new CarWithAddress { Brand = car.Brand, Address = order.City + " " + order.Address })
                        .Distinct();
            return result;
        }

        public static int CountDemonstrationLINQPart2(SuperHashTable<Cars> carFactory)
        {
            var result = (from car in carFactory
                          where car.Color == "Yellow"
                          select car).Count();
            return result;
        }

        public static int CountDemonstrationExtensionPart2(SuperHashTable<Cars> carFactory)
        {
            var result = carFactory
                        .Where(car => car.Color == "Yellow")
                        .Count();
            return result;

        }

        public static int SumDemonstrationLINQPart2(SuperHashTable<Cars> carFactory)
        {
            var result = (from car in carFactory
                          select car.Cost).Sum();
            return result;

        }

        public static int SumDemonstrationExtensionPart2(SuperHashTable<Cars> carFactory)
        {
            var result = carFactory.Sum(car => car.Cost);
            return result;
        }


        private static void ProcessInputAndGenerateCars(Queue<List<Cars>> carFactory, Queue<List<Cars>> carFactory1)
        {
            try
            {
                Console.Write("Введите количество автомобилей в цехах: ");
                carFactory.Clear();
                carFactory1.Clear();

                int countOfAuto = int.Parse(Console.ReadLine());

                var workshops = GenerateWorkshops(countOfAuto);
                var workshops1 = GenerateWorkshops(countOfAuto);

                // Добавляется автомобиль для метода Intersect
                var specialCar = new Cars();
                specialCar.RandomInit();
                AddSpecialCarToWorkshops(workshops, specialCar);
                AddSpecialCarToWorkshops(workshops1, specialCar);

                EnqueueWorkshops(carFactory, workshops);
                EnqueueWorkshops(carFactory1, workshops1);

                Console.WriteLine("Коллекции сформированы!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        private static List<List<Cars>> GenerateWorkshops(int countOfAuto)
        {
            var carWorkShop = new List<Cars>(countOfAuto);
            var psCarWorkShop = new List<Cars>(countOfAuto);
            var trCarWorkShop = new List<Cars>(countOfAuto);
            var ofrCarWorkShop = new List<Cars>(countOfAuto);

            for (int i = 0; i < countOfAuto; i++)
            {
                carWorkShop.Add(CreateRandomCar<Cars>());
                psCarWorkShop.Add(CreateRandomCar<PassengerCar>());
                trCarWorkShop.Add(CreateRandomCar<TruckCar>());
                ofrCarWorkShop.Add(CreateRandomCar<OffRoadCar>());
            }

            return new List<List<Cars>> { carWorkShop, psCarWorkShop, trCarWorkShop, ofrCarWorkShop };
        }

        private static T CreateRandomCar<T>() where T : Cars, new()
        {
            var car = new T();
            car.RandomInit();
            return car;
        }

        private static void AddSpecialCarToWorkshops(List<List<Cars>> workshops, Cars specialCar)
        {
            foreach (var workshop in workshops)
            {
                workshop.Add(specialCar);
            }
        }

        private static void EnqueueWorkshops(Queue<List<Cars>> carFactory, List<List<Cars>> workshops)
        {
            foreach (var workshop in workshops)
            {
                carFactory.Enqueue(workshop);
            }
        }
    }
}

