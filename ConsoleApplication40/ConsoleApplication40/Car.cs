using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    class Car:IComparable<Car>
    {
        private int year;
        private string brand;

        public Car(int year, string brand)
        {
            this.brand = brand;
            this.year = year;
        }

        public string Info()
        {
            return brand + " " + year;
        }

        public int CompareTo(Car other)
        {
            if (this.year == other.year)
            {
                return other.brand.CompareTo(this.brand);
            }
            else
            {
                return other.year.CompareTo(this.year);
            }
        }
    }
}
