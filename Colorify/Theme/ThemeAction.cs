using System;
using System.Collections.Generic;

namespace Colorify.UI
{
    public class ThemeAction
    {
        protected ConsoleColor _defaultBackground { get; set; }
        protected ConsoleColor _defaultForeground { get; set; }

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

