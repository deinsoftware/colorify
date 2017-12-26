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

        public static void AlignRight(string text)
        {
            Console.WriteLine( $"{(" " + text).PadLeft(Console.WindowWidth)}" );
        }

        public static void AlignLeft(string text)
        {
            Console.WriteLine( $"{(text + " ").PadRight(Console.WindowWidth)} " );
        }
        
        public static void Extreme(string left, string right)
        {
            int r = Console.WindowWidth / 2;
            int l = Console.WindowWidth - r;

            Console.Write(left.PadRight(r));
            Console.WriteLine(right.PadLeft(l));
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