using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book ");
            AddNew addNew = new AddNew();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Option \n1. Add Contact\n 2.Edit Contact\n 3.Delete Contact\n 4.Serach using city \n 5.Display City List Or State List \n 6.Get No of Contact by City or State n 7.Sort Dictionary using persons name \n 8.Sort Dictionary by city ,state or Zipcode \n 9.ReadFile \n 10.ReadCSV \n 11.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the number of Address book you want to add");
                        int N = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < N; i++)
                        {
                            addNew.AddToDict();
                        }
                        addNew.DisplayData();
                        break;
                    case 2:
                        Console.WriteLine("Enter UniqueName");
                        string unique = Console.ReadLine();
                        Console.WriteLine("Enter Name");
                        string name = Console.ReadLine();
                        addNew.Edit(name, unique);
                        break;
                    case 3:
                        Console.WriteLine("Enter UniqueName");
                        string unique1 = Console.ReadLine();
                        Console.WriteLine("Enter Name");
                        string name1 = Console.ReadLine();
                        addNew.Delete(name1, unique1);
                        addNew.DisplayData();
                        break;
                    case 4:
                        bool f = true;
                        while (f)
                        {
                            Console.WriteLine("Select an Option \n 1.Search using City \n 2.Search using State \n 3.Exit");
                            int opt = Convert.ToInt32(Console.ReadLine());
                            switch (opt)
                            {
                                case 1:
                                    Console.WriteLine("Enter Name of city");
                                    string city = Console.ReadLine();
                                    addNew.SearchByCity(city);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter Name of state");
                                    string state = Console.ReadLine();
                                    addNew.SearchByState(state);
                                    break;
                                case 3:
                                    f = false;
                                    break;
                            }

                        }

                        break;
                    case 5:
                        bool f2 = true;
                        while (f2)
                        {
                            Console.WriteLine("Select an Option \n 1.Data using City \n 2.Data using State \n 3.Exit");
                            int opt = Convert.ToInt32(Console.ReadLine());
                            switch (opt)
                            {
                                case 1:
                                    addNew.DisplayCity();
                                    break;
                                case 2:
                                    addNew.DisplayState();
                                    break;
                                case 3:
                                    f2 = false;
                                    break;
                            }

                        }
                        break;
                    case 6:
                        bool f3 = true;
                        while (f3)
                        {
                            Console.WriteLine("Select an Option \n 1.Get no of Contact by city \n 2..Get no of Contact by city \n 3.Exit");
                            int opt = Convert.ToInt32(Console.ReadLine());
                            switch (opt)
                            {
                                case 1:
                                    Console.WriteLine("Enter Name of city");
                                    string cityName = Console.ReadLine();
                                    addNew.ByCity(cityName);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter Name of State");
                                    string stateName = Console.ReadLine();
                                    addNew.ByState(stateName);
                                    break;
                                case 3:
                                    f3 = false;
                                    break;
                            }

                        }
                        break;
                    case 7:
                        addNew.SortDict();
                        break;
                    case 8:
                        bool f4 = true;
                        while (f4)
                        {
                            Console.WriteLine("Select an Option \n 1.Sort By City \n 2..Sort by State \n 3.Sort by ZipCode \n 4.Exit");
                            int opt = Convert.ToInt32(Console.ReadLine());
                            switch (opt)
                            {
                                case 1:
                                    addNew.SortCity();
                                    break;
                                case 2:
                                    addNew.SortState();
                                    break;
                                case 3:
                                    addNew.SortZip();
                                    break;
                                case 4:
                                    f4 = false;
                                    break;
                            }

                        }
                        break;
                    case 9:
                        addNew.ReadFile(@"C:\Users\SOURABH\Desktop\Day 3\AddressBook\AddressBook\AddressBookFile.txt");
                        break;
                    case 10:
                        addNew.ReadCSV(@"C:\Users\SOURABH\Desktop\Day 3\AddressBook\AddressBook\Files\Data.csv");
                        break;
                    case 11:
                        flag = false;
                        break;
                      

                }
            }
        }
    }
}