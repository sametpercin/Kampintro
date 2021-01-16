using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yerleştirme Kampı";
            string kurs2 = "Proglamaya Başlamak İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yerleştirme Kampı", "Proglamaya Başlamak İçin Temel Kurs", "Java", "Python", "C++" };

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
