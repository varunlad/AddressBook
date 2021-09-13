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
        static void Main()
        {
            Console.WriteLine("Welcome to my address book program");
            Console.WriteLine("*****************************");
            Console.WriteLine("Make a choice \n 1)Enter Details \n2)Add Details");

            switch (Console.ReadLine())
            {
                case "1": // Check if user entered 1.
                    Console.Clear(); // Clear the console screen.
                    Console.WriteLine("Enter Details");
                    EnterDetails();// Write you add "program" here.
                    break; // Stop the switch loop.
                case "2":
                    Console.WriteLine("Remove");
                    break;
                default: // If user didn't enter 1 or 2 his choice isn't valid. Show a message.
                    Console.WriteLine("The choice you made isn't valid, please try again.");
                    break;
            }
        }
                      public static void EnterDetails()
            {
                Console.WriteLine("Please Enter your Firstname");
                string str1 = "Firstname";
                str1 = Console.ReadLine();
                string valueString1 = str1;

                Console.WriteLine("Please Enter your Lastname");
                string str2 = "Lastname";
                str2 = Console.ReadLine();
                string valueString2 = str2;

                Console.WriteLine("Please Enter your Address");
                string str3 = "Address";
                str3 = Console.ReadLine();
                string valueString3 = str3;

                Console.WriteLine("Please Enter your state");
                string str5 = "state";
                str5 = Console.ReadLine();
                string valueString5 = str5;

                Console.WriteLine("Please Enter your Pincode");
                string str6 = "Pincode";
                str6 = Console.ReadLine();
                string valueString6 = str6;

                Console.WriteLine("Here is a list of the stored names and addresees that you have entered so far");
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("Lastname you entered: " + valueString2);
                Console.WriteLine("Firstname you entered: " + valueString1);
                Console.WriteLine("Address and house number and town you entered: " + valueString3);
                Console.WriteLine("County you entered: " + valueString5);
                Console.WriteLine("Postcode you entered: " + valueString6);
                Console.ReadLine();


                      }
    }
}
        
    

