using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static List<Customer> customerList = new List<Customer>();

        static void Main(string[] args)
        {

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
                    Console.WriteLine("ERROERER");
                     }
            }

        }

        public static void AddCustomer()        // Lägger till en customer med namn i listan med customers
        {
            Console.WriteLine("Skriv kundens Namn: ");
            string newCustomer = Console.ReadLine();
            Customer Customer = new Customer();
            Customer.name = newCustomer;
            customerList.Add(Customer);

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









