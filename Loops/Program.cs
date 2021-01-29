using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Java";
            string kurs2 = "C#";
            string kurs3 = "Python";

            string[] kurslar = new string[] { "Java", "C#", "Python"};



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (var item in kurslar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
