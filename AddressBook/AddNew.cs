using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddNew
    {
        Contact contact = new Contact();

        Dictionary<string, List<Contact>> dict = new Dictionary<string, List<Contact>>();
        public Dictionary<string, List<Contact>> city = new Dictionary<string, List<Contact>>();
        public Dictionary<string, List<Contact>> state = new Dictionary<string, List<Contact>>();
        char c = 'A';
        public void Add(int N, string key)
        {
            List<Contact> Data = new List<Contact>();
            for (int i = 0; i < N; i++)
            {

                Contact contact = new Contact();
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
                Data.Add(contact);
                var result2 = Data.Where(x => x.City.Equals(contact.City)).ToList();
                city.Add(contact.City, result2);
                var result3 = Data.Where(x => x.State.Equals(contact.State)).ToList();
                state.Add(contact.State, result3);

            }
            dict.Add(key, Data);
        }

        public void AddToDict()
        {

            Console.WriteLine("Enter how many contacts you want to add");
            int n = Convert.ToInt32(Console.ReadLine());
            string uniqueName = c.ToString();
            foreach (var data in dict)
            {
                if (IsContactExists(uniqueName))
                {
                    data.Value.Add(contact);
                    return;
                }
            }

            Add(n, uniqueName);
            c++;
        }
        public void DisplayCity()
        {
            Console.WriteLine("City Data------------------------>");
            DisplayData(city);
        }
        public void DisplayState()
        {
            Console.WriteLine("State Data----------------------->");
            DisplayData(state);
        }
        public bool IsContactExists(string name)
        {
            foreach (var data in dict)
            {
                if (data.Key.Equals(name))
                {
                    return true;
                }

            }
            return false;
        }
        public void SearchByCity(string city)
        {

            foreach (var data in dict)
            {
                foreach (var item in data.Value)
                {
                    if (item.City.Equals(city))
                    {
                        Console.WriteLine("First Name :" + item.FirstName + "\n" + "Last Name :" + item.LastName + "\n" + "Address :" + item.Address + "\n" + "City :" + item.City + "\n" + "State :" + item.State + "\n" + "Zip Code :" + item.zip + "\n" + "Phone Number :" + item.PhoneNumber + "\n" + "Mail Id :" + item.Email);
                    }
                }
            }

        }
        public void SearchByState(string state)
        {

            foreach (var data in dict)
            {
                foreach (var item in data.Value)
                {
                    if (item.City.Equals(state))
                    {
                        Console.WriteLine("First Name :" + item.FirstName + "\n" + "Last Name :" + item.LastName + "\n" + "Address :" + item.Address + "\n" + "City :" + item.City + "\n" + "State :" + item.State + "\n" + "Zip Code :" + item.zip + "\n" + "Phone Number :" + item.PhoneNumber + "\n" + "Mail Id :" + item.Email);
                    }
                }
            }

        }
        public void DisplayData(Dictionary<string, List<Contact>> dict)
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

        public void Edit(string name, string uniquename)
        {
            Console.WriteLine("Edit Using First Name");

            foreach (var item in dict)
            {
                if (item.Key.Equals(uniquename))
                {
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
                                    DisplayData();
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

            }


        }

        public void Delete(string name, string uniquename)
        {
            Contact contact = new Contact();

            foreach (var item in dict)
            {
                if (item.Key.Equals(uniquename))
                {
                    foreach (var data in item.Value)
                    {
                        if (data.FirstName == name)
                        {
                            contact = data;
                        }
                        item.Value.Remove(data);
                    }
                }
            }
            if (contact == null)
            {
                Console.WriteLine("No contact exists with respect to firstname");
            }
        }
    }
}