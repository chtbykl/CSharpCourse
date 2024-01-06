namespace Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDalManager[] dalManager =
                new IDalManager[3]{ 
                    new MySqlDalManager(),
                    new PostgreSqlDalManager(), 
                    new SqlServiceDalManager()
                };
            DataBaseManager dataBaseManager = new DataBaseManager();
            

            foreach (IDalManager dal in dalManager)
            {
                dataBaseManager.Delete(dal);
            }


        }

    }

    interface IDalManager
    {
        void Add();
        void Delete();
    }

    class SqlServiceDalManager : IDalManager
    {
        public void Add()
        {
            Console.WriteLine("sql servise eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("sql servisten silindi");
        }
    }

    class PostgreSqlDalManager : IDalManager
    {
        public void Add()
        {
            Console.WriteLine("postgre sql'e eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("postgre sql'den silindi");
        }
    }

    class MySqlDalManager : IDalManager
    {
        public void Add()
        {
            Console.WriteLine("my sql'e eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("my sql'den silindi");
        }
    }

    class DataBaseManager
    {
        public void Add(IDalManager dalManager)
        {
            dalManager.Add();
        }

        public void Delete(IDalManager dalManager)
        {
            dalManager.Delete();
        }
    }
}
