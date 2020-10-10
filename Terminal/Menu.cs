﻿using System;
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
            Console.WriteLine("--Balance");
            Console.WriteLine("--Calculator");
            string balance = Console.ReadLine();
            Random rnd = new Random();
            int rndnum;
            if (balance == "Balance" || balance == "balance")
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
        }
    }
}