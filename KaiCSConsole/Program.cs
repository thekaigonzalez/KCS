using System;
using System.Threading;
namespace KaiCSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading Classes...");
            Thread.Sleep(1000);
            // THREAD LOADING SEQUENCE
            //
            //
            // get dllexecutor
            Classes.OSDLLExecutor executor = new Classes.OSDLLExecutor();
            Console.WriteLine("Loaded OSDLLExecutor");
            Thread.Sleep(1000);
            //build a console basic
            Classes.CConsoleBuilder consoleBuilder = new Classes.CConsoleBuilder("Main", new string[] { "-v" });
            Thread.Sleep(1000);
            // add a print manager
            Classes.PrintManagerShortener shortener = new Classes.PrintManagerShortener();
            Thread.Sleep(2000);
            // continue in future version in git
        }
    }
}
