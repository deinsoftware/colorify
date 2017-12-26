using System;
using System.Collections.Generic;

namespace Colorify.UI
{
    public interface ITheme
    {
        Dictionary<string, Color> _colors {get; set;}
        ConsoleColor DefaultBackground();
        ConsoleColor DefaultForeground();
        Color AddColor(ConsoleColor? background, ConsoleColor? foreground);
        void SetColors();
    }
}

