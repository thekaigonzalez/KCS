using System;
using System.Linq;
using KaiCSConsole.Classes;
namespace KaiCSConsole.Classes
{
    public class CConsoleBuilder
    {
        public CConsoleBuilder(string consolename, string []invokeargs)
        {
            var guid = Guid.NewGuid();
            string guifs = guid.ToString();
            if (invokeargs.Contains("-v") || invokeargs.Contains("--verbose"))
            {
                PrintManagerShortener shortener = new PrintManagerShortener();
                shortener.print("console uuid is " + guifs);
                System.Threading.Thread.Sleep(2);
            }

        }
        public void IConsoleBegin()
        {
            
        }
    }
}
