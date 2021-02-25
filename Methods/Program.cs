using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //double fiyati = 15;
            //string aciklama = "Amasya elmasi";

            //string[] meyveler = new string[] { };



            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            //burada aslinda veriler bir veritabanindan veya kullanicidan alinir.

            //in urunler demek urunler arrayini tek tek gez demek.
            //urun ise donerken elemanin kullandigi takma isim (x de diyebilirsin)
            //Urun ise veri tipi (int string gibi)
            //java ve c# type safe oldugundan type i belirtmek gerekir.
            //veri tipine Urun yerine var da yazilabilir, yine arka planda Urun yapar.
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("\n-----------------------------------\n");
            }


            //instance(class ornegi)
            Console.WriteLine("---------------Methotlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil armut", 12, 4);
            sepetManager.Ekle2("Elma", "Yesil elma", 12, 7);
            sepetManager.Ekle2("Karpuz", "Diyarbakir karpuzu", 12, 8);
        }
    }
}
