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
            Menu menu = new Menu();
            menu.ConsoleMenu();
            Calculator calc = new Calculator();
            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    menu.ConsoleMenu();
                }
                if (num == 0)
                    Environment.Exit(0);
                if (num == 2)
                    menu.CommandsList();
                if (num == 3)
                {
                    calc.clCulator();
                    menu.ConsoleMenu();
                }
            }
        }
    }
}