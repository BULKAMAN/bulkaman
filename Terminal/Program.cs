using System;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Log in");
            Console.WriteLine("Username:");
            string logname = Console.ReadLine();
            Console.WriteLine("Password:");
            string logpass = Console.ReadLine();
            Console.WriteLine("Registration is complete.");
            Console.WriteLine("Sign up");
            Console.WriteLine("Username:");
            string Name = Console.ReadLine();
            Console.WriteLine("Password:");
            string Password = Console.ReadLine();
            if (logname == Name && logpass == Password)
            {
                Console.WriteLine("Hi, " + Name);
            }
            else
            {
                Console.WriteLine("Wrong password or username.");
                return;
            }
            Console.WriteLine("Write 'help' to see some commands.");
            string help = Console.ReadLine();
            if (help == "help")
            {
                Console.WriteLine("1. Exit.");
            }
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Environment.Exit(0);
            }
        }
    }
}