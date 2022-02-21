using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 7, 4, 5, 89, 34, 67, 45 };
            Console.WriteLine("---^^^^^^-----Unsort---------");
            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

            Console.WriteLine("---^^^^^^------Sort-------");
            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

            Console.WriteLine("--^^^^^^-------Clear--------");
            Array.Clear(sayiDizisi, 3, 1);
            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

            Console.WriteLine("---^^^^^^-------Reverse------");
            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

            Console.WriteLine("----^^^^^^-------IndexOf-------");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 67));

            Console.WriteLine("---^^^^^^-------Resize-------");
            Array.Resize<int>(ref sayiDizisi,8);
            sayiDizisi[7]= 13;
            foreach (var item in sayiDizisi)
            Console.WriteLine(item);

        }
    }
}