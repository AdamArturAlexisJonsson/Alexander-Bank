using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank
{
    class Program
    {
        public static List<Customer> customerList = new List<Customer>();
        public static string filename = @"C:\Users\alexlind\source\repos\Bank1\Bank1\test.txt";

        static void Main(string[] args)
        {
            //string filename = @"C:\Users\alexlind\source\repos\Bank1\Bank1\test.txt";
            //ReadFile(filename);


            //knas
            Console.WriteLine("Vällkommen!");
            Console.WriteLine("");
            Console.WriteLine("Ange vilket av följande alternativ du önskar göra");
            Console.WriteLine("");
            Console.WriteLine("1. Lägg till användare");
            Console.WriteLine("2. Ta bort användare");
            Console.WriteLine("3. Visa alla befintiliga användare");
            Console.WriteLine("7. Avsluta programmet");
            Console.WriteLine("");
            Console.WriteLine("Skriv ditt val: ");

            int choice = 0;

            try{
            choice = int.Parse(Console.ReadLine());
                }

            catch(FormatException e) {
                Console.WriteLine("Ett error " + e.Message);
                }                

            while (choice != 7)
            {

                switch (choice)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        RemoveCustomer();
                        break;
                    case 3:
                        foreach (Customer info in customerList)     // Skriver ut varje customer i listan
                        {
                            Console.WriteLine(info.customerInfo());
                        }

                        break;
           
                    case 7:
                        Console.WriteLine("Case 7");
                        //WriteFile(filename);
                       // string save = customerInfo;
                        //System.IO.File.WriteAllText(@"C: \Users\alexlind\source\repos\Bank1\Bank1\test.txt");
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }
                Console.WriteLine("Skriv ditt val: ");
                
                try{
                choice = int.Parse(Console.ReadLine());
                    }

                catch(FormatException){
                    Console.WriteLine("ERROR");
                     }
            }

        }

        public static void WriteFile(string filename, string name)
        {
            File.WriteAllText(filename, name);
        }
        public static void ReadFile(string filename, string name)
        {
            string readFile = File.ReadAllText(filename);
            foreach (var customer in customerList)
            {
                Console.WriteLine(readFile);
            }
        }

        public static void AddCustomer()        // Lägger till en customer med namn i listan med customers
        {
            Console.WriteLine("Skriv kundens Namn: ");
            string newCustomer = Console.ReadLine();
            Customer Customer = new Customer();
            Customer.name = newCustomer;
            customerList.Add(Customer);
            WriteFile(filename, Customer.name);

        }

        public static void RemoveCustomer() // Taggar den customer man skriver in och tar sedan bort den
        {
            Console.WriteLine("Skriv kundens namn: ");
            string customerToDelete = Console.ReadLine();
            Customer objectToDelete = null;
            foreach (Customer info in customerList)
            {
                if (info.name == customerToDelete)
                    objectToDelete = info;

            }
            customerList.Remove(objectToDelete);
        }



    }
}









