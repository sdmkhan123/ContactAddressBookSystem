using System;

namespace ContactAddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Contact Address Book System");
            Person person1 = new Person("name", "address", "city", "state", "zipCode", "phoneNum");
            Console.WriteLine("enter numm of iteration ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                Console.WriteLine("Please enter zero option number to exit ");
                Console.WriteLine("otherwise enter other than zero option number ");
                int options = Convert.ToInt32(Console.ReadLine());
                if (options == 0)
                    break;
                switch (options)
                {
                    case 1:
                        //create initial addr book with some contact addr
                            Person.addList();
                        break;
                    case 2:
                        //add multiple person to addr book one by one with some contact addr
                        Console.WriteLine("Enter multple Person to be added with one by one ");
                        int multiplePerson = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < multiplePerson; i++)
                        {
                            Person.addList();
                        }
                        break;
                    case 3:
                        //Call func to edit contact name
                        Console.WriteLine("with what you replace it ");
                        string changeName = Console.ReadLine();
                        Console.WriteLine("enter name of that contact ");
                        string name = Console.ReadLine();
                        Person.enditContactName(name, changeName);
                        break;
                    case 4:
                        //Delete a contact addr from addr book
                        Console.WriteLine("Enter the Contact name which you want to delete ");
                        string delName = Console.ReadLine();
                        Person.Delete(delName);
                        break;
                    case 5:
                        //print presnt contact in addr book
                        Person.printList();
                        break;
                    default:
                        Console.WriteLine("Please enter correct option");
                        break;
                }
                n--;

            }
        }
    }
}