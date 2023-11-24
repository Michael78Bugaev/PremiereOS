using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
