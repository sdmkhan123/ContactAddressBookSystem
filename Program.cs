using System;

namespace ContactAddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Contact Address Book System");
            Person person1 = new Person("name", "address", "city", "state", "zipCode", "phoneNum");
            Console.WriteLine("enter intial numm of address ");
            int n = Convert.ToInt32(Console.ReadLine());
            Person.addList(n);
            Person.printList();
        }
    }
}