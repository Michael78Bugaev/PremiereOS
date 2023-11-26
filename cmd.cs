using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiereOS
{
    public static class cmd
    {
        public static void Run()
        {
            API.FG(ConsoleColor.Cyan);
            Console.Write("PremiereOS >> ");
            API.FG(ConsoleColor.White);
            string i = Console.ReadLine();
            if (i.Contains(' '))
            {
                string[] arg = i.Split(' ', StringSplitOptions.TrimEntries);
            }
            else
            {
                string arg = i;
                if (arg == "off")
                {
                    API.Shutdown();
                }
                else if (arg == "reboot")
                {
                    API.Reboot();
                }
                else if (arg == "cls")
                {
                    Console.Clear();
                    Console.WriteLine();
                }
                else
                {

                }
            }
        }
    }
}
