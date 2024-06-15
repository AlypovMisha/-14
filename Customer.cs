using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_14
{
    public class Customer
    {
        public string Address { get; set; }

        public string City { get; set; }

        public string Brand { get; set; }

        public Customer(string city, string address, string brand) 
        {
            City = city;
            Address = address;
            Brand = brand;
        }
    }
}
