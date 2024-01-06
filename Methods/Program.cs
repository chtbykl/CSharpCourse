using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();

            int number1 = 10;
            int number2 = 20;
            int result = Add2(ref number1, number2);//int result = Add2(ref number1, 20);
            // ref anahtar kelimesi başında olduğu değişkeni referans olarak, komple değişkenin kendisiyle birlikte, yollar. eğer o kelimeyi yazmassak, parametre olarak değişkenin sadece değeri karşıya gider. ve bu da o değişkenin değerini elle yazıp göndermekten farklı olmaz...
            // bu ayrıca şuna denk geliyor: ref kelimesini kullanmadığımızda bellekte iki tane aynı değişken oluşuyor. ref kelimesini kullandığımızda ise bunu yapma onun yerine number1 referansını iki yerde de kullan demek.. yani bellekte aynı değişkeni bir daha oluşturmayıp aynı değişkeni iki yerde de kullanıyoruz
            //bu 'ref' kelimesinin yerine 'out' kelimesini de kullanabiliriz. ref'le aynı işi yapar. tek farkı out' ile gönderdiğimiz referans değişkenin önceden belirlenmiş bir değeri olmayabilir. yani değişkene bir değer vermek zorunda değiliz. ama refte gönderilen değişkenin bir değeri olmak zorunda..
            // 'out' kullandığımızda gönderilen değişkenin gönderilen metod içerisinde bir kere daha set edilmesi, yani değer verilmesi, gerekir. gönderdiğimiz değişkenin değerinin zaten olup olmadığı önemli değil, metod içerisinde en az bir kez daha set edilecek. bu da 'out' kelimesinin çok da iyi olmadığını gösteriyor. onun yerine ref kullan..
            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(ref int number1, int number2 = 5) //burada parametrelere eğer bir sayı verilmezse bu metod çağırılırken, 6 ve 5 default değerlerini kullan demek.buna default parametreli metodlar denir
        {
            number1 = 50;
            return number1 + number2;
        }
    }
}
