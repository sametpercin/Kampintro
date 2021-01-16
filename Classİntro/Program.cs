using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Samet";
            int yas = 22;

            kurs kurs1=new kurs();
            kurs1.KursAdı = "C#";
            kurs1.Egitmen = "Samet Percin";
            kurs1.IzlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.KursAdı = "Java";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 64;

            kurs kurs3 = new kurs();
            kurs3.KursAdı = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            kurs kurs4 = new kurs();
            kurs4.KursAdı = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;



            //Console.WriteLine(kurs1.KursAdı + " : " + kurs1.Egitmen);

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı);
            }





            //Console.WriteLine("Hello World!");
        }
    }

    class kurs
    {
        public string KursAdı { get; set; }
        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
