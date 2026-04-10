using System;
using System.Media;

namespace CyberShield
{
    internal class AudioGreetings
    {
        public static void PlayGreeting()
        {
            SoundPlayer player = new SoundPlayer("Greeting.wav");
            player.Play();
        }
    }
}
