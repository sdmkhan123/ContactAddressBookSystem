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
            //create initial addr book with some contact addr
            Person.addList(n);
            //add new contact to addresss book
            Person.addNewContact("name", "address", "city", "state", "zipCode", "phoneNum");
            //Call func to edit contact name
            string str = "Saddam";
            Person.enditContactName(str);
            //Delete a contact addr from addr book
            //Delete a contact addr from addr book
            string deleteContact = "SDMKHAN";
            Person.Delete(deleteContact);
            //print presnt contact in addr book
            Person.printList();
        }
    }
}