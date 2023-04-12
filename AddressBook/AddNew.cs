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
        List<Contact> Data = new List<Contact>();
        Dictionary<string, List<Contact>> dict = new Dictionary<string, List<Contact>>();
        int f;
        public void Add()
        {

            Contact contact = new Contact();
            Console.WriteLine("Enter First Name");
            contact.FirstName = Console.ReadLine();
            int f = CheckUnique(contact.FirstName);
            int flag2 = checkDulpicate(contact.FirstName);
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
            if (f == 0 && flag2 == 0)
            {
                Data.Add(contact);
                var result1 = Data.Where(x => x.FirstName.Equals(contact.FirstName)).ToList();
                dict.Add(contact.FirstName, result1);
            }


        }
        public int CheckUnique(string name)
        {
            int flag = 0;
            if (dict.Count != 0)
            {
                foreach (var data in dict)
                {
                    foreach (var item in data.Value)
                    {

                        if (data.Key.Equals(name))
                        {
                            Console.WriteLine("The Name you have enterd is already present");
                            flag = 1;
                            break;

                        }

                    }
                }

            }
            return flag;
        }
        public int checkDulpicate(string name)
        {
            int flag2 = 0;
            if (dict.Count != 0)
            {
                var result = dict.Where(x => x.Key.Equals(name));
                if (name.Equals(result))
                {
                    Console.WriteLine("Dupilcate is present");
                    flag2 = 1;
                }
            }
            return flag2;
        }
        public void SearchByCity(string firstName, string city)
        {
            foreach (var data in dict)
            {
                if (data.Key.Equals(firstName))
                {
                    var cityList = data.Value.Where(x => x.City.Equals(city)).ToList();
                    foreach (var item in cityList)
                    {
                        Console.WriteLine("First Name :" + item.FirstName + "\n" + "Last Name :" + item.LastName + "\n" + "Address :" + item.Address + "\n" + "City :" + item.City + "\n" + "State :" + item.State + "\n" + "Zip Code :" + item.zip + "\n" + "Phone Number :" + item.PhoneNumber + "\n" + "Mail Id :" + item.Email);
                    }
                }
            }

        }
        public void DisplayData()
        {
            foreach (var data in dict)
            {
                Console.WriteLine("Key------------>" + data.Key);
                foreach (var item in data.Value)
                {
                    Console.WriteLine("First Name :" + item.FirstName + "\n" + "Last Name :" + item.LastName + "\n" + "Address :" + item.Address + "\n" + "City :" + item.City + "\n" + "State :" + item.State + "\n" + "Zip Code :" + item.zip + "\n" + "Phone Number :" + item.PhoneNumber + "\n" + "Mail Id :" + item.Email);
                }


            }
        }
        public void Display()
        {
            foreach (var data in Data)
            {
                Console.WriteLine("First Name :" + contact.FirstName + "\n" + "Last Name :" + contact.LastName + "\n" + "Address :" + contact.Address + "\n" + "City :" + contact.City + "\n" + "State :" + contact.State + "\n" + "Zip Code :" + contact.zip + "\n" + "Phone Number :" + contact.PhoneNumber + "\n" + "Mail Id :" + contact.Email);
            }
        }
        public void Edit()
        {
            Console.WriteLine("Edit Using First Name");
            string name = Console.ReadLine();
            foreach (var item in dict)

                foreach (var data in item.Value)
                {
                    if (data.FirstName == name)
                    {
                        Console.WriteLine("Select Option to edit Contct details \n 1. Edit First Name \n 2.Edit Last Name \n 3.Edit Address \n 4.Edit City \n 5.Edit State \n 6. Zip \n 7. Edit Phone Number \n 8. Edit Email ");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter First Name");
                                contact.FirstName = Console.ReadLine();
                                DisplayData();
                                break;
                            case 2:
                                Console.WriteLine("Enter last Name");
                                contact.LastName = Console.ReadLine();
                                DisplayData();
                                break;
                            case 3:
                                Console.WriteLine("Enter Address");
                                contact.Address = Console.ReadLine();
                                Display();
                                break;
                            case 4:
                                Console.WriteLine("Enter City");
                                contact.City = Console.ReadLine();
                                DisplayData();
                                break;
                            case 5:
                                Console.WriteLine("Enter State");
                                contact.State = Console.ReadLine();
                                DisplayData();
                                break;
                            case 6:
                                Console.WriteLine("Enter Zip Code");
                                contact.zip = Console.ReadLine();
                                DisplayData();
                                break;
                            case 7:
                                Console.WriteLine("Enter Phone Number");
                                contact.PhoneNumber = Console.ReadLine();
                                DisplayData();
                                break;
                            case 8:
                                Console.WriteLine("Enter Mail Id");
                                contact.Email = Console.ReadLine();
                                DisplayData();
                                break;


                        }
                    }
                }

        }

        public void Delete()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter First Name To delete Contact");
            string name = Console.ReadLine();
            foreach (var item in dict)
            {
                foreach (var data in item.Value)
                {
                    if (data.FirstName.Equals(name))
                    {
                        contact = data;
                    }

                }
                Data.Remove(contact);
            }

        }

    }
}