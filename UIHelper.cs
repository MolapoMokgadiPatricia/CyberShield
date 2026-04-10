using System;

namespace CyberShield
{
    internal class UIHelper
    {
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"



                                              ██████╗██╗    ██╗██████╗ ███████╗██████╗   
                                            ██╔════╝╚ ██╗  ██╔╝██╔══██╗██╔════╝██╔══██╗ 
                                            ██║       ╚████╔╝  ██████╔╝█████╗  ██████╔╝ 
                                            ██║        ╚██╔╝   ██╔══██╗██╔══╝  ██╔══██╗ 
                                             ╚██████╗   ██║    ██████╔╝███████╗██║  ██║ 
                                              ╚═════╝   ╚═╝    ╚═════╝ ╚══════╝╚═╝  ╚═╝ 
                                                  
");

             Console.ForegroundColor = ConsoleColor.Cyan;
                       Console.WriteLine("\n\n\n(¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯)");
                        Console.WriteLine("");
                        Console.WriteLine("          🛡️ CYBERSECURITY AWARENESS BOT 🛡️ \n   Helping You Stay Safe Online ");
                        Console.WriteLine("");
                        Console.WriteLine("(¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯)");



            Console.ResetColor();
        }
        public static void DispalyMenu()
        {
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("\n\n 🛡️ WELCOME TO CYBERSHIELD AWARENESS BOT 🛡️");
            Console.WriteLine("    1.  Password Safety");
            Console.WriteLine("    2.  What is Phishing?");
            Console.WriteLine("    3.  Safe Browsing");
            Console.WriteLine("    4.  Malware & Ransomware");
            Console.WriteLine("    5.  Privacy & Data Protection");
            Console.WriteLine("    6.  Two-Factor Authentication (2FA)");
            Console.WriteLine("    7.  Wi-Fi & VPN Safety");
            Console.WriteLine("    8.  Chat Freely");
            Console.WriteLine("    9.  Exit");

            Console.ResetColor();
        }

    }
}

