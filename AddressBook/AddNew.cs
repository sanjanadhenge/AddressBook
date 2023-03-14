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
            Console.WriteLine("First Name :" + contact.FirstName + "\n" + "Last Name :" + contact.LastName + "\n" + "Address :" + contact.Address + "\n" + "City :" + contact.City + "\n" + "State :" + contact.State + "\n" + "Zip Code :" + contact.zip + "\n" + "Phone Number :" + contact.PhoneNumber + "\n" + "Mail Id :" + contact.Email);
        }
        public void Edit()
        {
            Console.WriteLine("Select Option to edit Contct details \n 1. Edit First Name \n 2.Edit Last Name \n 3.Edit Address \n 4.Edit City \n 5.Edit State \n 6. Zip \n 7. Edit Phone Number \n 8. Edit Email ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine("Enter First Name");
                    contact.FirstName = Console.ReadLine();
                    Display();
                    break;
                case 2:
                    Console.WriteLine("Enter last Name");
                    contact.LastName = Console.ReadLine();
                    Display();
                    break;
                case 3:
                    Console.WriteLine("Enter Address");
                    contact.Address = Console.ReadLine();
                    Display();
                    break;
                case 4:
                    Console.WriteLine("Enter City");
                    contact.City = Console.ReadLine();
                    Display();
                    break;
                case 5:
                    Console.WriteLine("Enter State");
                    contact.State = Console.ReadLine();
                    Display();
                    break;
                case 6:
                    Console.WriteLine("Enter Zip Code");
                    contact.zip = Console.ReadLine();
                    Display();
                    break;
                case 7:
                    Console.WriteLine("Enter Phone Number");
                    contact.PhoneNumber = Console.ReadLine();
                    Display();
                    break;
                case 8:
                    Console.WriteLine("Enter Mail Id");
                    contact.Email = Console.ReadLine();
                    Display();
                    break;


            }
        }
    }
}
