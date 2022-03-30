using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Person : Object, IComparable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            Person personToCompare = (Person)obj;

            if (Name.Length > personToCompare.Name.Length)
            {
                return 1;
            }else if (Name.Length == personToCompare.Name.Length)
            {
                return 0;
            }
            else
            {
                return -1;
            }

            //if (Age > personToCompare.Age)
            //{
            //    return 1;
            //}
            //else if (Age == personToCompare.Age)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return -1;
            //}
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }
}
