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
                    case "D"://Deleting case
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
                    case "L"://listing case
                        if (book.isEmpty())
                        {
                            Console.WriteLine("There are no entries.");
                        }
                        else
                        {
                            Console.WriteLine("Addresses:");
                            book.list((a) => Console.WriteLine("First Name - ", a.firstname));
                            book.list((a) => Console.WriteLine("Last Name -" + a.lastname));
                            book.list((a) => Console.WriteLine("Address -" + a.address));
                            book.list((a) => Console.WriteLine("City -" + a.city));
                            book.list((a) => Console.WriteLine("State -" + a.state));
                            book.list((a) => Console.WriteLine("ZipCode -" + a.zipcode));
                            book.list((a) => Console.WriteLine("Email -" + a.email));
                            Console.WriteLine("================");
                        }
                        break;
                    case "E"://Editing case
                        Console.WriteLine("Enter Name to Edit: ");
                        firstname = Console.ReadLine();
                        Address addr = book.find(firstname);
                        if (addr == null)
                        {
                            Console.WriteLine("Address for {0} count not be found.", firstname);
                        }
                        else
                        {
                            Console.WriteLine("Address updated for {0}", firstname);
                            Console.WriteLine("Enter new Address: ");
                            addr.address = Console.ReadLine();
                            Console.WriteLine("Enter new city: ");
                            addr.city = Console.ReadLine();
                            Console.WriteLine("Enter new state: ");
                            addr.state = Console.ReadLine();
                            Console.WriteLine("Enter new zipcode: ");
                            addr.zipcode = Console.ReadLine();
                            Console.WriteLine("Enter new Email: ");
                            addr.email = Console.ReadLine();
                        }
                        break;
                }
            
            }
        }
    }
}
        
    

