using System;
using System.Text;

namespace Colorify.Terminal
{
    public static class Wrapper
    {
        static int _screenWidth { get; set; }

        public static void Text(string text)
        {
            StringBuilder line = new StringBuilder();
            string[] words = text.Split(' ');
            _screenWidth = (Console.WindowWidth - 3);
            foreach (var item in words)
            {
                Line(ref line, item);
                Item(ref line, item);
            }
            if (!String.IsNullOrEmpty(line.ToString().Trim()))
            {
                Out.WriteLine($"{line.ToString().TrimEnd()}");
            }
        }

        static void Line(ref StringBuilder line, string item)
        {
            if (
                ((line.Length + item.Length) >= _screenWidth) ||
                (line.ToString().Contains(Environment.NewLine))
            )
            {
                Out.WriteLine($"{line.ToString().TrimEnd()}");
                line.Clear();
            }
        }

        static void Item(ref StringBuilder line, string item)
        {
            if (item.Length >= _screenWidth)
            {
                if (line.Length > 0)
                {
                    Out.WriteLine($" {line.ToString().TrimEnd()}");
                    line.Clear();
                }
                int chunkSize = item.Length - _screenWidth;
                string chunk = item.Substring(0, _screenWidth);
                line.Append($"{chunk} ");
                Line(ref line, item);
                item = item.Substring(_screenWidth, chunkSize);
                Item(ref line, item);
            }
            else
            {
                line.Append($"{item} ");
            }
        }
    }
}
