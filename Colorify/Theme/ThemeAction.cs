using System;
using System.Collections.Generic;

namespace Colorify.UI
{
    public abstract class ThemeAction : ITheme
    {
        protected bool _consoleDefault { get; set; }
        protected ConsoleColor _consoleBackground { get; set; }
        protected ConsoleColor _consoleForeground { get; set; }

        public Dictionary<string, Color> _colors { get; set; }

        public abstract void SetColors();

        public abstract void SetComponents();

        public void ResetColor()
        {
            Console.ResetColor();
            _consoleBackground = Console.BackgroundColor;
            _consoleForeground = Console.ForegroundColor;
        }

        public Color AddColor(ConsoleColor? background, ConsoleColor? foreground)
        {
            var color = new Color(
                background ?? _consoleBackground,
                foreground ?? _consoleForeground
            );
            return color;
        }
    }
}