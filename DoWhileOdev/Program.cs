using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            int bs, bms, ks;
            bs = 0;
            bms = 0;
            ks = 0;

        musteriVarMı: Console.WriteLine("Müşteri var mı? Evet/Hayır");
            string musteri = Console.ReadLine();

            if (musteri == "Evet" || musteri == "evet")
            {
                Console.WriteLine("Ürün hakkındaki düşünceleriniz nedir? Beğendim:1/Beğenmedim:2/Kararsızım:3");
                byte cevap = Convert.ToByte(Console.ReadLine());

                switch (cevap)
                {
                    case 1:
                        bs++;
                        goto musteriVarMı;
                    case 2:
                        bms++;
                        goto musteriVarMı;
                    case 3:
                        ks++;
                        goto musteriVarMı;
                }

            }
            else if (musteri == "Hayır" || musteri == "HAYIR")
            {
                goto son;
            }

        son: Console.WriteLine("Beğenen müşteri sayısı: " + bs);
            Console.WriteLine("Beğenmeyen müşteri sayısı: " + bms);
            Console.WriteLine("Kararsız müşteri sayısı: " + ks);
            Console.WriteLine("Toplam müşteri sayısı: " + (bs + bms + ks));
            Console.ReadLine();
        }
    }
}
