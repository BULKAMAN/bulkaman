using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;

namespace Terminal
{
    class Menu
    {
        public void ConsoleMenu()
        {
            Console.WriteLine("Write 'help' to see some commands.");
            string help = Console.ReadLine();
            if (help == "help")
            {
                Console.WriteLine("0. Exit.");
                Console.WriteLine("1. Back.");
                Console.WriteLine("2. Commands list");
            }
        }
        public void CommandsList()
        {
            Console.WriteLine("All commands:");
            Console.WriteLine("--balance");
            Console.WriteLine("--calculator");
            string balance = Console.ReadLine().ToLower();
            string calcul = Console.ReadLine().ToLower();
            Random rnd = new Random();
            Calculator calc = new Calculator();
            int rndnum;
            if (balance == "balance")
            {
                rndnum = rnd.Next(100, 10000);
                Console.WriteLine(rndnum);
                ConsoleMenu();
            }
            else
            {
                Console.WriteLine("Wrong command.");
                ConsoleMenu();
            }
            if (calcul == "calculator")
            {
                calc.clCulator();
                ConsoleMenu();
            }
            else
            {
                Console.WriteLine("Wrong command.");
                ConsoleMenu();
            }
        }
    }
}