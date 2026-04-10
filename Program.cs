using System;

namespace CyberShield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AudioGreetings.PlayGreeting();
            Console.WriteLine("Audio playing. Press Enter to exit.");
            Console.ReadLine();
            UIHelper.DisplayLogo();
            Console.WriteLine("\nPlease Enter your name:");
            string name = Console.ReadLine();
            ChatBot chat = new ChatBot(name);
            chat.Start();


        }
    }
}
