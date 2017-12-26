using System;

namespace Colorify.Terminal
{
    public static class Out
    {
        public static void Write(string text){
            Console.Write(text);
        }

        public static void WriteLine(string text){
            Console.WriteLine( $" {text}" );
        }

        public static void PadLeft(string text)
        {
            Console.WriteLine( $" {text.PadLeft(Console.WindowWidth - 1)}" );
        }

        public static void PadRight(string text)
        {
            Console.WriteLine( $" {text.PadRight(Console.WindowWidth - 1)}" );
        }
        
        public static void Extreme(string left, string right)
        {
            int l = Console.WindowWidth / 2;
            Console.Write( $" {left.PadLeft(l - 0)}" );
            int r = Console.WindowWidth - l;
            Console.WriteLine( $"{right.PadRight(r - 1)}" );
        }

        public static void RepeatLine(char character)
        {
            string text = new String(character, Console.WindowWidth - 1);
            Console.WriteLine(text);
        }

        public static void BlankLines(int? lines = 1)
        {
            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine("");
            }
        }
    }
}