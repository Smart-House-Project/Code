using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your role:");
            Console.WriteLine("1.Owner");
            Console.WriteLine("2.Guest");
            Console.WriteLine("3.Technician");
            int choice=int.Parse(Console.ReadLine());
            string answer;
            if (choice == 1)
            {
                Owner owner = new Owner();
                Console.WriteLine("Are you logged in to the system?(yes, no)");
                answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    owner.LoginToAccount();
                }
                else { owner.CreateAccount(); }
                owner.AvailableServices();
            }
            else if (choice == 2)
            {
                Guest guest = new Guest();
                Console.WriteLine("Are you logged in to the system?(yes, no)");
                answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    guest.LoginToAccount();
                }
                else { guest.CreateAccount(); }
                guest.AvailableServices();
            }
            else
            {
                Technician technician = new Technician();
            }
        }
    }
}
