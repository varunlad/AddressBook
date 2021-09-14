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
        /// <summary>
        /// Adding All the Entries.
        /// Adds the specified firstname.
        /// </summary>
        /// <param name="firstname">The firstname.</param>
        /// <param name="lastname">The lastname.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipcode">The zipcode.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
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

    }
}
