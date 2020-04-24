using System;
using System.Collections.Generic;

namespace Colorify.UI
{
    public static partial class Theme
    {
        public static ITheme Dark
        {
            get
            {
                return new ThemeDark(false);
            }
        }
    }

    public class ThemeDark : ThemeAction
    {
        public ThemeDark(bool consoleDefault = true)
        {
            base._consoleDefault = consoleDefault;
            SetColors();
            SetComponents();
        }

        public override void SetColors()
        {
            if (base._consoleDefault)
            {
                ResetColor();
            }
            else
            {
                base._consoleBackground = ConsoleColor.Black;
                base._consoleForeground = ConsoleColor.White;
            }
        }

        public override void SetComponents()
        {
            var colors = new Dictionary<string, Color>();
            colors.Add("text-default", AddColor(null, null));
            colors.Add("text-muted", AddColor(null, ConsoleColor.DarkGray));
            colors.Add("text-primary", AddColor(null, ConsoleColor.Gray));
            colors.Add("text-warning", AddColor(null, ConsoleColor.Yellow));
            colors.Add("text-danger", AddColor(null, ConsoleColor.Red));
            colors.Add("text-success", AddColor(null, ConsoleColor.DarkGreen));
            colors.Add("text-info", AddColor(null, ConsoleColor.DarkCyan));
            colors.Add("bg-default", AddColor(null, null));
            colors.Add("bg-muted", AddColor(ConsoleColor.DarkGray, ConsoleColor.Black));
            colors.Add("bg-primary", AddColor(ConsoleColor.Gray, ConsoleColor.White));
            colors.Add("bg-warning", AddColor(ConsoleColor.Yellow, ConsoleColor.Black));
            colors.Add("bg-danger", AddColor(ConsoleColor.Red, ConsoleColor.White));
            colors.Add("bg-success", AddColor(ConsoleColor.DarkGreen, ConsoleColor.White));
            colors.Add("bg-info", AddColor(ConsoleColor.DarkCyan, ConsoleColor.White));
            base._colors = colors;
        }
    }
}

