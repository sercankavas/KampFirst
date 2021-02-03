using System;
using System.Collections.Generic;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id=1,FirstName="Sercan",LastName="Kavas",City="istanbul"};//new yazinca konstraktiri hemen calistirir Customer clasinin icindeki
            Customer customer2 = new Customer(2, "Sinan", "kavas", "Izmit"); //2 turlude olusturbilirz

            Dictionary<int, 2>  dict = new Dictionary<int, 2>();

        }

        class Customer
        {
            public Customer() //default constractor
            {

            }

            public Customer(int id, string firstName,string lastName,string city)
            {
                FirstName = firstName;
                LastName = lastName;
                Id = id;
                City = city;
            }
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }
    }
}
