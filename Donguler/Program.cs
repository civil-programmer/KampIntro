using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            Console.WriteLine("***********************************************");

            //bu tip verileri string olarak ayri ayri yazmak yerine arrayde tutariz

            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi", 
                "Programlamaya baslangic icin temel kurs",
                "Java", "Python","C#"};

            //for daha genel amaclar icin kullanilir foreach`e gore.
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("***********************************************");

            //Foreach`de i`ninci eleman diye belirtmemize gerek yok
            //kendisi tek tek diziyi dolasir.
            //dizilerde kullanilir sadece.

            foreach (string kurs in kurslar)
            {

                Console.WriteLine(kurs);

            }


            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
