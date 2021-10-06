using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.Models
{
    public class Customer
    {
        public int hoursParked { get; set; }

        public string registration { get; set; }

        public Customer(string _registration, int _hoursParked)
        {
            Console.WriteLine("I am the Customer()");
            hoursParked = _hoursParked;
            registration = _registration;
        }
        public override string ToString()
        {
            return "I am the Customer()";
        }
    }
}
