using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {
        List<Address> addresses;


        public AddressBook()
        {
            addresses = new List<Address>();
        }

        public bool add(string firstname, string lastname, string address, string city, string state, string zipcode, string email)
        {
            Address addr = new Address(firstname, lastname, address, city, state, zipcode, email);
            Address result = find(firstname);

            if (result == null)
            {
                addresses.Add(addr);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool remove(string name)
        {
            Address addr = find(name);

            if (addr != null)
            {
                addresses.Remove(addr);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void list(Action<Address> action)
        {
            addresses.ForEach(action);
        }

        public bool isEmpty()
        {
            return (addresses.Count == 0);
        }

        public Address find(string name)
        {
            Address addr = addresses.Find((a) => a.firstname == name);
            return addr;
        }

        public Address Search(string name)
        {
            Address addr = addresses.Find((a) => a.city == name);
            return addr;
        }
    }
}
