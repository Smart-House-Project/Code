using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartHouse
{
    public class Guest : User
    {
        public Guest(string name, int phoneNumber, int password, string email) : base(name, phoneNumber, password, email)
        {

        }
        public Guest() { }
        public override void CreateAccount()
        {
            base.CreateAccount();
            Console.WriteLine("You as the guest have PARTIAL ACCESS to the Smart House system!");
        }
        public override void LoginToAccount()
        {
            base.LoginToAccount();
        }
        public override void AvailableServices()
        {
            while (true)
            {
                Console.WriteLine("Here are all the services offered by the Smart house system:");
                Console.WriteLine("0.Exit from the system");
                Console.WriteLine("1.Lighting control");
                Console.WriteLine("2.Media control");
                Console.WriteLine("What do you want to choose?");
                int choice = int.Parse(Console.ReadLine());
                int answer;
                switch (choice)
                {
                    case 0: break;
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("What exactly are you interested in?");
                            Console.WriteLine("1.Switching the light on/off");
                            Console.WriteLine("2.Adjusting the brightness");
                            Console.WriteLine("3.Schedule settings");
                            Console.WriteLine("4.Back to the main menu");
                            answer  = int.Parse(Console.ReadLine());
                            if (answer==4) break;
                            switch (answer)
                            {
                                case 1: break;
                                case 2: break;
                                case 3: break;

                            }
                        }
                        break;
                    case 2:
                        while (true)
                        {
                            Console.WriteLine("What exactly are you interested in?");
                            Console.WriteLine("1.Play music and videos ");
                            Console.WriteLine("2.Control your TV");
                            Console.WriteLine("3.Back to the main menu");
                            answer  = int.Parse(Console.ReadLine());
                            if (answer==3) break;
                            switch (answer)
                            {
                                case 1: break;
                                case 2: break;


                            }
                        }
                        break;
                }

            }
        }

    }
}
