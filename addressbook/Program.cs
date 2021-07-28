using System;

namespace addressbook
{
    class Program
    {
        static void Main(string[] args)
        {   
                AddressDetails address = new AddressDetails("Rithesh", "Menda", "ganjimut,mangalore", "karnataka", 9741932439, 574144, "ritheshmenda123@gmail.com");
                address.Contacts();
         
        }
    }
}
