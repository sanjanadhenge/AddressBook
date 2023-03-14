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
            Console.WriteLine("Enter the number of contacts to add");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                addNew.Add();
                addNew.Display();
            }
            addNew.Edit();
            addNew.Delete();
            addNew.Display();


        }
    }
}
