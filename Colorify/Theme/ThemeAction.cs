using System;
using System.Collections.Generic;

namespace Colorify.UI
{
    public abstract class ThemeAction : ITheme
    {
        protected ConsoleColor _defaultBackground { get; set; }
        protected ConsoleColor _defaultForeground { get; set; }

        public Dictionary<string, Color> _colors { get; set; }

        public abstract void SetColors();

        public ThemeAction()
        {
            _defaultBackground = Console.BackgroundColor;
            _defaultForeground = Console.ForegroundColor;
            SetColors();
        }
        public Color AddColor(ConsoleColor? background, ConsoleColor? foreground)
        {
            var color = new Color(
                background ?? _defaultBackground,
                foreground ?? _defaultForeground
            );
            return color;
        }
    }
}

