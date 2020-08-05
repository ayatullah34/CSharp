using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "engin";
            students[1] = "derin";
            students[2] = "salih";

            foreach(var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("\n");


            string[] students2 = new[] { "engin", "derin", "salih" };
            foreach (var student2 in students)
            {
                Console.WriteLine(student2);
            }
            Console.WriteLine("\n");

            
            string[] students3 ={ "engin", "derin", "salih" };
            foreach (var student3 in students)
            {
                Console.WriteLine(student3);
            }
            Console.WriteLine("\n");
            //----------------ÇOK BOYUTLU DİZİLER----------------------

            string[,] regions = new string[3, 3]
            {
                {"a","b","c"},
                {"d","e","f"},
                {"g","h","j"},
            };

            for(int i = 0;i<= regions.GetUpperBound(0); i++)// (0) satır (1) sütun regions.GetUpperBound(0)=2 ve regions.GetUpperBound(1)=2
            { 
                for(int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*");
            }


            Console.ReadLine();
        }
    }
}
