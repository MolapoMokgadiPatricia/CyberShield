using System;
using System.Media;

namespace CyberShield
{
    /// <summary>
    /// Handles audio playback for the CyberShield bot greeting on startup.
    /// </summary>
    internal class AudioGreetings
    {
        /// <summary>
        /// Plays the Greeting.wav audio file from the application directory.
        /// If the file is not found or playback fails, an error message is shown gracefully.
        /// </summary>
        public static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("Greeting.wav");
                player.Play();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" [!] Audio greeting could not be played: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}
