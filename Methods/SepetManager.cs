using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);

        }

        //Asagidaki yontem sektorde cok kullanilsa da dogru bir kullanim degildir.
        // bu sekilde de 3 ozelligi birden eklersiniz ama dez avantaji vardir.
        //Diyelim sonradan urunun stok bilgilerinin de gorulmesi istendiginde oldukca ugrastirici olurdu.
        //Bunlarin yerinde dogrudan Urun.cs clasina gidip oraya stok adedi diye methot ekleriz.
        //Buna encapsulation denir.
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);

        }
    }
}
