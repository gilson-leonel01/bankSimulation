using System;
using System.Collections.Generic;
using System.Linq;
using bankSimulation.Properties.Contract;

namespace bankSimulation.Properties.Classes
{
    public class Layout
    {
        private static List<Client> clients = new List<Client>();
        private static int op = 0;
        public static void MainScreen()
        {
            // Console.BackgroundColor = ConsoleColor.Blue;
            // Console.BackgroundColor = ConsoleColor.White;
            
            Console.Clear(); 
            Console.WriteLine("*Welcome to MiliBank*");
            Console.WriteLine("------------------------");
            Console.WriteLine("1- Sign in to account\n          OR    \n2- Create a new account");
            Console.WriteLine("------------------------");
            
            op = int.Parse(Console.ReadLine());
            
            switch (op)
            {
                case 1:
                {
                    LayoutLoginAccount();
                    break;
                }
                
                case 2:
                {
                    LayoutCreateAccount();
                    break;
                }
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        }
        private static void LayoutLoginAccount()
        {
            string username, password;
            
            Console.Clear();
            Console.WriteLine("Insert your username: ");
            username = Console.ReadLine();
            
            Console.WriteLine("Insert your password: ");
            password = Console.ReadLine();

            Client client = clients.FirstOrDefault(x => x.Name == username && x.Passcode == password);
            Console.WriteLine($"Welcome {username}");
        }
        private static void LayoutCreateAccount()
        {
            Console.Clear();
            Console.WriteLine("Insert your name: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Insert your passcode: ");
            string passcode= Console.ReadLine();
            
            Console.WriteLine("Insert your phone number: ");
            string phoneNumber = Console.ReadLine();
            
            CurrentAccount currentAccount = new CurrentAccount();
            Client client = new Client();
            
            client.SetName(name);
            client.SetPasscode(passcode);
            client.SetPhoneNumber(phoneNumber);
            client.Account = currentAccount;
            
            clients.Add(client);
            
            Console.Clear();
            Console.WriteLine("Account created successfully");
        }
    }
}