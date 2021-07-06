using System;
using System.Reflection;


/// <summary>
/// Adds the class to the KCS Console Classes Namespace
/// </summary>
namespace KaiCSConsole.Classes
{
    /// <summary>
    /// Most likely when OSDLLExecutor is called..
    ///
    /// (C# N00b here)
    /// </summary>
    public class OSDLLExecutor
    {
        /// <summary>
        /// Probably invokes a DLL...
        /// </summary>
        /// <param name="iecdll"></param>
        /// <returns></returns>
        public dynamic OSDLLInvoke(string iecdll)
        {
            /**
             * REFERENCE CODES
             * 
             * 
             * namespace ConsoleApplication1
{
    using System;
    using System.Reflection;

    class Program 
    {
        static void Main(string[] args)
        {
            var DLL = Assembly.LoadFile(@"C:\visual studio 2012\Projects\ConsoleApplication1\ConsoleApplication1\DLL.dll");

            foreach(Type type in DLL.GetExportedTypes())
            {
                dynamic c = Activator.CreateInstance(type);
                c.Output(@"Hello");
            }

            Console.ReadLine();
        }
    }
}
             * 
             */
            var DLL = Assembly.LoadFile(iecdll);
            
            var dll_class_t = DLL.GetType(iecdll + ".Main"); /// Main Invoke
            dynamic c = Activator.CreateInstance(dll_class_t);
            return c;
            
        }
    }
}
