using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 3.14;

            /*
            Console.WriteLine(number == 12 ? "the number is 12" : "the number is not 12");
            // bu kısaltılmış şart bloğu aslında şu demek:

            if (number == 12)
               {
                   Console.WriteLine("the number is 12");

               }
               else
               {
                   Console.WriteLine("the number is not 12");
               }
            */

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("the number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("the number is 20");
            //        break;
            //    case 30:
            //        Console.WriteLine("the number is 30");
            //        break;
            //    default:
            //        Console.WriteLine("the number is not 10,20,30");
            //        break;
            //}

            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("the number is between 0-100");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("the number is between 101-200");
            //}
            //else if (number > 200 || number < 0)
            //{
            //    Console.WriteLine("the number is less than 0 or greater than 200");
            //}
            //else
            //{
            //    Console.WriteLine("the number is unknown");
            //}


            Console.ReadLine();
        }
    }
}
