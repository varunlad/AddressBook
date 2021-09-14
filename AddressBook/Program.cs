using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
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
                    case "A"://Add case
                        Console.WriteLine("Enter First Name: ");
                        firstname = Console.ReadLine();
                        Console.WriteLine("Enter Last Name: ");
                        lastname = Console.ReadLine();
                        Console.WriteLine("Enter Address: ");
                        address = Console.ReadLine();
                        Console.WriteLine("Enter City: ");
                        city = Console.ReadLine();
                        Console.WriteLine("Enter State: ");
                        state = Console.ReadLine();
                        Console.WriteLine("Enter Zip code: ");
                        zipcode = Console.ReadLine();
                        Console.WriteLine("Enter Email Address: ");
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
                }
            }
        }
    }
}
        
    

