using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3] 
            { 
                new SqlServerCustomerDal(), 
                new OracleCustomerDal(),
                new MysqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer()
            {
                Id = 1,
                Firstname = "ENGİN",
                Lastname = "demir",
                Address = "ankara"

            };

            personManager.Add(new Student { Id = 1, Firstname = "derin", Lastname = "demir", Department = "computer science" });

            personManager.Add(customer);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Address { get; set; }

    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Department { get; set; }
    }


    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Firstname);
        }


    }


}
