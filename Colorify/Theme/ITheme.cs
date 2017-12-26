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
    public interface ITheme
    {
        Dictionary<string, Color> Colors {get; set;}
        Color AddColor(ConsoleColor? background, ConsoleColor? foreground);
        void SetColors();
    }
}

