using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;
            //num1??-->30

            int[] nums1 = new int[] { 10, 20, 30 };
            int[] nums2 = new int[] { 100, 200, 300 };
            num1 = nums2;
            nums2[0] = 999;
            //nums1[0]??  999

            /*
             * int , dec,bool,double,float-->deger type 
             * class,interface,array-->reference type
             * bellekte 2 tur alan var.1.stack  2.heap     ***************** COK ONEMLI**********************
             * deger typelar stackde gercekelesiyor
             * refernece typelar heapde gerceklesiyo
             */
        }
    }
}
