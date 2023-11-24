using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiereOS
{
    public static class BootLoader
    {
        public static void Load()
        {
            if (!Directory.Exists(@"0:\sys"))
            {
                API.BG(ConsoleColor.Blue);
                Console.Clear();
                Console.WriteLine(" Welcome to PrimiereOS! Setting up system...");
                Console.CursorVisible = false;

            }
        }
    }
}
