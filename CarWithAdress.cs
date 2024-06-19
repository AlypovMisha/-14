using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_14
{
    public class CarWithAddress
    {
        public string Brand { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return Brand + " - " + Address;
        }
    }
}
