using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook
{


    class AddressPrompt
    {
        AddressBook book;

        public AddressPrompt()
        {
            book = new AddressBook();
        }

        static void Main(string[] args)
        {
            string selection = "";
            AddressPrompt prompt = new AddressPrompt();

            prompt.displayMenu();
            while (!selection.ToUpper().Equals("Q"))
            {
                Console.WriteLine("Selection: ");
                selection = Console.ReadLine();
                prompt.performAction(selection);
            }
        }

        void displayMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("=========");
            Console.WriteLine("A - Add an Address");
            Console.WriteLine("D - Delete an Address");
            Console.WriteLine("E - Edit an Address");
            Console.WriteLine("L - List All Addresses");
            Console.WriteLine("S - Search an Address");
            Console.WriteLine("Q - Quit");
        }

        void performAction(string selection)
        {
            string firstname = "";
            string lastname = "";
            string address = "";
            string city = "";
            string state = "";
            string zipcode = "";
            string email = "";

            switch (selection.ToUpper())
            {
                case "A":
                    Console.Write("Enter First Name: ");
                    firstname = Console.ReadLine();
                    Console.Write("Enter Last Name: ");
                    lastname = Console.ReadLine();
                    Console.Write("Enter Address: ");
                    address = Console.ReadLine();
                    Console.Write("Enter City: ");
                    city = Console.ReadLine();
                    Console.Write("Enter State: ");
                    state = Console.ReadLine();
                    Console.Write("Enter Zip code: ");
                    zipcode = Console.ReadLine();
                    Console.Write("Enter Email Address: ");
                    email = Console.ReadLine();
                    if (book.add(firstname, lastname, address, city, state, zipcode, email))
                    {
                        Console.WriteLine("Address successfully added!");
                    }
                    else
                    {
                        Console.WriteLine("An address is already on file for {0}.", firstname);
                    }
                    break;
                case "D":
                    Console.WriteLine("Enter Name to Delete: ");
                    firstname = Console.ReadLine();
                    if (book.remove(firstname))
                    {
                        Console.WriteLine("Address successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Address for {0} could not be found.", firstname);
                    }
                    break;
                case "L":
                    if (book.isEmpty())
                    {
                        Console.WriteLine("There are no entries.");
                    }
                    else
                    {
                        Console.WriteLine("Addresses:");
                        //book.list((a) => Console.WriteLine("{0} - {1}", a.firstname,a.lastname,a.address,a.city,a.state,a.zipcode,a.email));
                        //We use a lambda expression to create an anonymous function. Use the lambda declaration operator => to separate the lambda's parameter list from its body. //
                        book.list((a) => Console.WriteLine("First Name - " + a.firstname));
                        book.list((a) => Console.WriteLine("Last Name -" + a.lastname));
                        book.list((a) => Console.WriteLine("Address -" + a.address));
                        book.list((a) => Console.WriteLine("City -" + a.city));
                        book.list((a) => Console.WriteLine("State -" + a.state));
                        book.list((a) => Console.WriteLine("ZipCode -" + a.zipcode));
                        book.list((a) => Console.WriteLine("Email -" + a.email));
                        Console.WriteLine("================");
                    }
                    break;
                case "E":
                    Console.WriteLine("Enter Name to Edit: ");
                    firstname = Console.ReadLine();
                    Address addr = book.find(firstname);
                    if (addr == null)
                    {
                        Console.WriteLine("Address for {0} count not be found.", firstname);
                    }
                    else
                    {
                        Console.WriteLine("Enter new Address: ");
                        addr.address = Console.ReadLine();
                        Console.WriteLine("Address updated for {0}", firstname);
                    }
                    break;
                case "S":
                    Console.WriteLine("Search an Address by city");
                    city = Console.ReadLine();
                    Address addrs = book.Search(city);
                    if (addrs != null)
                    {
                        Console.WriteLine("First Name - " + addrs.firstname);
                        Console.WriteLine("Last Name -" + addrs.lastname);
                        Console.WriteLine("Address -" + addrs.address);
                        Console.WriteLine("City -" + addrs.city);
                        Console.WriteLine("State -" + addrs.state);
                        Console.WriteLine("ZipCode -" + addrs.zipcode);
                        Console.WriteLine("Email -" + addrs.email);
                        //book.list((a) => Console.WriteLine("First Name - " + a.firstname));
                        //book.list((a) => Console.WriteLine("Last Name -" + a.lastname));
                        //book.list((a) => Console.WriteLine("Address -" + a.address));
                        //book.list((a) => Console.WriteLine("City -" + a.city));
                        //book.list((a) => Console.WriteLine("State -" + a.state));
                        //book.list((a) => Console.WriteLine("ZipCode -" + a.zipcode));
                        //book.list((a) => Console.WriteLine("Email -" + a.email));
                    }
                    break;
            }
        }


    }
}




