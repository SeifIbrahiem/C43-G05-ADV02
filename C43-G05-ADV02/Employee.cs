using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV02
{
    internal class Employee : IComparable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int  age { get; set; }

        public double  salary { get; set; }
        public int CompareTo (object?other)
        {
            Employee E = (Employee)other;
            return this.age.CompareTo(E.age);
        }
        public override string ToString()
        {
            return $"Id:{Id} , Name:{Name} , salary:{salary} , age:{age}";
        }


    }
}
