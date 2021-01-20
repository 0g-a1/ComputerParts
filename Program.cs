using System;

namespace ComputerParts
{
    class Program
    {
        static void Main(string[] args)
        {
            Ram ram1 = new Ram();
            ram1.RamAdi = "GSKILL 4GB Value 1600MHz CL11 DDR3L Notebook Ram";
            ram1.UrunKodu = "F3-1600C11S-4GSL";
            ram1.UrunFiyati = 184.99f;

            Ram ram2 = new Ram();
            ram2.RamAdi = "GSKILL 16GB Ripjaws DDR4 2400MHz CL16 Notebook Ram";
            ram2.UrunKodu = "F4-2400C16S-16GRS";
            ram2.UrunFiyati = 695.99f;

            Ram ram3 = new Ram();
            ram3.RamAdi = "KINGSTON Value 4GB DDR3 1333MHz CL9 Single Ram";
            ram3.UrunKodu = "KVR13N9S8/4G";
            ram3.UrunFiyati = 188.99f;

            Ram ram4 = new Ram();
            ram4.RamAdi = "HYPERX Predator 8GB 2400MHz CL12 DDR4 Single Kit Ram";
            ram4.UrunKodu = "HX424C12PB3/8";
            ram4.UrunFiyati = 378.99f;

            Ram[] ramler = new Ram[] { ram1, ram2, ram3, ram4 };


            Console.WriteLine("### For Döngüsü ###");
            for (int i = 0; i < ramler.Length; i++)
            {
                Console.WriteLine(ramler[i].RamAdi + " : " + ramler[i].UrunFiyati + "TL\n" + "*** Ürün KOdu : " + ramler[i].UrunKodu + "\n");
            }
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("### Foreach Döngüsü ###");
            foreach (var ram in ramler)
            {
                Console.WriteLine(ram.RamAdi + "\n" + ram.UrunKodu + "\n" + ram.UrunFiyati + "TL\n");
            }

            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("### While Döngüsü ###");
            int count = 0;
            while (count < ramler.Length)
            {
                Console.WriteLine("Ürün Adı : " + ramler[count].RamAdi + "\n" +
                  "Ürün Fiyatı : " + ramler[count].UrunFiyati + "TL\n" + "Ürün Kodu : " + ramler[count].UrunKodu + "\n");
                count++;
            }
        }

        class Ram
        {
            public string RamAdi { get; set; }
            public string UrunKodu { get; set; }
            public float UrunFiyati { get; set; }
        }
    }
}
