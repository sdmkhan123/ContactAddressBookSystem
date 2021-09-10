using System;
using System.Collections.Generic;
using System.Text;

namespace ContactAddressBookSystem
{
    public class Person
    {
        private string name;
        private string address;
        private string city;
        private string state;
        private string zipCode;
        private string phoneNum;

        public Person(string name, string address, string city, string state, string zipCode, string phoneNum)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNum = phoneNum;
        }
        private static List<Person> personList = new List<Person>();
        public static void addList(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter name");
                string name = Console.ReadLine();
                Console.WriteLine("enter address");
                string address = Console.ReadLine();
                Console.WriteLine("enter city");
                string city = Console.ReadLine();
                Console.WriteLine("enter state");
                string state = Console.ReadLine();
                Console.WriteLine("enter zip code");
                string zipCode = Console.ReadLine();
                Console.WriteLine("enter phone num");
                string phoneNum = Console.ReadLine();
                Person addressList = new Person(name, address, city, state, zipCode, phoneNum);
                personList.Add(addressList);
            }
        }
        public static void printList()
        {
            for (int i = 0; i < personList.Count; i++)
            {
                Console.WriteLine("Name- " + personList[i].name);
                Console.WriteLine("Address- " + personList[i].address);
                Console.WriteLine("City- " + personList[i].city);
                Console.WriteLine("State- " + personList[i].state);
                Console.WriteLine("Zip code- " + personList[i].zipCode);
                Console.WriteLine("phone num- " + personList[i].phoneNum);
            }
        }
    }
}