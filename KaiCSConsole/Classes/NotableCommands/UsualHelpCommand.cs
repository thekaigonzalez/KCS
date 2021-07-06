using System;
namespace KaiCSConsole.Classes.NotableCommands
{
    public class UsualHelpCommand
    {
        public UsualHelpCommand()
        {
            PrintManagerShortener sh = new PrintManagerShortener();

            sh.print("help menu not available in build 1.0");
            sh.print("view commands ");
        }
    }
}
