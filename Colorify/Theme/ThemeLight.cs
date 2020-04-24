using System;
using System.Collections.Generic;

namespace Colorify.UI
{
    public static partial class Theme
    {
        public static ITheme Light
        {
            get
            {
                return new ThemeLight(false);
            }
        }
    }

    public class ThemeLight : ThemeAction
    {
        public ThemeLight(bool consoleDefault = true)
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
                base._consoleBackground = ConsoleColor.White;
                base._consoleForeground = ConsoleColor.Black;
            }
        }

        public override void SetComponents()
        {
            var colors = new Dictionary<string, Color>();
            colors.Add("text-default", AddColor(null, null));
            colors.Add("text-muted", AddColor(null, ConsoleColor.Gray));
            colors.Add("text-primary", AddColor(null, ConsoleColor.DarkGray));
            colors.Add("text-warning", AddColor(null, ConsoleColor.DarkYellow));
            colors.Add("text-danger", AddColor(null, ConsoleColor.DarkRed));
            colors.Add("text-success", AddColor(null, ConsoleColor.DarkGreen));
            colors.Add("text-info", AddColor(null, ConsoleColor.DarkCyan));
            colors.Add("bg-default", AddColor(null, null));
            colors.Add("bg-muted", AddColor(ConsoleColor.Gray, ConsoleColor.Black));
            colors.Add("bg-primary", AddColor(ConsoleColor.DarkGray, ConsoleColor.White));
            colors.Add("bg-warning", AddColor(ConsoleColor.DarkYellow, ConsoleColor.White));
            colors.Add("bg-danger", AddColor(ConsoleColor.DarkRed, ConsoleColor.White));
            colors.Add("bg-success", AddColor(ConsoleColor.DarkGreen, ConsoleColor.White));
            colors.Add("bg-info", AddColor(ConsoleColor.DarkCyan, ConsoleColor.White));
            base._colors = colors;
        }
    }
}

