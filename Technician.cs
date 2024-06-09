using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public class Technician:User
    {
        public Technician() { }
        public Technician(string name, int phoneNumber, int password, string email) : base(name, phoneNumber, password, email)
        {
        }
        public override void CreateAccount()
        {
            base.CreateAccount();
            Console.WriteLine("You as the technician have FULL ACCESS to the Smart House system!");
        }
        public override void LoginToAccount()
        {
            base.LoginToAccount();
        }
    }
}
