using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        enum Days // bu da bir veri tipidir, içerisinde birden fazla string veri tutabiliriz ve bu veri tiplerinden istediğimizi çağırabiliriz.
        {
            monday = 1,tuesday,wednesday, thursday, friday, saturday, sunday 
        }
        static void Main(string[] args)
        {
            // Value Types
            // Console.WriteLine("hello world");
            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            short number3 = 32767;
            byte number4 = 255;

            bool condition = true;
            char character = 'x';
            string city = "ankara";

            double number5 = 3.14;
            decimal number6 = 3.14m;

            var number7 = 3;

            Console.WriteLine(Days.friday);

            Console.WriteLine(" Numbers are {0}, {1}, {2} ", number1, number2, number3);
            Console.WriteLine(" the value types are : {0}, {1}, {2}, {3}", condition, character, city, number5);
            Console.ReadLine();
        }
    }
}
