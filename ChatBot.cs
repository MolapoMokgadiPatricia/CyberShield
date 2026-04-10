using System;
using System.Threading;


namespace CyberShield
{
    internal class ChatBot
    {
        string userName;
        public ChatBot(string name)
        {
            userName = name;
        }
        public async void Display(string message)

        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\n CyberShield Bot: ");

            foreach (char text in message)
            {
                Console.Write(text);
                Thread.Sleep(40);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
        public void Start()
        {

            bool run = true;
            while (run)
            {
                UIHelper.DispalyMenu();
                Console.Write("Choose Any Option Of Your Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Display(" When creating a strong passowrd, you should avoid using obvious information that any person could guess easily. Make sure it contains the following: " 
                            + Environment.NewLine + " Letters (UPPERCASE and lowercasse), numbers (123etc), symbols {!@#$},e.g Molapo@21." 
                            + Environment.NewLine + " Never reuse the same password across multiple accounts. If one is breached, all others become vulnerable. A password manager like Bitwarden can help you keep track of unique passwords safely."
                            + Environment.NewLine + " A strong password should be at least 12 characters long. Passphrases like 'BlueSky$Runs@Night' are both strong and easier to remember than random strings of characters.");
                        break;
                    case "2":
                        Display(" Phishing is when attackers trick you into revealing personal information — like passwords or banking details — through fake emails or websites that look legitimate. Always verify the sender's email address before clicking any links."
                            + Environment.NewLine + " To spot phishing: hover over links before clicking to check the real URL, never download unexpected attachments, and remember that legitimate companies will never ask for your password via email."
                            + Environment.NewLine + " Watch for urgent language like 'Your account will be closed!' — this is a classic phishing tactic designed to make you panic and act without thinking.");
                            break;

                    case "3":
                        Display(" Only visit websites that start with HTTPS — the 'S' stands for Secure. Look for the padlock icon in your browser's address bar before entering any sensitive information."
                            + Environment.NewLine +" Avoid clicking shortened URLs (like bit.ly links) in emails or SMS messages — they often hide malicious destinations. Go directly to official websites instead."
                            + Environment.NewLine +" Use a reputable browser with built-in phishing protection, and consider an ad blocker to reduce your exposure to malicious advertisements.");
                        break;

                    case "4":
                        Display(" Malware is malicious software designed to damage or gain unauthorised access to your device. Keep your antivirus software updated and never download programs from unofficial sources."
                            + Environment.NewLine + " Ransomware locks your files and demands payment to restore them. Protect yourself by regularly backing up data using the 3-2-1 rule: 3 copies, on 2 different media, with 1 stored offsite."
                            + Environment.NewLine + " Never open email attachments from unknown senders — even a simple PDF or Word document can contain hidden malware that executes when opened.");

                        break;
                    case "5":
                        Display(" Review your social media privacy settings regularly. Limit the personal information you share publicly — details like your birthday or hometown can be used for social engineering attacks." 
                            + Environment.NewLine + " South Africa's POPIA (Protection of Personal Information Act) gives you rights over your personal data. You can request organisations to stop using or delete your data if it is no longer necessary."
                            + Environment.NewLine + " Be careful what you post online — even seemingly harmless information can be combined by attackers to steal your identity or answer your security questions.");
                    
                        break;

                    case "6":
                        Display(" Two-factor authentication (2FA) adds a second layer of security beyond your password. Even if someone steals your password, they still cannot access your account without the second factor. Enable it on your email and banking accounts today."
                            + Environment.NewLine + " Use an authenticator app like Google Authenticator or Authy instead of SMS-based 2FA, which can be vulnerable to SIM swapping attacks.");

                        break;

                    case "7":
                        Display(" Avoid accessing banking or sensitive accounts on public Wi-Fi — these networks are often unsecured and easy for attackers to intercept. Use a trusted VPN to encrypt your connection when on public networks." 
                            + Environment.NewLine + " If you must use public Wi-Fi, verify the network name carefully — attackers set up fake hotspots with similar names. Prefer mobile data over unknown Wi-Fi for any sensitive tasks.");
                        break;
                    case "8":
                        CasualChat();
                        break;

                    case "9":
                        Display("Thank You and Goodbye " + userName + " Remember to stay safe online.");
                        run = false;
                        break;

                    default:
                        Display(" INVALID OPTION , PLEASE SELECT AGAIN ");
                        break;

                }
            }
        }
        public void CasualChat()
        {
            Display("You can chat with me, Type 'back' to return to the menu.");
            while (true)
            {
                Console.Write("\n" + userName + ":");
                string input = Console.ReadLine().ToLower();

                if (input.Contains("back"))
                {
                    break;
                }

                else if (input.Contains("hello"))
                {
                    Display(" Hello! What cybersecurity topic can I help you with today?");
                }
                else if (input.Contains("how are you"))
                {
                    Display(" I'm a program built to keep you safe online — no feelings, but fully operational and ready to help!");
                }
                else if (input.Contains("cybersecurity"))
                {
                    Display(" Cybersecurity is the protection of computer systems, networks, and sensitive data from unauthorised access, hackers, malware, phishing scams, and other digital threats." +
                    "Cybersecurity covers everything from securing your passwords and personal devices to protecting entire organisations from data breaches and ransomware attacks.");
                }
                else if (input.Contains("purpose"))
                {
                    Display(" I am designed to educate South African citizens on cybersecurity topics and help you stay safe in the digital world. "+
                        " My purpose is to be your personal cybersecurity assistant — covering topics like phishing, passwords, safe browsing, malware, and more.");
                }
                else if (input.Contains("software"))
                {
                    Display(" You should update your software regularly, as soon as new updates are available. Here's why:" + Environment.NewLine + "PATCHES SECURITY VULNERABILITY: Updates often fix security holes that hackers could exploit." 
                        + Environment.NewLine + "FIXES BUGS:Update squash bugs that could cause crashes and data loss." + Environment.NewLine + "ADDS NEW FEATURES: You'll get new and improved features." 
                        + Environment.NewLine + "PROTECTS AGAINST MALWARE: Updates often includde protects protection from new threats.");
                }
                else if (input.Contains("understand"))
                {
                    Display(" I'm glad that you undersatand, do you wish to continue or go back to the main menu.");
                }
                else if (input.Contains("continue"))
                {
                    Display(" Ok, what else would you like to know wbout cybersecurity?");
                }
                else
                {
                    Display(" Pardon, i don't understand your question please try again.");
                }
            }

        }
    }
}