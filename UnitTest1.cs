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

            var result = Program.WhereDemonstrationLINQ(carFactory, "Toyota");
            Assert.AreEqual(1, result.Count());
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

            var result = Program.WhereDemonstrationLINQ(carFactory, "Honda");
            Assert.AreEqual(0, result.Count());
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
            var result = Program.WhereDemonstrationLINQPart2(carFactory, "Toyota");
            Assert.AreEqual(1, result.Count());
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

            var result = Program.WhereDemonstrationLINQPart2(carFactory, "Honda");
            Assert.AreEqual(0, result.Count());
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

            var result = Program.WhereDemonstrationExtension(carFactory, "Toyota");
            Assert.AreEqual(1, result.Count());
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

            var result = Program.WhereDemonstrationExtension(carFactory, "Honda");
            Assert.AreEqual(0, result.Count());
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

            var result = Program.WhereDemonstrationExtensionPart2(carFactory, "Toyota");
            Assert.AreEqual(1, result.Count());
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

            var result = Program.WhereDemonstrationExtensionPart2(carFactory, "Honda");
            Assert.AreEqual(0, result.Count());
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

            var result = Program.MaxDemonstrationLINQ(carFactory);
            var expected = new Cars("BMW", 2020, "White", 30000, 15, 0);
            Assert.AreEqual(expected, result.First());
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

            var result = Program.MaxDemonstrationExtension(carFactory);
            var expected = new Cars("BMW", 2020, "White", 30000, 15, 0);
            Assert.AreEqual(expected, result.First());
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
            var result = Program.CountDemonstrationLINQPart2(carFactory);
            Assert.AreEqual(2, result);
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
            var result = Program.CountDemonstrationLINQPart2(carFactory);
            Assert.AreEqual(0, result);
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
            var result = Program.CountDemonstrationExtensionPart2(carFactory);
            Assert.AreEqual(2, result);
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

            var result = Program.CountDemonstrationExtensionPart2(carFactory);
            Assert.AreEqual(0, result);
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

            var result = Program.SumDemonstrationExtensionPart2(carFactory);
            Assert.AreEqual(75000, result);

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
            var result = Program.SumDemonstrationExtensionPart2(carFactory);
            Assert.AreEqual(75000, result);
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
                var result = Program.WhereDemonstrationLINQ(carFactory, brand);

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
                var result = Program.WhereDemonstrationExtension(carFactory, brand);

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
                var cars = Program.IntersectDemonstrationLINQ(carFactory1, carFactory2);

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
                var cars = Program.IntersectDemonstrationExtension(carFactory1, carFactory2);

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
                var exCar = Program.MaxDemonstrationLINQ(carFactory);

                // Assert
                Assert.AreEqual(50000, exCar.First().Cost);
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
                var exCar = Program.MaxDemonstrationExtension(carFactory);

                // Assert
                Assert.AreEqual(50000, exCar.First().Cost);
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
                var result = Program.GroupByDemonstrationLINQ(carFactory);

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
                var result = Program.GroupByDemonstrationExtension(carFactory);

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
                var result = Program.JoinDemonstrationLINQ(carFactory);

                // Assert
                Assert.AreEqual(2, result.Count());
                Assert.AreEqual("Toyota", result.First().Brand);
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
                var result = Program.JoinDemonstrationExtension(carFactory);

                // Assert
                Assert.AreEqual(2, result.Count());
                Assert.AreEqual("Toyota", result.First().Brand);
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
                var result = Program.IntersectDemonstrationLINQ(carFactory, carFactory1);
                var expected = new Cars("Ford", 2019, "Blue", 45000, 16, 2);
                Assert.AreEqual(expected, result.First());
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

                var result = Program.IntersectDemonstrationExtension(carFactory, carFactory1);
                var expected = new Cars("Ford", 2019, "Blue", 45000, 16, 2);
                Assert.AreEqual(expected, result.First());
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
                var result = Program.GroupByDemonstrationLINQ(carFactory);
                Assert.AreEqual(2, result.Count());
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

                var result = Program.GroupByDemonstrationLINQ(carFactory);
                Assert.AreEqual(2, result.Count());
            }

            [TestMethod]
            public void GroupByDemonstrationLINQPart2_ShouldGroupByBrand()
            {
                // Arrange
                var carFactory = new SuperHashTable<Cars>();
                carFactory.Add(new Cars("Toyota", 2020, "Red", 50000, 15, 1));
                carFactory.Add(new Cars("Ford", 2019, "Blue", 45000, 16, 2));
                carFactory.Add(new Cars("Toyota", 2021, "White", 55000, 17, 3));

                var result = Program.GroupByDemonstrationLINQPart2(carFactory);
                Assert.AreEqual(2, result.Count());
            }

            [TestMethod]
            public void GroupByDemonstrationExtensionPart2_ShouldGroupByBrand()
            {
                // Arrange
                var carFactory = new SuperHashTable<Cars>();
                carFactory.Add(new Cars("Toyota", 2020, "Red", 50000, 15, 1));
                carFactory.Add(new Cars("Ford", 2019, "Blue", 45000, 16, 2));
                carFactory.Add(new Cars("Toyota", 2021, "White", 55000, 17, 3));

                var result = Program.GroupByDemonstrationExtensionPart2(carFactory);
                Assert.AreEqual(2, result.Count());
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

                var result = Program.JoinDemonstrationLINQ(carFactory);
                Assert.AreEqual("Ford", result.First().Brand);
                Assert.AreEqual("Москва Улица им.Пушкина 52", result.First().Address);
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

                var result = Program.JoinDemonstrationExtension(carFactory);
                Assert.AreEqual("Ford", result.First().Brand);
                Assert.AreEqual("Москва Улица им.Пушкина 52", result.First().Address);
            }
        }
    }
}


