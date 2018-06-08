using System;
using System.Text;

namespace Colorify.Terminal
{
    public static class Wrapper
    {
        static int _chunkSize { get; set; }

        public static void Text(string text)
        {
            StringBuilder line = new StringBuilder();
            string[] words = text.Split(' ');
            _chunkSize = (Console.WindowWidth - 3);
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
                ((line.Length + item.Length) >= _chunkSize) ||
                (line.ToString().Contains(Environment.NewLine))
            )
            {
                Out.WriteLine($"{line.ToString().TrimEnd()}");
                line.Clear();
            }
        }

        static void Item(ref StringBuilder line, string item)
        {
            if (item.Length >= _chunkSize)
            {
                if (line.Length > 0)
                {
                    Out.WriteLine($" {line.ToString().TrimEnd()}");
                    line.Clear();
                }
                for (int i = 0; i < item.Length; i += _chunkSize)
                {
                    if (i + _chunkSize > item.Length) { _chunkSize = item.Length - i; }
                    Out.WriteLine($" {item.Substring(i, _chunkSize).TrimEnd()}");
                    line.Clear();
                }
            }
            else
            {
                line.Append($"{item} ");
            }
        }
    }
}
