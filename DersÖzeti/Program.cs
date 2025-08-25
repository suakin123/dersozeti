using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersÖzeti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             * Diziler (Arrays): Aynı tipteki verileri ardı ardına saklamamızı sağlıyan bir yapıdır.
             * Avantajları: Diğer veri yapılarından daha hızlıdır.
             * Dezavantajları:  Tanımlanmış bir dizinin boyutu daha sonradan değiştirilemez.
            */
            string[] Dizi = { "1.eleman", "2.eleman", "3.eleman" };
            int[] SayiDizisi = { 1, 2, 3, 4, 5 };
            int[] BosDizi = new int[6];
            
            BosDizi[0] = 2; // İndis numarası -> her zaman 0'dan başlar.
            BosDizi[1] = 3;
            BosDizi[2] = 4;
            BosDizi[3] = 5;
            BosDizi[4] = 6;
            BosDizi[5] = 7;
            /*
           Console.WriteLine(BosDizi[0]);
           Console.WriteLine(BosDizi[1]);
           Console.WriteLine(BosDizi[2]);
           Console.WriteLine(BosDizi[3]);
           Console.WriteLine(BosDizi[4]);
           */
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(BosDizi[i]);
            }















































        }
    }
}
