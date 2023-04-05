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
                Console.WriteLine("Select Option \n1. Add Contact\n 2. Edit Contact\n 3. Delete Contact\n 4.Exit\n");
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
                       addNew.Display();
                        break;
                    case 2:
                        addNew.Edit();
                        break;
                    case 3:
                        addNew.Delete();
                        addNew.Display();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
