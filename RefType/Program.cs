using System;

namespace RefType
{
    class Program
    {
        static void Main(string[] args)
        {

            //int, decimal,float,enum,boolean are value types
            //burda isler stack memoryde gerceklesiyor
            int num1 = 10;
            int num2 = 20;

            num1 = num2;
            num2 = 30;

            Console.WriteLine("Number 1 :" + num1);  //what is result? 20

            int[] nums1 = new int[] { 1, 2, 3 };
            int[] nums2 = new int[] { 10, 20, 30 };

            nums1 = nums2;
            nums2[0] = 1000;

            Console.WriteLine(nums1[0]);//what is result? if you think that it is same logic as above it would be 10 but it is 1000
                                        // burda isler heap de gerceklesiyor
                                        //arays,class,interface .. reference types
                                        //new kelimesi heap de alan aciyor ve o alana bir referans degeri(adres) veriyor
                                        //burda nums1'in heapteki alani garbage collector tarafindan toplanir. nums1 ve nums2 ayni referansta yer alir

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Sercan";
            person2 = person1;
            person1.FirstName = "Hayri";
            Console.WriteLine(person2.FirstName);//-->Hayri

            Customer customer = new Customer();
            customer.FirstName = "Ummece";
            customer.CreditCardNumber = "12345678";
            Employees employees = new Employees();

            Person person3 = customer;//person customerin base classi oldugu icin boyle bir atamaya izin veriyor
            Console.WriteLine(person3.FirstName);//ummece olur

            //ama creditcardnumbera ulasmak icin sunu yapmam lazim
            Console.WriteLine(((Customer)person3).CreditCardNumber);//cutomerin credikart nosunu person3'e atamis olduk

            PersonManager manager = new PersonManager();
            manager.Add(person3);
            manager.Add(customer);//ustteki ile ayni seyi verir


        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer:Person
        {
            public string CreditCardNumber { get; set; }
        }

        class Employees:Person
        {
            public int EmpolyeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)//person yapinca buraya parametre olarak person,customer ve employee atayabilirim
            {
                Console.WriteLine(person.FirstName);
            }
        }

    }
}
