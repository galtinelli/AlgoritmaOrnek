using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir ürün için yapılan ankette beğenen,beğenmeyen,kararsız kalanların sayısını ve toplam müşteri sayısını ekrana yazdıran program "Başka müşteri var mı?" sorusuna verilen cevap HAYIR olmadığı sürece dönsün (Do-While döngüsü ile)

            int bs = 0, bms = 0, ks = 0;
            bool musteriSonuc;

            secim: Console.WriteLine("Müşteri var mı? Evet/Hayır");
            string musteri = Console.ReadLine();
            if (musteri=="Evet"||musteri=="evet")
            {
                musteriSonuc = true;
                do
                {
                    Console.WriteLine("Ürün hakkındaki düşünceleriniz nedir? Beğendim:1/Beğenmedim:2/Kararsızım:3");
                    byte sonuc = Convert.ToByte(Console.ReadLine());
                    switch (sonuc)
                    {
                        case 1:
                            bs++;
                            break;
                        case 2:
                            bms++;
                            break;
                        case 3:
                            ks++;
                            break;
                        default:
                            Console.WriteLine("Yanlış veri girişi yapılmıştır.");
                            break;
                    }
                    goto secim;

                } while (musteriSonuc == false);
            }
            else
            {
                musteriSonuc = false;
            }
            Console.WriteLine("Beğenen müşteri sayısı: " + bs);
            Console.WriteLine("Beğenmeyen müşteri sayısı: " + bms);
            Console.WriteLine("Kararsız müşteri sayısı: " + ks);
            Console.WriteLine("Toplam müşteri sayısı: " + (bs + bms + ks));



        }
    }
}
