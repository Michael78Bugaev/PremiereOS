﻿using static Cosmos.System.Console;
using static Cosmos.System.Power;
using System;
using System.IO;
using Cosmos.HAL;
using Sys = Cosmos.System;

namespace PremiereOS
{
    public static class API
    {
        public static void FG(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        public static void BG(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }
        public static void SetCursor(int X, int Y)
        {
            Console.SetCursorPosition(X, Y);
        }
        public static int GetCursorX()
        {
            int X = Console.GetCursorPosition().Left;
            return X;
        }
        public static int GetCursorY()
        {
            int Y = Console.GetCursorPosition().Top;
            return Y;
        }
        public static void TryMakeDir(string path)
        {
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Failed to make directory. Reason: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine($"Directory '{path}' has already exists!");
            }
        }
        public static void TryMakeFile(string path)
        {
            if (!File.Exists(path))
            {
                try
                {
                    File.Create(path);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Failed to make file. Reason: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine($"File '{path}' has already exists!");
            }
        }
        public static void Format(string disk)
        {
            DirectoryInfo directory = new DirectoryInfo(disk);

            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo dir in directory.GetDirectories())
            {
                dir.Delete(true);
            }
        }
        public static void Reboot()
        {
            Sys.Power.Reboot();
        }
        public static void Shutdown()
        {
            Sys.Power.Shutdown();
        }
        public static void Message(string msg)
        {

        }
        public static class FileContainer
        {
            public static string[] about_txt =
            {
                "Welcome to PrimiereOS v1!",
                " ",
                "This is an Operating System created by ES company.",
                "It created for easy working at home & work.",
                "We wish you pleasant use of our new product!"
            };
            public static string[] help_cmd =
            {
                "echo PrimiereOS v1 commands:",
                "echo help - show commands",
                "echo dir - show directory content",
                "echo cd [dir] - change directory",
                "echo md [dir] - make directory",
                "echo dd [dir] - delete directory",
                "echo mf [file] - make file",
                "echo df [file] - delete file",
                "echo cls - clear screen",
                "echo off - shutdown system",
                "echo reboot - restart system"
            };
            public static string[] cls_cmd =
            {
                "cls",
                "echo PrimiereOS"
            };
            public static string[] off_cmd =
            {
                "echo rebooting...",
                "sleep 1",
                "off"
            };
            public static string[] reboot_cmd =
            {
                "reboot"
            };
        }
    }
}
