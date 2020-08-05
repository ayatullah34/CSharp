using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Add()
        {
            Console.WriteLine("Add:");
        }

        static int Add2(int x,int y=30)
        {
            var sum = x + y;
            return sum;
        }

        static int Add3(ref int x,int y)
        {
            x = 30;
            return x + y;
        }

        static int Add4(out int x, int y)
        {
            x = 50;
            return x + y;
        }

        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)//Method Overloading...
        {
            return number1 * number2 *number3;
        }

        static int Add5(params int[] numbers)//PARAMS İLE BİRDEN FAZLA NUMBER EKLEYEBİLİRİZ....
        {
            return numbers.Sum(); //HAZIR FONK. RAKAMLARI TOPLAR
        }

        static int Add6(int x,params int[] numbers)//sona params eklenebilir params dan sonra bir şey gelmez parametreye ilk gelen değer x e gider
        {
            return numbers.Sum(); //HAZIR FONK. RAKAMLARI TOPLAR
        }

        static void Main(string[] args)
        {
            Add();

            var answer= Add2(5,55);
            Console.WriteLine(answer);

            var answer2 = Add2(5);
            Console.WriteLine(answer2);

            int x = 3;
            int y = 10;
            Console.WriteLine("eski x değeri:"+x);
            var answer3 = Add3(ref x, y); //ref pointer gibi gönderilen değerin değişikliklerden etkilenebilmesini sağlar
            Console.WriteLine(answer3);
            Console.WriteLine("x değeri güncellendi:"+x);

            int a;
            int b= 10; 
          
            var answer4 = Add4(out a, b); //out ref'den farkı ilk set etmeye gerek duymaması yinede a yı günceller
            Console.WriteLine("a+b(50+10):"+answer4);
            Console.WriteLine("a değeri güncellendi:" + a);

            Console.WriteLine("Çarpma sonucu(2,4):"+Multiply(2,4));
            Console.WriteLine("2.Çarpma sonucu(2,4,5):" + Multiply(2, 4,5));

            Console.WriteLine("Params sonucu:"+Add5(1,2,3,4,5,6,7,8,9));//params ile birden fazla sayı yolladık
            Console.WriteLine("Params sonucu:" + Add6(1, 2, 3, 4, 5, 6, 7, 8, 9));//ilk yollanan 1 x e gitti fonk.da kullanmadık cevap bir eksik çıkar

            Console.ReadLine();
        }

    }
}
