using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(add(10,20,30));
            Console.WriteLine(Multiply(4,5,3));
            Console.ReadLine();
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        // int Multiply(int number1, int number2, int number3) --> buna metodun imzası denir. aynı isimde aynı tipte metod olabilir, parametreleri farklı olduğu sürece.. buna metod overloading (metod aşırı yüklemesi) denir
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int add(params int[] numbers) // params kelimesi ile dizi şeklinde gelen değerleri toplayabiliyoruz.. params metodun parametreleri arasında en sıraya yerleştirilerek yazılmalı,
        {
            return numbers.Sum();
        }
    }
}
