using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddNew
    {
        Contact contact = new Contact();
        public void Add()
        {
            Console.WriteLine("Enter First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter zip");
            contact.zip = Console.ReadLine();
            Console.WriteLine("Enter PhoneNumber");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter email");
            contact.Email = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("First Name :"+contact.FirstName+"\n"+"Last Name :"+contact.LastName+"\n"+"Address :"+ contact.Address+"\n"+"City :"+ contact.City + "\n" +"State :"+ contact.State +"\n" +"Zip Code :"+ contact.zip +"\n" +"Phone Number :"+ contact.PhoneNumber + "\n" +"Mail Id :"+ contact.Email);
        }
    }
}
