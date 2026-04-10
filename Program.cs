using System;

namespace CyberShield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AudioGreetings.SpeechIntro();
            UIHelper.DisplayLogo();
            Console.WriteLine("\n Please Enter your name:");
            string name = Console.ReadLine();
            ChatBot chat = new ChatBot(name);
            chat.Start();


        }
    }
}
