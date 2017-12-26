using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using ToolBox.Platform;

namespace Colorify.UI
{
    public struct Color
    {
        public ConsoleColor _background { get; private set; }
        public ConsoleColor _foreground { get; private set; }

        public Color(ConsoleColor background, ConsoleColor foreground) : this()
        {
                _background = background;
                _foreground = foreground;
        }
    }
}

