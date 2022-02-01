using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhilleOnek
{
    class Program
    {
        static void Main(string[] args)
        {
            int bs, bms, ks;
            bs = 0;
            bms = 0;
            ks = 0;
            string cevap;


            cevapyeniden:Console.WriteLine("Müşteri var mı? Evet/Hayır");
            byte musteri = Convert.ToByte(Console.ReadLine());
            do
            {

                switch (musteri)
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
                        Console.WriteLine("Yanlı cevap verdiniz. Lütfen tekrar giriş yapınız (1/2/3)");
                        goto cevapyeniden;
                }

                Console.WriteLine("Başka müşteri var mı? (E/H)");
                cevap=Console.ReadLine();
            } while (cevap != "H" && cevap != "h");

            Console.WriteLine("Beğenen müşteri sayısı: " + bs);
            Console.WriteLine("Beğenmeyen müşteri sayısı: " + bms);
            Console.WriteLine("Kararsız müşteri sayısı: " + ks);
            Console.WriteLine("Toplam müşteri sayısı: " + (bs + bms + ks));
            Console.ReadLine();
        }
    }
}
