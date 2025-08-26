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
            /*
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(BosDizi[i]);
            }*/

            //soru kullanıcıdan 10 adet sayı isteyiniz bu sayıları boş bir diziye kayıt ediniz ardndan diziyi küçükten büyüğe sıralayınız.
            /*
            int a;
            int[] bosDizi = new int[10];
            for (int i =0; i < 10; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                bosDizi[i] = a;
            }
            Array.Sort(bosDizi);
            foreach (int i in bosDizi)
            {
                Console.WriteLine(i);
            }
            */
            /*
            // Length fonksiyonu: Dizinin boyutunu verir
            Console.WriteLine("Dizinin boyutu = " + dizi1.Length);

            // Sort fonksiyonu: Diziyi küçükten büyüğe doğru sıralar
            Array.Sort(dizi1);

            foreach (int i in dizi1)
            {
                Console.WriteLine(i);
            }

            // Reverse fonksiyonu: Diziyi ters çevirir
            Array.Reverse(dizi1);
            foreach (int i in dizi1)
            {
                Console.WriteLine(i);
            }
             /*
            string isim = "MaviSu";
            foreach (char isimDizi in isim)
            {
                Console.WriteLine(isimDizi);
            }
            

            //Foreach döngüsü
            foreach(int diziEleman in bosSayiDizisi)
            {
                Console.WriteLine(diziEleman);
            }
    
             */


            //Kullanıcıdan 10 tane sayı isteyiniz, girdiği en büyük ve en küçük  sayıyı ekrana yazınız.
            int a;
            int[]SayiDizisi = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("bir sayı giriniz:");
                a = Convert.ToInt32(Console.ReadLine());
                SayiDizisi[i] = a;
            }
            Array.Sort(SayiDizisi);
            
            Console.WriteLine("girilen en küçük sayı: " + SayiDizisi[0]);
            Console.WriteLine("girilen en büyük sayı: " + SayiDizisi[9]);
            



















































        }
    }
}
