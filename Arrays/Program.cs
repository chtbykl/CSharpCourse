using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[5];
            students[0] = "Cihat";
            students[1] = "Yunus Emre";
            students[2] = "Emir Muhammed";
            students[3] = "Ferhat";
            students[4] = "Yusuf";

            string[] students2 = new[] { "İlker", "Yusuf Kaan", "Ümit", "Cihat" };

            string[] students3 = { "Emirhan", " Soykan Soykök", "Devrim", "Cihat" };

            string[] students4 = new string[4] { "İlker", "Yusuf Kaan", "Ümit", "Cihat" };

            //gördüğünüz gibi arraylerin (dizilerin) birçok yazım şekli var. hangisi kolayınıza gelirse..
            // çok boyutlu diziler..

            string[,] regions = new string[7,3]
            {
                {"İstanbul","Tekirdağ","Kocaeli"},
                {"Ankara","Konya","Yozgat"},
                {"Erzurum","Kars","Hakkari"},
                {"Gaziantep","Hatay","Adıyaman"},
                {"İzmir","Denizli","Muğla"},
                {"Antalya","Mersin","Adana"},
                {"Giresun","Kastamonu","Artvin"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }

                Console.WriteLine("-----------------------------");
            }



            /* foreach (var student in students2)
            {
                Console.WriteLine(student);
            } */

            Console.ReadLine();
        }
    }
}
