namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    // attribute'ler ile bir sınıfa veya sınıfın özelliğine bir kural getirebiliriz mesela
    // örneğin sınıfa sen veri tabanındaki şu tablosun diyebiliriz. veya bir özelliğin null olarak kalmasını istemezsek o alanı bmutlaka kullanıcı doldurmalı şeklinde bir attribute koyabiliriz.
    // yani ilgili nesne için bir kural veya bilgi oluştururuz
    //yani nesnelerimize veya bu nesnelerin özelliklerine,metodlarına anlam katmak için oluştururuz
    // ekstra bir bilgi veya kural koyarız
    //hazır attribute'ler de var tabi ki
    //attribute'ler reflections ile anlamlıdır oyüzden ikisi birlikte kullanılır o konuya da bakın

    [ToTable("Customers")] //bunlara attribute denir
    internal class Customer 
    {
        
        public int Id { get; set; }
        [RequiredProperty]
        public string Name { get; set; }
        [RequiredProperty]
        public string Address { get; set; }
        
    }

    internal class CustomerDal
    {
        [Obsolete("dont use add, instead use addnew method")] //obsolete eski demek zaten. açıklamada add metodunu kullanma, yerine addnew metodunu kullan demek
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{0},{0} --- eklendi",customer.Id,customer.Name,customer.Address);
        }

        public void AddNew()
        {

        }
    }

    internal class RequiredPropertyAttribute : Attribute
    {

    }
    internal class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
