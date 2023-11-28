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
            Console.Write($"PremiereOS: {API.CurPath} >> ");
            API.FG(ConsoleColor.Gray);
            string i = Console.ReadLine();
            if (i.Contains(' '))
            {
                string[] arg = i.Split(' ', StringSplitOptions.TrimEntries);
                if (arg[0] == "dir")
                {
                    if (arg[1].StartsWith(@"0:\"))
                    {
                        string path = arg[1];
                        API.Dir(path);
                    }
                    else
                    {
                        string path = API.CurPath + arg[1];
                        API.Dir(path);
                    }
                }
                else if (arg[0] == "md")
                {
                    if (arg[1].StartsWith(@"0:\"))
                    {
                        string path = arg[1];
                        API.TryMakeDir(path);
                    }
                    else
                    {
                        string path = API.CurPath + arg[1];
                        API.TryMakeDir(path);
                    }
                }
                else if (arg[0] == "dd")
                {
                    if (arg[1].StartsWith(@"0:\"))
                    {
                        string path = arg[1];
                        API.TryDelDir(path);
                    }
                    else
                    {
                        string path = API.CurPath + arg[1];
                        API.TryMakeDir(path);
                    }
                }
                else if (arg[0] == "mf")
                {
                    if (arg[1].StartsWith(@"0:\"))
                    {
                        string path = arg[1];
                        API.TryMakeFile(path);
                    }
                    else
                    {
                        string path = API.CurPath + arg[1];
                        API.TryMakeFile(path);
                    }
                }
                else if (arg[0] == "df")
                {
                    API.TryDelFile(arg[1]);
                }
                else
                {
                }
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
