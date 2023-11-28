using System;

namespace bankSimulation.Properties.Classes
{
    public class Layout
    {
        private static int op = 0;
        public static void MainScreen()
        {
            // Console.BackgroundColor = ConsoleColor.Blue;
            // Console.BackgroundColor = ConsoleColor.White;
            
            Console.Clear(); 
            Console.WriteLine("*Welcome to MiliBank*");
            Console.WriteLine("------------------------");
            Console.WriteLine("1- Sign in to account\n     OR    \n2- Create a new account");
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
            string username, password, newPassword;
            
            Console.Clear();
            Console.WriteLine("Insert your username: ");
            username = Console.ReadLine();
            
            Console.WriteLine("Insert your password: ");
            password = Console.ReadLine();
            
            Console.WriteLine($"Welcome {username}");
        }
        private static void LayoutCreateAccount()
        {
            Console.Clear();
            Console.WriteLine("Insert your name: ");
        }
    }
}