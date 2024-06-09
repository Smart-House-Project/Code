using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{

    public abstract class User
    {
        string name;
        int phoneNumber;
        int password;
        string email;
        public User(string name, int phoneNumber, int password, string email)
        {
            this.name=name;
            this.phoneNumber=phoneNumber;
            this.password=password;
            this.email=email;
        }
        public User() { }
        public string Name
        { 
        get 
            { 
                return name; 
            }
        set
            {
                name = value;
            }
        }
        public int PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        public int Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public virtual void CreateAccount()
        {
           
                Console.WriteLine("Create an account:");
                Console.WriteLine("Input your name and surname:");
                name = Console.ReadLine();
                Console.WriteLine("Input your phone number:");
                phoneNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Input your email:");
                email = Console.ReadLine();
                Console.WriteLine("Create your password:");
                password = int.Parse(Console.ReadLine());
                Console.WriteLine("Account created successfully!");
           
        }
        public virtual void LoginToAccount()
        {
                Console.WriteLine("Log in to my account:");
                Console.WriteLine("Input your name and surname");
                name = Console.ReadLine();
                Console.WriteLine("Input your password:");
                password = int.Parse(Console.ReadLine());
                Console.WriteLine("You have successfully logged in to your account!");
          
        }
        public virtual void AvailableServices()
        {

        }

    }
}