using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3]
            {
                new Customer{Firstname="engin" },
                new Student{Firstname="derin" },
                new Person{Firstname="salih" }

            };

            foreach (var person in people)
            {
                Console.WriteLine(person.Firstname);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id{ get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }


}
