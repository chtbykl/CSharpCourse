namespace Constructors
{
    internal class Program
    {
        // constructor bir sınıf newlendiğinde bir kere çalışır ve bir daha çalışmaz..
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Cihat",
                LastName = "Bıyıklı",
                Address = "Ankara"
            };

            Customer customer2 = new Customer(2, "Yunus Emre", "Kendilci", "Ankara");

            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }

    class Customer
    {
        public Customer(int id, string firstName, string lastName, string address)
        {
            Console.WriteLine("constructor2 çalıştı");
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }
        public Customer()// biz bu constructor'ı  yazmasak da arka landa böyle bir constructor çaışıyor. buna default constructor denir.
        {
            Console.WriteLine("constructor1 çalıştı");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
