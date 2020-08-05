using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    

    class Program
    {
       static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Console.WriteLine("\n");

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            Console.WriteLine("\n");

            Customer customer = new Customer();
            customer.City = "ankara";
            customer.Id = 1;
            customer.Firstname = "engin";
            customer.Lastname = "demir";

            Customer customer2 = new Customer()
            {
                Id=2,City="İSTANBUL",Firstname="derin",Lastname="demir"

            };

            Console.WriteLine(customer2.Firstname);



            Console.ReadLine();
        }
    }

}
