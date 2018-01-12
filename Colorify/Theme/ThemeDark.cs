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
                return new ThemeDark();
            }
        }
    }

    public sealed class ThemeDark : ThemeAction, ITheme
    {
        public ThemeDark(){
            base._defaultBackground = ConsoleColor.Black;
            base._defaultForeground = ConsoleColor.White;
            SetColors();
        }

        public Dictionary<string, Color> _colors {get; set;}

        public void SetColors(){
            var colors = new Dictionary<string, Color>();
            colors.Add("text-default", AddColor(null                   , null                   ));
            colors.Add("bg-default"  , AddColor(null                   , null                   ));
            colors.Add("text-muted"  , AddColor(null                   , ConsoleColor.DarkGray  ));
            colors.Add("text-primary", AddColor(null                   , ConsoleColor.Gray      ));
            colors.Add("text-warning", AddColor(null                   , ConsoleColor.Yellow    ));
            colors.Add("text-danger" , AddColor(null                   , ConsoleColor.Red       ));
            colors.Add("bg-muted"    , AddColor(ConsoleColor.DarkGray  , ConsoleColor.Black     ));
            colors.Add("bg-primary"  , AddColor(ConsoleColor.Gray      , ConsoleColor.White     ));
            colors.Add("bg-warning"  , AddColor(ConsoleColor.Yellow    , ConsoleColor.Black     ));
            colors.Add("bg-danger"   , AddColor(ConsoleColor.Red       , ConsoleColor.White     ));
            colors.Add("text-success", AddColor(null                   , ConsoleColor.DarkGreen ));
            colors.Add("text-info"   , AddColor(null                   , ConsoleColor.DarkCyan  ));
            colors.Add("bg-success"  , AddColor(ConsoleColor.DarkGreen , ConsoleColor.White     ));
            colors.Add("bg-info"     , AddColor(ConsoleColor.DarkCyan  , ConsoleColor.White     ));
            _colors = colors;
        }
    }
}

