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
            if (!Directory.Exists(@"0:\premiere"))
            {
                API.BG(ConsoleColor.Blue);
                Console.Clear();
                Console.WriteLine(" Welcome to PremiereOS home & work! Setting up system...\n");
                Console.CursorVisible = false;
                Console.WriteLine("Formatting disk...");
                API.Format(@"0:\");
                API.SetCursor(0, 3);
                Console.WriteLine("Creating files... ");
                API.TryMakeDir(@"0:\premiere");
                API.TryMakeFile(@"0:\premiere\help.cmd");
                File.WriteAllLines(@"0:\premiere\help.cmd", API.FileContainer.help_cmd);
                API.TryMakeFile(@"0:\premiere\cls.cmd");
                File.WriteAllLines(@"0:\premiere\cls.cmd", API.FileContainer.cls_cmd);
                API.TryMakeFile(@"0:\premiere\off.cmd");
                File.WriteAllLines(@"0:\premiere\off.cmd", API.FileContainer.off_cmd);
                API.TryMakeFile(@"0:\premiere\reboot.cmd");
                File.WriteAllLines(@"0:\premiere\reboot.cmd", API.FileContainer.reboot_cmd);
                API.TryMakeFile(@"0:\premiere\ABOUT.txt");
                File.WriteAllLines(@"0:\premiere\ABOUT.txt", API.FileContainer.about_txt);
                API.SetCursor(0, 3);
                Console.WriteLine("Files successfuly created, rebooting...");
                API.Reboot();
            }
        }
    }
}
