using System;
using System.IO;

///
namespace KaiCSConsole.Classes
{
    /// <summary>
    /// Syscalls allows system calls to be passed as a string and evaluated here.
    /// </summary>
    public class SSysCalls
    {
        /// <summary>
        /// Evaluates A Given command with passed arguments.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="argv"></param>
        /// <returns></returns>
        public void Evaluate(string command, string[] argv)
        {
            /// if this do this
            /// if not return string "NULL" (0)
            
            if (command == "help")
            {
                ///???
                NotableCommands.UsualHelpCommand c = new NotableCommands.UsualHelpCommand();
            }
            else if (command == "addins")
            {
                PrintManagerShortener sh = new PrintManagerShortener();
                var addins = Directory.Exists("./addons/");

                if (addins == true)
                {
                    var arr = Directory.GetFiles("./addons/");
                    sh.print("you have " + arr.Length + " addons");

                }
                else
                {
                    sh.print("You have not installed the addons driver! Type driver install addons  and retry this command.");
                }
            }
            else if (command == "driver")
            {
                if (argv[1] == "install")
                {
                    if (argv[2] == "addons")
                    {
                        Directory.CreateDirectory("./addons/");
                    }
                }
            }
            else
            {
                        Console.WriteLine("shell: unknown command. try running kuget install " + command );
                    }

            
        }


        
        public SSysCalls(string _call)
        {
            /// lazy c# n00b lol
            Evaluate(_call.Split(" ")[0], _call.Split(" "));
        }
    }
}
