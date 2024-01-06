using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(), 
                new Robot()
            };

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
                
            };

            Console.ReadLine();
        }
    }
}
