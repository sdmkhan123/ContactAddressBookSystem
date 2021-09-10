using System;
using System.Collections.Generic;
using System.Text;

namespace ContactAddressBookSystem
{
    public class Person
    {
        //declare member data
        private string name;
        private string address;
        private string city;
        private string state;
        private string zipCode;
        private string phoneNum;
        //paramerized constructor to define member data
        public Person(string name, string address, string city, string state, string zipCode, string phoneNum)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNum = phoneNum;
        }
        //creats the list which store the data of type class Person
        private static List<Person> personList = new List<Person>();
        //add contacts in empty add book of type list
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
        // adding new contact to addr book
        public static void addNewContact(string name, string address, string city, string state, string zipCode, string phoneNum)
        {
            Person addressList = new Person(name, address, city, state, zipCode, phoneNum);
            personList.Add(addressList);
        }
        static public void enditContactName(string changeNaame)
        {
            int ind = -1;
            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].name == changeNaame)
                {
                    ind = i;
                }
            }
            Person newUp = personList[ind];
            newUp.name = "SDMKHAN";
            personList[ind] = newUp;
        }

        //print the present contacts in addr book
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