using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Student { FirstName = "Cihat" },
                new Customer { FirstName = "Yunus Emre" },
                new Person {FirstName = "Emir Muhammed"}
            };
            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            
            Console.ReadLine();
        }
    }

    class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Student : Person
    {
        public string Departmant { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }
}
