using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler = new string[9];
            string[] hayvanlar = { "At", "Kedi", "Köpek", "Balık", "ördek", "Fare" };
            int[] dizi;

            // Dizilere Değer Atama ve Erişim
            dizi = new int[4];
            renkler[0] = "Gri";
            dizi[2] = 18;

            Console.WriteLine(hayvanlar[3]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[2]);
            Console.WriteLine("-----------------------");

            //Döngülerle dizi kullanımı
            //Klavyeden girilen dizinin n tane sayının ortalamasını hesaplayan program
           
           Console.WriteLine("Eleman sayısı giriniz:");
           int diziUzunlugu = int.Parse(Console.ReadLine());
           int[] sayiDizisi = new int[diziUzunlugu];
           int toplam = 0;
           
           for (int i = 0; i < diziUzunlugu; i++)
           {
               Console.WriteLine("Lütfen {0}. sayıyı giriniz:", i+1);
               sayiDizisi[i] = int.Parse(Console.ReadLine());
               
           }
           foreach (var sayi in sayiDizisi)
           {
               toplam+=sayi;
           }
            Console.WriteLine(toplam/diziUzunlugu);

        }
    }
}
