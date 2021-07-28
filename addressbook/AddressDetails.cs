using System;
using System.Collections.Generic;
using System.Text;

namespace addressbook
{
    class AddressDetails
    {
        string Name, Lastname, Address, State, Emailid;
        int Zipcode;
        long Mobile;
        public AddressDetails(string name, string lastname, string address, string state, long mobile, int zipcode, string emailid)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Address = address;
            this.State = state;
            this.Mobile = mobile;
            this.Zipcode = zipcode;
            this.Emailid = emailid;
        }
        public void Contacts()
        {
            Console.WriteLine("Name : " + this.Name + "\n" + "last name : " + this.Lastname + "\n" + "address :" + this.Address + "\n" + "state : " + this.State + "\n" + "Mobile :" + this.Mobile + "\n"+"zipcode : "+this.Zipcode+"\n"+"emailid : "+this.Emailid);
        }
    }
}
