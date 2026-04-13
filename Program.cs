using System;

namespace CyberShield
{
    /// Entry point for the CyberShield Cybersecurity Awareness Bot.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Play audio greeting on startup
            AudioGreetings.PlayGreeting();

            // Display the CyberShield ASCII logo
            UIHelper.DisplayLogo();

            // Prompt user for their name
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Please enter your name: ");
            Console.Write("  ");
            string name = Console.ReadLine();

            // Validate that a name was actually entered
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "User";
            }

            Console.ResetColor();

            // Start the chatbot session
            ChatBot chat = new ChatBot(name);
            chat.Start();
        }
    }
}
