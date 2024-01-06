using System.Security.AccessControl;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Masaüstü PC"},
                new Category{CategoryId = 2, CategoryName = "Laptop"},
                new Category{CategoryId = 3, CategoryName = "Telefon"},
                new Category{CategoryId = 4, CategoryName = "PC Aksesuar"},
                new Category{CategoryId = 5, CategoryName = "PC Bileşenleri"},
                new Category{CategoryId = 6, CategoryName = "Telefon Aksesuar"},
                new Category{CategoryId = 7,CategoryName = "Kulaklık"},

            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1, CatengoryId = 1, ProductName = "Vento Hazır Sistem", QuantityPerUnit = "r5 7500f-rx6700ddr6 10gb-16 gb ram-500 gb nvme m2 ssd-650w +80 pwr", UnitPrice = 21500, UnitsInStock = 7},
                new Product{ProductId = 2, CatengoryId = 7, ProductName = "Xiaomi Kulaklık", QuantityPerUnit = "Bluetooth kulaklık", UnitPrice = 1000, UnitsInStock = 5},
                new Product{ProductId = 3, CatengoryId = 5, ProductName = "Kingston Ram", QuantityPerUnit = "16 gb ram", UnitPrice = 3000, UnitsInStock = 11},
                new Product{ProductId = 4, CatengoryId = 2, ProductName = "Acer Aspire Laptop", QuantityPerUnit = "İntel i7 9750H-gtx1650 4gb-8gb ram-250 gb nvme m2 ssd-1tb Hdd", UnitPrice = 20000, UnitsInStock = 3},
                new Product{ProductId = 5, CatengoryId = 4, ProductName = "Microsoft Klavye", QuantityPerUnit = "Kablolu Mekanik Klavye", UnitPrice = 2000, UnitsInStock = 6},
                new Product{ProductId = 6, CatengoryId = 3, ProductName = "LG Akıllı Telefon", QuantityPerUnit = "LG G Pro Lite", UnitPrice = 5000, UnitsInStock = 0}
            };

            Console.WriteLine("Algoritmik kod ile ürün filtreleme-----------------");

            foreach (var product in products)
            {
                if (product.UnitPrice > 10000 && product.UnitsInStock > 5)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("Linq kullanarak ürün filtreleme---------------------");

            var result = products.Where(i => i.UnitPrice > 10000 && i.UnitsInStock > 5);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("metod içinde algoritmik ürün filtreleme---------------------");
            foreach (var filteredProduct in GetProduct(products))
            {
                Console.WriteLine(filteredProduct.ProductName);
            }

            Console.WriteLine("metod içinde Linq kullanarak ürün filtreleme---------------------");
            foreach (var filteredProduct in GetProductLinq(products))
            {
                Console.WriteLine(filteredProduct.ProductName);
            }
        }

        static List<Product> GetProduct(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 10000 && product.UnitsInStock > 5)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }

        static List<Product> GetProductLinq(List<Product> products)
        {
            return products.Where(i => i.UnitPrice > 10000 && i.UnitsInStock > 5).ToList();
        }

    }

    class Product
    {
        public int ProductId { get; set; }
        public int CatengoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
