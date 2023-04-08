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
                Console.WriteLine("Select Option \n 1.Add Contact \n 2.Edit Contact \n 3.Delete Contact \n 4.Search Using City \n 5.Display City List Or State List \n 6.Get No of Contact by City or State");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the number of contacts to add");
                        int N = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < N; i++)
                        {
                            addNew.Add();
                        }
                      addNew.DisplayDict();
                        break;
                    case 2:
                        addNew.Edit();
                        break;
                    case 3:
                        addNew.Delete();
                        addNew.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Name of city");
                        string city = Console.ReadLine();
                        addNew.SearchByCity(name, city);
                        break;
                    case 5:
                        bool f = true;
                        while(f)
                        {
                            Console.WriteLine("Select an Option \n 1.Data using City \n 2.Data using State \n 3.Exit");
                            int opt = Convert.ToInt32(Console.ReadLine());
                            switch(opt)
                            {
                                case 1:
                                    addNew.DisplayCity();
                                    break;
                                case 2:
                                    addNew.DisplayState();
                                    break;
                                case 3:
                                    f= false;
                                    break;
                            }

                        }
                       

                        break;
                    case 6:
                        bool f2 = true;
                        while (f2)
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
                                    f2 = false;
                                    break;
                            }

                        }
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}
