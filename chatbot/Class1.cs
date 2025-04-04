using System;
using System.Media;
using System.IO;
using System.Drawing;

namespace chatbot
{
    /*
     #######################################################################################################################

    The class now implements the methods created in the interface.

    #####################################################################################################################################
     */


    public class workingParts : iGears
    {
        string name;
        /*
         ##############################################################################################
         ChatBot loop. while the user has not entered 'exit' the loop will contiune to prompt the user to 
        enter another question
        ################################################################################################
         */
        public void ChatLoop()
        {
            while (true)
            {
                Console.Write("\nYou: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    Console.WriteLine($"Goodbye, {name} thank you for using our services. Please stay safe online");
                    break;
                }
                Console.WriteLine($"Bot: {GetBotResponse(input)}");
            }
        }
       
        /*
         ##########################################################################################
        the code block take the user input capture by the chatloop fuction above as a perameter.
        the user input is used as a means to give the user a response. right now the dialog s limited and
        will be expanded it the next version of the POE

        ##########################################################################################
         */

        public string GetBotResponse(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "hello":
                    return "hello, I am the cyber security awerness chatBot";
                case "what is your purpose":
                    return "I have been built to be you assistance in navigating the internet and the dangers you may find"; 
                case "what should i know":
                    return "password protection, social engineering, phishing";
                case "tell me about passwords protection":
                    return "Use strong passwords with at least 12 characters make it harder for hachers to guess your password.";
                case "tell me about social engineering":
                    return "social engineering is a method hackers use to exploit the human aspect of security systems" +
                        "this works by suliciting information from unsuspecting staff members to gain access to sensitive information" ;
                case "tell me about phishing":
                    return "Phishing is an attack to steal your data via fake messages.";
                case "exit":
                    return $"Goodbye, {name}thank you for using our services. Please stay safe online";
                default:
                    return "I didn't understand that. Try another question or please check your spelling.";
            }
        }

        public string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        /*
         ############################################################################################
        this method is used to capture the users name and 
        #############################################################################################
         */
        public void GreetUser()
        {
            name = GetUserInput("Enter your name: ");
            Console.WriteLine($"\nHello, {name}! Welcome to the Cybersecurity Awareness Bot.");
        }
        /*
         ##################################################################################################
        this play voice greeting method plays a voice recording that plays a greeting for the user when
        the bot first opens.
        ###################################################################################################
         */

        public void PlayVoiceGreeting()
        {
            string filePath = "greeting.wav";
            if (File.Exists(filePath))
            {
                SoundPlayer player = new SoundPlayer(filePath);
                player.PlaySync();
            }
            else
            {
                Console.WriteLine("Voice greeting file not found.");
            }
        }

        public void PrintSectionHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n=== {title} ===");
            Console.ResetColor();
        }
    }
}
