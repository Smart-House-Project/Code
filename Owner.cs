using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public class Owner:User
    {
        public Owner(string name, int phoneNumber, int password, string email) :base(name, phoneNumber, password, email)
        { 
        
        }
        public Owner() { }
        public override void CreateAccount()
        {
            base.CreateAccount();
            Console.WriteLine("You as the owner have FULL ACCESS to the Smart House system!");
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
                Console.WriteLine("1.Remote monitoring");
                Console.WriteLine("2.Security system");
                Console.WriteLine("3.Access control");
                Console.WriteLine("4.Control of electrical appliances");
                Console.WriteLine("5.Temperature control");
                Console.WriteLine("6.Media control");
                Console.WriteLine("7.Lighting control");
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
                            Console.WriteLine("1.Real-time monitoring of the backup device status");
                            Console.WriteLine("2.Back to the main menu");
                            answer = int.Parse(Console.ReadLine());
                            if (answer == 1) { }
                            else { break; }
                        }
                        break;
                    case 2:
                        while (true)
                        {
                            Console.WriteLine("What exactly are you interested in?");
                            Console.WriteLine("1.Motion alerts");
                            Console.WriteLine("2.Alarm activation/deactivation");
                            Console.WriteLine("3.Monitoring of cameras");
                            Console.WriteLine("4.Back to the main menu");
                            answer =int.Parse(Console.ReadLine());
                            if (answer == 4) break;
                            switch (answer)
                            {
                                case 1: break;
                                case 2: break;
                                case 3: break;

                            }
                        }
                        break;

                    case 3:
                        while (true)
                        {
                            Console.WriteLine("What exactly are you interested in?");
                            Console.WriteLine("1.Access control for guests");
                            Console.WriteLine("2.Remote door opening/closing");
                            Console.WriteLine("3.Face recognition");
                            Console.WriteLine("4.Back to the main menu");
                            answer  = int.Parse(Console.ReadLine());
                            if (answer == 4) break;
                            switch (answer)
                            {
                                case 1: break;
                                case 2: break;
                                case 3: break;

                            }
                        }
                        break;
                    case 4:
                        while (true)
                        {
                            Console.WriteLine("What exactly are you interested in?");
                            Console.WriteLine("1.Switching appliances on/off");
                            Console.WriteLine("2.Сontrol of energy consumption");
                            Console.WriteLine("3.Back to the main menu");
                            answer  = int.Parse(Console.ReadLine());
                            if (answer == 3) break;
                            switch (answer)
                            {
                                case 1: break;
                                case 2: break;
                            }
                        }
                        break;
                    case 5:
                        while (true)
                        {
                            Console.WriteLine("What exactly are you interested in?");
                            Console.WriteLine("1.Setting the temperature");
                            Console.WriteLine("2.Air conditioning and heater control");
                            Console.WriteLine("3.Back to the main menu");
                            answer  = int.Parse(Console.ReadLine());
                            if(answer==3) break;
                            switch (answer)
                            {
                                case 1: break;
                                case 2: break;
                            }
                        }
                        break;
                    case 6:
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
                    case 7:
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

                }
            }
        }
    }
}
