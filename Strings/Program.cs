using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringVariables();
            string sentence = "My name is Cihat Bıyıklı";

            int lenght = sentence.Length;
            var result = sentence.Clone();
            sentence = "My name is Kamil Koç ";

            bool endsWith = sentence.EndsWith("ç");
            bool startsWith = sentence.StartsWith("My name");

            var result1 = sentence.IndexOf(" a");
            var result2 = sentence.LastIndexOf(" a");
            var result3 = sentence.Insert(0, "Hello, ");
            var result4 = sentence.Substring(3);
            var result5 = sentence.ToLower();
            var result6 = sentence.ToUpper();
            var result7 = sentence.Replace(" ", "_");
            var result8 = sentence.Remove(7,3);

            Console.WriteLine(result8);
            Console.WriteLine(lenght);

            Console.ReadLine();
        }

        private static void StringVariables()
        {
            string city = "Çankırı";
            string city2 = "Ankara";

            Console.WriteLine(city[3]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string result = city + city2;
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
