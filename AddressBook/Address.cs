using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Address
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string email { get; set; }

        public Address(string firstname, string lastname, string address, string city, string state, string zipcode, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.email = email;
        }

    }
}
