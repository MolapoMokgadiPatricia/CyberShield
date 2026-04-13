# CyberShield

CyberShield is a console-based cybersecurity awareness chatbot built with C# and .NET. It is designed to educate South African citizens on common cybersecurity threats and best practices through an interactive menu-driven interface.

---

## Features

- Audio greeting on startup
- ASCII art branding displayed on launch
- Interactive menu covering key cybersecurity topics
- Free-form chat mode for open-ended questions
- Typed response output for a conversational feel

### Topics Covered

- Password safety and best practices
- Phishing awareness and how to spot attacks
- Safe browsing habits
- Malware and ransomware protection
- Privacy and data protection (including POPIA)
- Two-factor authentication (2FA)
- Wi-Fi and VPN safety

---

## Requirements

- Windows OS
- .NET 8.0 or later
- A working audio output device (for the greeting sound)

---

## Getting Started

1. Clone the repository:

```
git clone https://github.com/MolapoMokgadiPatricia/CyberShield.git
```

2. Open the project in Visual Studio or your preferred IDE.

3. Build and run the project:

```
dotnet run
```

4. Enter your name when prompted and select a menu option to begin.

---

## Project Structure

```
CyberShield/
    Program.cs          - Entry point
    ChatBot.cs          - Menu logic and response handling
    UIHelper.cs         - Logo and menu display
    AudioGreetings.cs   - Plays the greeting sound on startup
    Greeting.wav        - Audio greeting file
    App.config          - Application configuration
    CyberShield.csproj  - Project file
```

---

## CI/CD

This project uses GitHub Actions for automated builds on push and pull request to the master branch. The workflow builds both Debug and Release configurations and uploads the output as a build artifact.

The workflow file is located at `.github/workflows/dotnet-desktop.yml`.
<img width="1350" height="599" alt="Screenshot 2026-04-10 180106" src="https://github.com/user-attachments/assets/e053b047-f001-46c7-8c64-c7b9cd2b2820" />

---

## Youtube Link (unlisted)

https://youtu.be/fm8aqABb3Rg?si=xZvOmEm-xtcyaU7a

---

## License

This project is for educational purposes. No license has been specified.

---

## Author

MolapoMokgadiPatricia

Developed as a cybersecurity awareness tool targeting South African internet users.

---
## Reference

Anthropic Claude AI, 2023
