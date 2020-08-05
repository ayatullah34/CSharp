using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "ankara";
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "istanbul";
            string result = city + city2;
            Console.WriteLine(result);
            Console.WriteLine("{0} {1}",city,city2);
            Console.WriteLine("\n");

            string sentence = "my name is engin demir";
            var result2 = sentence.Length; //cümle uzunluğu
            var result3 = sentence.Clone();//aynı cümle oluşturma
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            bool result4 = sentence.EndsWith("ğ");
            bool result5 = sentence.StartsWith("m");
            Console.WriteLine(result4);
            Console.WriteLine(result5);

            var result6 = sentence.IndexOf("name");//name nerden başlıyo yoksa -1 basar
            Console.WriteLine(result6);

            var result7= sentence.IndexOf(" ");//bulunan ilk boşluğu alır
            Console.WriteLine(result7);

            var result8 = sentence.LastIndexOf(" ");//aramaya tersten başlar
            Console.WriteLine(result8);

            var result9 = sentence.Insert(0, "hello");
            Console.WriteLine(result9);

            var result10 = sentence.Substring(4,6);
            Console.WriteLine(result10);

            var result11 = sentence.ToLower();
            Console.WriteLine(result11);

            var result12 = sentence.ToUpper();
            Console.WriteLine(result12);
            
            var result13 = sentence.Replace(" ", "-");
            Console.WriteLine(result13);

            var result14 = sentence.Remove(2);//2.satırdan itibaren kaldırır
            Console.WriteLine(result14);

            var result15 = sentence.Remove(2, 5); //2den itibaren 5 tane at
            Console.WriteLine(result15);

            Console.ReadLine();
        }
    }
}
