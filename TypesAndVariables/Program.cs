using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD");
            int number1 = 10;
            long number2 = 2147483647;
            short number3 = 32767;
            byte number4 = 255;
            bool condition = true;
            bool condition2 = false;
            char character = 'A';
            string city = "ankara";
            double number5=1.1;
            decimal number6=0.0032m;
            decimal number7 = 20;
            var number8 = 10;
            number8 = 'A';
        
            Console.WriteLine("number1 is {0}",number1);
            Console.WriteLine("number1 is "+ number1);
            Console.WriteLine("number2 is " + number2);
            Console.WriteLine("number3 is " + number3);
            Console.WriteLine("number4 is " + number4);
            Console.WriteLine("character is " + character);
            Console.WriteLine("character is " +(int) character);
            Console.WriteLine("number5 is " + number5);
            Console.WriteLine("number6 is " + number6);
            Console.WriteLine("number7 is " + number7);
            Console.WriteLine(Days.Monday);
            Console.WriteLine((int)Days.Monday);
            Console.WriteLine("number8 is " + number8);


            Console.ReadLine();
        }
    }

    enum Days
    {
        //0,1,2,3,4,5,6
        Monday=10,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
            //10,11,12,13,14,15,16
    }
}
