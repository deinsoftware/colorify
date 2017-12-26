using System;

namespace Colorify.Terminal
{
    public static class Out
    {
        public static void Write(string text){
            Console.Write(text);
        }

        public static void WriteLine(string text){
            int size = Console.WindowWidth;
            if (size != Console.CursorLeft + 1)
            {
                size = size - Console.CursorLeft;
            }
            if (size < text.Length){
                size = Console.WindowWidth + size;
            }
            Console.Write( $"{text.PadRight(size)}" );
        }

        public static void AlignRight(string text)
        {
            Console.WriteLine( $"{text.PadLeft(Console.WindowWidth)}" );
        }

        public static void AlignLeft(string text)
        {
            Console.WriteLine( $"{text.PadRight(Console.WindowWidth)}" );
        }

        public static void AlignCenter(string text){
            decimal size = Console.WindowWidth - text.Length;
            int rightSize = (int)Math.Round(size / 2);
            int leftSize = (int)(size - rightSize);
            string leftMargin = new String(' ', leftSize);
            string rightMargin = new String(' ', rightSize);

            Console.Write(leftMargin);
            Console.Write(text);
            Console.Write(rightMargin);
        }
        
        public static void Extreme(string left, string right)
        {
            decimal size = Console.WindowWidth;
            int rightMargin = (int)Math.Round(size / 2);
            int leftMargin = (int)(size - rightMargin);

            Console.Write($"{left}".PadRight(rightMargin));
            Console.Write($"{right}".PadLeft(leftMargin));
        }

        public static void RepeatLine(char character)
        {
            string text = new String(character, Console.WindowWidth);
            Console.WriteLine(text);
        }

        public static void BlankLines(int? lines = 1)
        {
            for (int i = 0; i < lines; i++)
            {
                RepeatLine(' ');
            }
        }
    }
}