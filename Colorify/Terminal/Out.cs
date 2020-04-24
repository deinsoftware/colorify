using System;

namespace Colorify.Terminal
{
    public static class Out
    {
        public static void Write(string text)
        {
            Console.Write(text);
        }

        public static void WriteLine(string text)
        {
            int size = Console.WindowWidth - 1;
            if (size != Console.CursorLeft + 1)
            {
                size = size - Console.CursorLeft;
            }
            if (size < text.Length)
            {
                size = Console.WindowWidth + size;
            }
            if (size < 0)
            {
                size = text.Length;
            }
            Console.WriteLine($"{text.PadRight(size)}");
        }

        public static void AlignRight(string text)
        {
            Console.WriteLine($"{text.PadLeft(Console.WindowWidth - 1)}");
        }

        public static void AlignLeft(string text)
        {
            Console.WriteLine($"{text.PadRight(Console.WindowWidth - 1)}");
        }

        public static void AlignCenter(string text)
        {
            decimal size = Console.WindowWidth - 1 - text.Length;
            int rightSize = (int)Math.Round(size / 2);
            int leftSize = (int)(size - rightSize);
            string leftMargin = new String(' ', leftSize);
            string rightMargin = new String(' ', rightSize);

            Console.Write(leftMargin);
            Console.Write(text);
            Console.WriteLine(rightMargin);
        }

        public static void Extreme(string left, string right)
        {
            decimal size = Console.WindowWidth - 1;
            int rightMargin = (int)Math.Round(size / 2);
            int leftMargin = (int)(size - rightMargin);

            Console.Write($"{left}".PadRight(rightMargin));
            Console.WriteLine($"{right}".PadLeft(leftMargin));
        }

        public static void DivisionLine(char character)
        {
            string text = new String(character, Console.WindowWidth - 1);
            Console.WriteLine(text);
        }

        public static void BlankLines(int? lines = 1)
        {
            for (int i = 0; i < lines; i++)
            {
                DivisionLine(' ');
            }
        }
    }
}
