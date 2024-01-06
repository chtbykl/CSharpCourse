namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>(); // c# içinde olan listte bizim yaptığımız liste gibi çalışıyor.
            cities.Add("Ankara");
            Console.WriteLine(cities.Count);

            MyList<string> cities2 = new MyList<string>();
            cities2.add("İstanbul");
            cities2.add("Tekirdağ");
            cities2.add("Ankara");
            cities2.add("Giresun");
            Console.WriteLine(cities2.Count);

        }
    }

    class MyList<T> // bu sınıflara generic class denir..
    {
        private T[] _array;
        private T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length +1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public int Count
        {

            get
            {
                return _array.Length;
            }
        }
    }
}
