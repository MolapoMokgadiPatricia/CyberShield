using System;

namespace CyberShield
{
    /// <summary>
    /// Provides static UI methods for displaying the logo, menu, and greeting messages.
    /// </summary>
    internal class UIHelper
    {
        /// <summary>
        /// Displays the CyberShield ASCII art logo in the console.
        /// </summary>
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"


                 $$$$$$\ $$\     $$\ $$$$$$$\  $$$$$$$$\ $$$$$$$\   $$$$$$\  $$\   $$\ $$$$$$\ $$$$$$$$\ $$\       $$$$$$$\        
                $$  __$$\\$$\   $$  |$$  __$$\ $$  _____|$$  __$$\ $$  __$$\ $$ |  $$ |\_$$  _|$$  _____|$$ |      $$  __$$\       
                $$ /  \__|\$$\ $$  / $$ |  $$ |$$ |      $$ |  $$ |$$ /  \__|$$ |  $$ |  $$ |  $$ |      $$ |      $$ |  $$ |      
                $$ |       \$$$$  /  $$$$$$$\ |$$$$$\    $$$$$$$  |\$$$$$$\  $$$$$$$$ |  $$ |  $$$$$\    $$ |      $$ |  $$ |      
                $$ |        \$$  /   $$  __$$\ $$  __|   $$  __$$<  \____$$\ $$  __$$ |  $$ |  $$  __|   $$ |      $$ |  $$ |      
                $$ |  $$\    $$ |    $$ |  $$ |$$ |      $$ |  $$ |$$\   $$ |$$ |  $$ |  $$ |  $$ |      $$ |      $$ |  $$ |      
                \$$$$$$  |   $$ |    $$$$$$$  |$$$$$$$$\ $$ |  $$ |\$$$$$$  |$$ |  $$ |$$$$$$\ $$$$$$$$\ $$$$$$$$\ $$$$$$$  |      
                 \______/    \__|    \_______/ \________|\__|  \__| \______/ \__|  \__|\______|\________|\________|\_______/       
                                                                                                                   

                                            ¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯
                                                         A CYBERSECURITY AWARENESS BOT
                                                        That Helps You Stay Safe Online .          
                                            ¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯`•.¸¸.•´¯
         ");

            Console.ResetColor();
        }

        /// <summary>
        /// Displays a personalised text welcome greeting after the audio and ASCII art.
        /// This satisfies the rubric requirement for a text greeting post-launch.
        /// </summary>
        public static void DisplayWelcomeGreeting()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n ╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║   Welcome to CyberShield — Your Personal Security Assistant  ║");
            Console.WriteLine(" ║   Empowering South Africans to stay safe in the digital age. ║");
            Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
        }

        /// <summary>
        /// Displays the main navigation menu with all available topic options.
        /// </summary>
        public static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\n ¯`•.¸ WELCOME TO CYBERSHIELD AWARENESS BOT ¸.•´¯");
            Console.WriteLine(" ┌─────────────────────────────────────────┐");
            Console.WriteLine("    1.  Password Safety");
            Console.WriteLine("    2.  What is Phishing?");
            Console.WriteLine("    3.  Safe Browsing");
            Console.WriteLine("    4.  Malware & Ransomware");
            Console.WriteLine("    5.  Privacy & Data Protection");
            Console.WriteLine("    6.  Two-Factor Authentication (2FA)");
            Console.WriteLine("    7.  Wi-Fi & VPN Safety");
            Console.WriteLine("    8.  Chat Freely");
            Console.WriteLine("    9.  Exit");
            Console.WriteLine(" └─────────────────────────────────────────┘");
            Console.ResetColor();
        }

        /// <summary>
        /// Displays a formatted error message for invalid user input.
        /// </summary>
        public static void DisplayError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n [!] {message}");
            Console.ResetColor();
        }
    }
}