using System;
using System.Collections.Generic;
using System.Text;

namespace ContactAddressBookSystem
{
    public class Person
    {
        //declare member data
        private string Name;
        private string address;
        private string city;
        private string state;
        private string zipCode;
        private string phoneNum;
        //paramerized constructor to define member data
        public Person(string name, string address, string city, string state, string zipCode, string phoneNum)
        {
            this.Name = name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNum = phoneNum;
        }
        //creats the list which store the object of type class Person
        private static List<Person> personList = new List<Person>();
<<<<<<< HEAD
=======
        //creats the Dictionary which store the name and object of type class Person
>>>>>>> UcSix_addMultipleAddrBookUsingDictionary
        private static Dictionary<string, Person> addressBookMap = new Dictionary<string, Person>();
        //add contacts in empty add book of type list
        public static void addList()
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
            /*
                listcontacts.Add(new Person()
                {
                    name = name
                    address = address,
                    city = city,
                    state = state,
                    zip = zip,
                    phoneNum = phoneNum,
                });
             */
            //if condition to check the key is present or not in dictionary
            if (!addressBookMap.ContainsKey(name))
            {
                //if not then add into the addressbookMap Dictionary
                addressBookMap.Add(name, addressList);
            }
        }
        static public void enditContactName(string name, string changeNaame)
        {
            int ind = -1;
            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].Name == name)
                {
                    ind = i;
                }
            }
            Person newUp = personList[ind];
            newUp.Name = changeNaame;
            personList[ind] = newUp;
            addressBookMap[personList[ind].Name] = newUp;
        }


        static public void Delete(string deleteContact)
        {
            int ind = -1;
            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].Name == deleteContact)
                {
                    ind = i;
                }
            }
            if (ind > -1)
            {
                personList.RemoveAt(ind);
                addressBookMap.Remove(deleteContact);
                //(personList[ind].Name)
            }
        }
        //print the present contacts in addr book
        public static void printList()
        {
            for (int i = 0; i < personList.Count; i++)
            {
                Console.WriteLine("Name- " + personList[i].Name);
                Console.WriteLine("Address- " + personList[i].address);
                Console.WriteLine("City- " + personList[i].city);
                Console.WriteLine("State- " + personList[i].state);
                Console.WriteLine("Zip code- " + personList[i].zipCode);
                Console.WriteLine("phone num- " + personList[i].phoneNum);
            }
        }
        public static void printDictioanry(string name)
        {
            Console.WriteLine("print the Name of a person - " + addressBookMap[name].Name);
            Console.WriteLine("print the Address of a person - " + addressBookMap[name].address);
            Console.WriteLine("print the City of a person - " + addressBookMap[name].city);
            Console.WriteLine("print the State of a person - " + addressBookMap[name].state);
            Console.WriteLine("print the Zip code of a person - " + addressBookMap[name].zipCode);
            Console.WriteLine("print the phone num of a person - " + addressBookMap[name].phoneNum);
        }
    }
}