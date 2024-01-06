using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //IPerson person = new Iperson(); // interface'ler kendi başına newlenemez
            IPerson person = new Instructor(); // ama böyle kullanılabilir, çünkü Instructor somut bir sınıf Iperson ise soyut bir interfacedir. interfaceler bize sınıfları oluşturmamızı sağlayan bir taslak görevi görür.

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(), 
                new MySqlCustomerDal(), 
                new OracleCustomerDal()
            };
            foreach (ICustomerDal customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Student student = new Student
            {
                Id = 1,
                Email = "chtbykl38@gmail.com",
                FirstName = "Cihat",
                LastName = "Bıyıklı",
                Grade = 12
            };
            Instructor instructor = new Instructor
            {
                Id = 2,
                Email = "xKralTRx@gmail.com",
                FirstName = "Kamil",
                LastName = "Koç",
                Teaching = "Matematik"
            };

            personManager.Add(instructor);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }

    }

    class Instructor : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public String Teaching { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Grade { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Person added! {0}", person.FirstName);
        }
    }
}
