using System;

namespace Colorify.Terminal
{
    public static class Out
    {
        public static void Write(string text){
            try
            {
                Console.Write(text);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void WriteLine(string text){
            try
            {
                int size = Console.WindowWidth - 1;
                if (size != Console.CursorLeft + 1)
                {
                    size = size - Console.CursorLeft;
                }
                if (size < text.Length){
                    size = Console.WindowWidth + size;
                }
                Console.WriteLine( $"{text.PadRight(size)}" );
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AlignRight(string text)
        {
            try
            {
                Console.WriteLine( $"{text.PadLeft(Console.WindowWidth - 1)}" );
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AlignLeft(string text)
        {
            try
            {
                Console.WriteLine( $"{text.PadRight(Console.WindowWidth - 1)}" );
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AlignCenter(string text){
            try
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
            catch (Exception)
            {
                throw;
            }
            
        }
        
        public static void Extreme(string left, string right)
        {
            try
            {
                decimal size = Console.WindowWidth - 1;
                int rightMargin = (int)Math.Round(size / 2);
                int leftMargin = (int)(size - rightMargin);

                Console.Write($"{left}".PadRight(rightMargin));
                Console.WriteLine($"{right}".PadLeft(leftMargin));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void DivisionLine(char character)
        {
            try
            {
                string text = new String(character, Console.WindowWidth - 1);
                Console.WriteLine(text);    
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void BlankLines(int? lines = 1)
        {
            try
            {
                for (int i = 0; i < lines; i++)
                {
                    DivisionLine(' ');
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
