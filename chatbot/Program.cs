using System;
using System.IO;
using System.Media;
using System.Drawing;

namespace chatbot 
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            workingParts obj = new workingParts();
            obj.PlayVoiceGreeting();
            new Logo() { };
            obj.GreetUser();
            obj.ChatLoop();

        }
    }
}
