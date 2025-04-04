using System;

namespace chatbot
{
    /*
     ##########################################################################################################################

    Using an interface to track all the methods that in need to  create the chatBot.

    ##############################################################################################################################
     */
    interface iGears
    {
        void PlayVoiceGreeting();
        string GetUserInput(string prompt);
        void GreetUser();
        string GetBotResponse(string userInput);
        void ChatLoop();
        void PrintSectionHeader(string title);
    }
    /*
     ########################################################################################################

    ############################################################################################################
     */
}
