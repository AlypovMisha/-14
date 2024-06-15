using _10LabDll;
using _12LabLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Лабораторная_14;

namespace Laba14Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void WhereDemonstrationLINQ_FindsCarsByBrand()
        {
            var carFactory = new Queue<List<Cars>>();
            var carsList = new List<Cars>
            {
                new Cars { Brand = "Toyota" },
                new Cars { Brand = "BMW" },
                new Cars { Brand = "Ford" }
            };
            carFactory.Enqueue(carsList);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.WhereDemonstrationLINQ(carFactory, "Toyota");
                var result = sw.ToString().Trim();
                var expected = "Toyota, 2020, White, 100000, 15, 0";
                Assert.AreEqual(expected, result);
            }
        }
        [TestMethod]
        public void WhereDemonstrationLINQ_FindsCarsByBrand_1()
        {
            var carFactory = new Queue<List<Cars>>();
            var carsList = new List<Cars>
            {
                new Cars { Brand = "Toyota" },
                new Cars { Brand = "BMW" },
                new Cars { Brand = "Ford" }
            };
            carFactory.Enqueue(carsList);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.WhereDemonstrationLINQ(carFactory, "Honda");
                var result = sw.ToString().Trim();
                var expected = "Такой марки нет в цехах";
                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public void WhereDemonstrationLINQPart2_FindsCarsByBrand()
        {
            var carFactory = new SuperHashTable<Cars>
            {
                new Cars { Brand = "Toyota" },
                new Cars { Brand = "BMW" },
                new Cars { Brand = "Ford" }
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.WhereDemonstrationLINQPart2(carFactory, "Toyota");
                var result = sw.ToString().Trim();
                var expected = "Toyota, 2020, White, 100000, 15, 0";
                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public void WhereDemonstrationLINQPart2_FindsCarsByBrand_1()
        {
            var carFactory = new SuperHashTable<Cars>
            {
                new Cars { Brand = "Toyota" },
                new Cars { Brand = "BMW" },
                new Cars { Brand = "Ford" }
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.WhereDemonstrationLINQPart2(carFactory, "Honda");
                var result = sw.ToString().Trim();
                var expected = "Такой марки нет в цехе";
                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public void WhereDemonstrationExtension_FindsCarsByBrand()
        {
            var carFactory = new Queue<List<Cars>>();
            var carsList = new List<Cars>
            {
                new Cars { Brand = "Toyota" },
                new Cars { Brand = "BMW" },
                new Cars { Brand = "Ford" }
            };
            carFactory.Enqueue(carsList);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.WhereDemonstrationExtension(carFactory, "Toyota");
                var result = sw.ToString().Trim();
                var expected = "Toyota, 2020, White, 100000, 15, 0";
                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public void WhereDemonstrationExtension_FindsCarsByBrand_1()
        {
            var carFactory = new Queue<List<Cars>>();
            var carsList = new List<Cars>
            {
                new Cars { Brand = "Toyota" },
                new Cars { Brand = "BMW" },
                new Cars { Brand = "Ford" }
            };
            carFactory.Enqueue(carsList);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.WhereDemonstrationExtension(carFactory, "Honda");
                var result = sw.ToString().Trim();
                var expected = "Такой марки нет в цехах";
                Assert.AreEqual(expected, result);
            }
        }
        [TestMethod]
        public void WhereDemonstrationExtensionPart2_FindsCarsByBrand()
        {
            var carFactory = new SuperHashTable<Cars>
            {
                new Cars { Brand = "Toyota" },
                new Cars { Brand = "BMW" },
                new Cars { Brand = "Ford" }
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.WhereDemonstrationExtensionPart2(carFactory, "Toyota");
                var result = sw.ToString().Trim();
                var expected = "Toyota, 2020, White, 100000, 15, 0";
                Assert.AreEqual(expected, result);
            }
        }
        [TestMethod]
        public void WhereDemonstrationExtensionPart2_FindsCarsByBrand_1()
        {
            var carFactory = new SuperHashTable<Cars>
            {
                new Cars { Brand = "Toyota" },
                new Cars { Brand = "BMW" },
                new Cars { Brand = "Ford" }
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.WhereDemonstrationExtensionPart2(carFactory, "Honda");
                var result = sw.ToString().Trim();
                var expected = "Такой марки нет в цехах";
                Assert.AreEqual(expected, result);
            }
        }
        [TestMethod]
        public void MaxDemonstrationLINQ_FindsMaxCostCar()
        {
            var carFactory = new Queue<List<Cars>>();
            var carsList = new List<Cars>
            {
                new Cars { Brand = "Toyota", Cost = 20000 },
                new Cars { Brand = "BMW", Cost = 30000 },
                new Cars { Brand = "Toyota", Cost = 25000 }
            };
            carFactory.Enqueue(carsList);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.MaxDemonstrationLINQ(carFactory);
                var result = sw.ToString().Trim();
                var expected = "Самый дорогой автомобиль: BMW, 2020, White, 30000, 15, 0"; // Замените на правильный вывод вашего объекта Cars
                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public void MaxDemonstrationExtension_FindsMaxCostCar()
        {
            var carFactory = new Queue<List<Cars>>();
            var carsList = new List<Cars>
            {
                new Cars { Brand = "Toyota", Cost = 20000 },
                new Cars { Brand = "BMW", Cost = 30000 },
                new Cars { Brand = "Toyota", Cost = 25000 }
            };
            carFactory.Enqueue(carsList);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.MaxDemonstrationExtension(carFactory);
                var result = sw.ToString().Trim();
                var expected = "Самый дорогой автомобиль: BMW, 2020, White, 30000, 15, 0";
                Assert.AreEqual(expected, result);
            }
        }



        [TestMethod]
        public void CountDemonstrationLINQPart2_CountsYellowCars()
        {
            var carFactory = new SuperHashTable<Cars>
            {
                new Cars { Brand = "Ford", Color = "Yellow" },
                new Cars { Brand = "Honda", Color = "Blue" },
                new Cars { Brand = "Nissan", Color = "Yellow" }
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.CountDemonstrationLINQPart2(carFactory);
                var result = sw.ToString().Trim();
                var expected = "Количество желтых автомобилей: 2";
                Assert.AreEqual(expected, result);
            }
        }
        [TestMethod]
        public void CountDemonstrationLINQPart2_CountsYellowCars_1()
        {
            var carFactory = new SuperHashTable<Cars>
            {
                new Cars { Brand = "Ford", Color = "Red" },
                new Cars { Brand = "Honda", Color = "Blue" },
                new Cars { Brand = "Nissan", Color = "Black" }
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.CountDemonstrationLINQPart2(carFactory);
                var result = sw.ToString().Trim();
                var expected = "В цеху нет желтых автомобилей";
                Assert.AreEqual(expected, result);
            }
        }
        [TestMethod]
        public void CountDemonstrationExtensionPart2_CountsYellowCars()
        {
            var carFactory = new SuperHashTable<Cars>
            {
                new Cars { Brand = "Ford", Color = "Yellow" },
                new Cars { Brand = "Honda", Color = "Blue" },
                new Cars { Brand = "Nissan", Color = "Yellow" }
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.CountDemonstrationExtensionPart2(carFactory);
                var result = sw.ToString().Trim();
                var expected = "Количество желтых автомобилей: 2";
                Assert.AreEqual(expected, result);
            }
        }
        [TestMethod]
        public void CountDemonstrationExtensionPart2_CountsYellowCars_1()
        {
            var carFactory = new SuperHashTable<Cars>
            {
                new Cars { Brand = "Ford", Color = "Red" },
                new Cars { Brand = "Honda", Color = "Blue" },
                new Cars { Brand = "Nissan", Color = "Black" }
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.CountDemonstrationExtensionPart2(carFactory);
                var result = sw.ToString().Trim();
                var expected = "В цеху нет желтых автомобилей";
                Assert.AreEqual(expected, result);
            }
        }
        [TestMethod]
        public void SumDemonstrationLINQPart2_SumsCarCosts()
        {
            var carFactory = new SuperHashTable<Cars>
            {
                new Cars { Cost = 20000 },
                new Cars { Cost = 30000 },
                new Cars { Cost = 25000 }
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.SumDemonstrationLINQPart2(carFactory);
                var result = sw.ToString().Trim();
                var expected = "Сумма стоимостей всех автомобилей: 75000";
                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public void SumDemonstrationExtensionPart2_SumsCarCosts()
        {
            var carFactory = new SuperHashTable<Cars>
            {
                new Cars { Cost = 20000 },
                new Cars { Cost = 30000 },
                new Cars { Cost = 25000 }
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.SumDemonstrationExtensionPart2(carFactory);
                var result = sw.ToString().Trim();
                var expected = "Сумма стоимостей всех автомобилей: 75000";
                Assert.AreEqual(expected, result);
            }
        }

        [TestClass]
        public class CustomerTests
        {
            [TestMethod]
            public void Constructor_SetsPropertiesCorrectly()
            {
                // Arrange
                string expectedCity = "Москва";
                string expectedAddress = "Улица им.Пушкина 52";
                string expectedBrand = "Ford";

                // Act
                Customer customer = new Customer(expectedCity, expectedAddress, expectedBrand);

                // Assert
                Assert.AreEqual(expectedCity, customer.City);
                Assert.AreEqual(expectedAddress, customer.Address);
                Assert.AreEqual(expectedBrand, customer.Brand);
            }

            [TestMethod]
            public void City_GetterReturnsCorrectValue()
            {
                // Arrange
                string expectedCity = "Москва";
                Customer customer = new Customer(expectedCity, "Улица им.Пушкина 52", "Ford");

                // Act
                string actualCity = customer.City;

                // Assert
                Assert.AreEqual(expectedCity, actualCity);
            }

            [TestMethod]
            public void Address_GetterReturnsCorrectValue()
            {
                // Arrange
                string expectedAddress = "Улица им.Пушкина 52";
                Customer customer = new Customer("Москва", expectedAddress, "Ford");

                // Act
                string actualAddress = customer.Address;

                // Assert
                Assert.AreEqual(expectedAddress, actualAddress);
            }

            [TestMethod]
            public void Brand_GetterReturnsCorrectValue()
            {
                // Arrange
                string expectedBrand = "Ford";
                Customer customer = new Customer("Москва", "Улица им.Пушкина 52", expectedBrand);

                // Act
                string actualBrand = customer.Brand;

                // Assert
                Assert.AreEqual(expectedBrand, actualBrand);
            }

            [TestMethod]
            public void WhereDemonstrationLINQ_ShouldReturnCorrectCars()
            {
                // Arrange
                var carFactory = new Queue<List<Cars>>();
                carFactory.Enqueue(new List<Cars>
            {
                new Cars("Toyota", 2020, "Red", 50000, 15.0, 1),
                new Cars("Ford", 2019, "Blue", 45000, 16.0, 2)
            });
                string brand = "Toyota";

                // Act
                var result = from workshop in carFactory
                             from car in workshop
                             where car.Brand == brand
                             select car;

                // Assert
                Assert.AreEqual(1, result.Count());
                Assert.AreEqual("Toyota", result.First().Brand);
            }

            [TestMethod]
            public void WhereDemonstrationExtension_ShouldReturnCorrectCars()
            {
                // Arrange
                var carFactory = new Queue<List<Cars>>();
                carFactory.Enqueue(new List<Cars>
            {
                new Cars("Toyota", 2020, "Red", 50000, 15.0, 1),
                new Cars("Ford", 2019, "Blue", 45000, 16.0, 2)
            });
                string brand = "Toyota";

                // Act
                var result = carFactory
                    .SelectMany(workshop => workshop)
                    .Where(car => car.Brand == brand);

                // Assert
                Assert.AreEqual(1, result.Count());
                Assert.AreEqual("Toyota", result.First().Brand);
            }

            [TestMethod]
            public void IntersectDemonstrationLINQ_ShouldReturnCorrectCars()
            {
                // Arrange
                var carFactory1 = new Queue<List<Cars>>();
                carFactory1.Enqueue(new List<Cars>
            {
                new Cars("Toyota", 2020, "Red", 50000, 15.0, 1),
                new Cars("Ford", 2019, "Blue", 45000, 16.0, 2)
            });

                var carFactory2 = new Queue<List<Cars>>();
                carFactory2.Enqueue(new List<Cars>
            {
                new Cars("Ford", 2019, "Blue", 45000, 16.0, 2),
                new Cars("Honda", 2018, "Green", 40000, 17.0, 3)
            });

                // Act
                var cars = (from workshop1 in carFactory1
                            from car1 in workshop1
                            select car1).Intersect(from workshop2 in carFactory2
                                                   from car2 in workshop2
                                                   select car2);

                // Assert
                Assert.AreEqual(1, cars.Count());
                Assert.AreEqual("Ford", cars.First().Brand);
            }

            [TestMethod]
            public void IntersectDemonstrationExtension_ShouldReturnCorrectCars()
            {
                // Arrange
                var carFactory1 = new Queue<List<Cars>>();
                carFactory1.Enqueue(new List<Cars>
            {
                new Cars("Toyota", 2020, "Red", 50000, 15.0, 1),
                new Cars("Ford", 2019, "Blue", 45000, 16.0, 2)
            });

                var carFactory2 = new Queue<List<Cars>>();
                carFactory2.Enqueue(new List<Cars>
            {
                new Cars("Ford", 2019, "Blue", 45000, 16.0, 2),
                new Cars("Honda", 2018, "Green", 40000, 17.0, 3)
            });

                // Act
                var cars = carFactory1
                    .SelectMany(workshop => workshop)
                    .Intersect(carFactory2.SelectMany(workshop => workshop));

                // Assert
                Assert.AreEqual(1, cars.Count());
                Assert.AreEqual("Ford", cars.First().Brand);
            }

            [TestMethod]
            public void MaxDemonstrationLINQ_ShouldReturnMaxCostCar()
            {
                // Arrange
                var carFactory = new Queue<List<Cars>>();
                carFactory.Enqueue(new List<Cars>
            {
                new Cars("Toyota", 2020, "Red", 50000, 15.0, 1),
                new Cars("Ford", 2019, "Blue", 45000, 16.0, 2)
            });

                // Act
                var exCar = (from workshop in carFactory
                             from car in workshop
                             select car).Max();

                // Assert
                Assert.AreEqual(50000, exCar.Cost);
            }

            [TestMethod]
            public void MaxDemonstrationExtension_ShouldReturnMaxCostCar()
            {
                // Arrange
                var carFactory = new Queue<List<Cars>>();
                carFactory.Enqueue(new List<Cars>
            {
                new Cars("Toyota", 2020, "Red", 50000, 15.0, 1),
                new Cars("Ford", 2019, "Blue", 45000, 16.0, 2)
            });

                // Act
                var exCar = carFactory.SelectMany(workshop => workshop).Max();

                // Assert
                Assert.AreEqual(50000, exCar.Cost);
            }

            [TestMethod]
            public void GroupByDemonstrationLINQ_ShouldGroupByBrand()
            {
                // Arrange
                var carFactory = new Queue<List<Cars>>();
                carFactory.Enqueue(new List<Cars>
            {
                new Cars("Toyota", 2020, "Red", 50000, 15.0, 1),
                new Cars("Ford", 2019, "Blue", 45000, 16.0, 2),
                new Cars("Toyota", 2021, "White", 55000, 17.0, 3)
            });

                // Act
                var result = from workshop in carFactory
                             from car in workshop
                             group car by car.Brand;

                // Assert
                Assert.AreEqual(2, result.Count());
                Assert.IsTrue(result.Any(g => g.Key == "Toyota"));
                Assert.IsTrue(result.Any(g => g.Key == "Ford"));
            }

            [TestMethod]
            public void GroupByDemonstrationExtension_ShouldGroupByBrand()
            {
                // Arrange
                var carFactory = new Queue<List<Cars>>();
                carFactory.Enqueue(new List<Cars>
            {
                new Cars("Toyota", 2020, "Red", 50000, 15.0, 1),
                new Cars("Ford", 2019, "Blue", 45000, 16.0, 2),
                new Cars("Toyota", 2021, "White", 55000, 17.0, 3)
            });

                // Act
                var result = carFactory.SelectMany(workshop => workshop).GroupBy(car => car.Brand);

                // Assert
                Assert.AreEqual(2, result.Count());
                Assert.IsTrue(result.Any(g => g.Key == "Toyota"));
                Assert.IsTrue(result.Any(g => g.Key == "Ford"));
            }

            [TestMethod]
            public void JoinDemonstrationLINQ_ShouldJoinWithCustomers()
            {
                // Arrange
                var carFactory = new Queue<List<Cars>>();
                carFactory.Enqueue(new List<Cars>
            {
                new Cars("Toyota", 2020, "Red", 50000, 15.0, 1),
                new Cars("Ford", 2019, "Blue", 45000, 16.0, 2)
            });
                List<Customer> orders = new List<Customer>
            {
                new Customer("Москва", "Улица им.Пушкина 52", "Ford"),
                new Customer("Санкт-Петербург", "Улица им.Ленина 37", "BMW")
            };

                // Act
                var result = (from workshop in carFactory
                              from car in workshop
                              join t in orders on car.Brand equals t.Brand
                              select new { car.Brand, Address = t.City + " " + t.Address }).Distinct();

                // Assert
                Assert.AreEqual(1, result.Count());
                Assert.AreEqual("Ford", result.First().Brand);
            }

            [TestMethod]
            public void JoinDemonstrationExtension_ShouldJoinWithCustomers()
            {
                // Arrange
                var carFactory = new Queue<List<Cars>>();
                carFactory.Enqueue(new List<Cars>
            {
                new Cars("Toyota", 2020, "Red", 50000, 15.0, 1),
                new Cars("Ford", 2019, "Blue", 45000, 16.0, 2)
            });
                List<Customer> orders = new List<Customer>
            {
                new Customer("Москва", "Улица им.Пушкина 52", "Ford"),
                new Customer("Санкт-Петербург", "Улица им.Ленина 37", "BMW")
            };

                // Act
                var result = carFactory
                            .SelectMany(workshop => workshop)
                            .Join(orders, car => car.Brand, order => order.Brand,
                                (car, order) => new { car.Brand, Address = order.City + " " + order.Address })
                            .Distinct();

                // Assert
                Assert.AreEqual(1, result.Count());
                Assert.AreEqual("Ford", result.First().Brand);
            }

            [TestMethod]
            public void IntersectDemonstrationLINQ_ShouldIntersectCorrectly()
            {
                // Arrange
                var carFactory = new Queue<List<Cars>>();
                carFactory.Enqueue(new List<Cars>
            {
                new Cars("Toyota", 2020, "Red", 50000, 15, 1),
                new Cars("Ford", 2019, "Blue", 45000, 16, 2)
            });

                var carFactory1 = new Queue<List<Cars>>();
                carFactory1.Enqueue(new List<Cars>
            {
                new Cars("Ford", 2019, "Blue", 45000, 16, 2),
                new Cars("Honda", 2018, "Green", 40000, 17, 3)
            });

                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    // Act
                    Program.IntersectDemonstrationLINQ(carFactory, carFactory1);

                    // Assert
                    var expected = "Ford, 2019, Blue, 45000, 16, 2\r\n";
                    Assert.AreEqual(expected, sw.ToString());
                }
            }

            [TestMethod]
            public void IntersectDemonstrationExtension_ShouldIntersectCorrectly()
            {
                // Arrange
                var carFactory = new Queue<List<Cars>>();
                carFactory.Enqueue(new List<Cars>
            {
                new Cars("Toyota", 2020, "Red", 50000, 15, 1),
                new Cars("Ford", 2019, "Blue", 45000, 16, 2)
            });

                var carFactory1 = new Queue<List<Cars>>();
                carFactory1.Enqueue(new List<Cars>
            {
                new Cars("Ford", 2019, "Blue", 45000, 16, 2),
                new Cars("Honda", 2018, "Green", 40000, 17, 3)
            });

                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    // Act
                    Program.IntersectDemonstrationExtension(carFactory, carFactory1);

                    // Assert
                    var expected = "Ford, 2019, Blue, 45000, 16, 2\r\n";
                    Assert.AreEqual(expected, sw.ToString());
                }
            }

            [TestMethod]
            public void GroupByDemonstrationLINQ_ShouldGroupByBrand1()
            {
                // Arrange
                var carFactory = new Queue<List<Cars>>();
                carFactory.Enqueue(new List<Cars>
            {
                new Cars("Toyota", 2020, "Red", 50000, 15, 1),
                new Cars("Ford", 2019, "Blue", 45000, 16, 2),
                new Cars("Toyota", 2021, "White", 55000, 17, 3)
            });

                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    // Act
                    Program.GroupByDemonstrationLINQ(carFactory);

                    // Assert
                    var expected = "\t\tToyota\r\nToyota, 2020, Red, 50000, 15, 1\r\nToyota, 2021, White, 55000, 17, 3\r\n\t\tFord\r\nFord, 2019, Blue, 45000, 16, 2\r\n";
                    Assert.AreEqual(expected, sw.ToString());
                }
            }

            [TestMethod]
            public void GroupByDemonstrationExtension_ShouldGroupByBrand1()
            {
                // Arrange
                var carFactory = new Queue<List<Cars>>();
                carFactory.Enqueue(new List<Cars>
            {
                new Cars("Toyota", 2020, "Red", 50000, 15, 1),
                new Cars("Ford", 2019, "Blue", 45000, 16, 2),
                new Cars("Toyota", 2021, "White", 55000, 17, 3)
            });

                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    // Act
                    Program.GroupByDemonstrationExtension(carFactory);

                    // Assert
                    var expected = "\t\tToyota\r\nToyota, 2020, Red, 50000, 15, 1\r\nToyota, 2021, White, 55000, 17, 3\r\n\t\tFord\r\nFord, 2019, Blue, 45000, 16, 2\r\n";
                    Assert.AreEqual(expected, sw.ToString());
                }
            }

            [TestMethod]
            public void GroupByDemonstrationLINQPart2_ShouldGroupByBrand()
            {
                // Arrange
                var carFactory = new SuperHashTable<Cars>();
                carFactory.Add(new Cars("Toyota", 2020, "Red", 50000, 15, 1));
                carFactory.Add(new Cars("Ford", 2019, "Blue", 45000, 16, 2));
                carFactory.Add(new Cars("Toyota", 2021, "White", 55000, 17, 3));

                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    // Act
                    Program.GroupByDemonstrationLINQPart2(carFactory);

                    // Assert
                    var expected = "\t\tToyota\r\nToyota, 2020, Red, 50000, 15, 1\r\nToyota, 2021, White, 55000, 17, 3\r\n\t\tFord\r\nFord, 2019, Blue, 45000, 16, 2\r\n";
                    Assert.AreEqual(expected, sw.ToString());
                }
            }

            [TestMethod]
            public void GroupByDemonstrationExtensionPart2_ShouldGroupByBrand()
            {
                // Arrange
                var carFactory = new SuperHashTable<Cars>();
                carFactory.Add(new Cars("Toyota", 2020, "Red", 50000, 15, 1));
                carFactory.Add(new Cars("Ford", 2019, "Blue", 45000, 16, 2));
                carFactory.Add(new Cars("Toyota", 2021, "White", 55000, 17, 3));

                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    // Act
                    Program.GroupByDemonstrationExtensionPart2(carFactory);

                    // Assert
                    var expected = "\t\tToyota\r\nToyota, 2020, Red, 50000, 15, 1\r\nToyota, 2021, White, 55000, 17, 3\r\n\t\tFord\r\nFord, 2019, Blue, 45000, 16, 2\r\n";
                    Assert.AreEqual(expected, sw.ToString());
                }
            }

            [TestMethod]
            public void JoinDemonstrationLINQ_ShouldJoinWithCustomers__1()
            {
                // Arrange
                var carFactory = new Queue<List<Cars>>();
                carFactory.Enqueue(new List<Cars>
            {
                new Cars("Ford", 2019, "Blue", 45000, 16, 2),
                new Cars("Toyota", 2020, "Red", 50000, 15, 1)
            });

                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    // Act
                    Program.JoinDemonstrationLINQ(carFactory);

                    // Assert
                    var expected = "{ Brand = Ford, Address = Москва Улица им.Пушкина 52 }\r\n{ Brand = Toyota, Address = Казань Улица Баумана 15 }\r\n";
                    Assert.AreEqual(expected, sw.ToString());
                }
            }

            [TestMethod]
            public void JoinDemonstrationExtension_ShouldJoinWithCustomers_1()
            {
                // Arrange
                var carFactory = new Queue<List<Cars>>();
                carFactory.Enqueue(new List<Cars>
            {
                new Cars("Ford", 2019, "Blue", 45000, 16, 2),
                new Cars("Toyota", 2020, "Red", 50000, 15, 1)
            });

                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    // Act
                    Program.JoinDemonstrationExtension(carFactory);

                    // Assert
                    var expected = "{ Brand = Ford, Address = Москва Улица им.Пушкина 52 }\r\n{ Brand = Toyota, Address = Казань Улица Баумана 15 }\r\n";
                    Assert.AreEqual(expected, sw.ToString());
                }
            }
        }
    }
}


