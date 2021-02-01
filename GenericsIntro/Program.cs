using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Sercan");//->kendi Add fonksiyonum

            Console.WriteLine(names.Length);//--> benim kendi lengt foksiyonum bu

            names.Add("Sinan");
            Console.WriteLine(names.Length);

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
        }
    }
}
