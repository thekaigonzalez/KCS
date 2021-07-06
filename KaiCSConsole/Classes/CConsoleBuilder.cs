using System;
using System.Linq;
using KaiCSConsole.Classes;
namespace KaiCSConsole.Classes
{
    public class CConsoleBuilder
    {
        string guid = Guid.NewGuid().ToString();
        
        public CConsoleBuilder(string consolename, string []invokeargs)
        {
            
            if (invokeargs.Contains("-v") || invokeargs.Contains("--verbose"))
            {
                PrintManagerShortener shortener = new PrintManagerShortener();
                shortener.print("console uuid is " + guid);
                System.Threading.Thread.Sleep(2);
            }

        }
        /// <summary>
        /// Invokes the console.
        ///
        /// basically, it invokes the console system using a bunch of syscalls found in Classes/SSysCalls.cs 
        /// </summary>
        /// <param name="consolecommand"></param>
        /// <param name="arguments"></param>
        public void ConsoleIInvoke(string consolecommand, string []arguments)
        {
            Console.Write("using c# " + Environment.Version + " [" + guid + "]");
        }
    }
}
