using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int c = 0;
            while (sayac <= sayi)
            {
                c += sayac;
                sayac++;
            }
            Console.WriteLine(c / sayi);

            Console.WriteLine("--------------------------");
            char character = 'a';
            while (character < 'z')
            {
                Console.WriteLine(character);
                character++;

            }
            Console.WriteLine("--------------------------");
            
            string[] ogrenciler = { "Mert", "Merve", "Funda", "Kerem" };

            foreach (var i in ogrenciler)
            {
               Console.WriteLine(i);
            }


        }
    }
}