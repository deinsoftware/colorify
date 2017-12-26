using System;
using System.Collections.Generic;

namespace Colorify.UI
{
    public static partial class Theme
    {
        public static ITheme Mac
        {
            get
            {
                var platform = new ThemeMac();
                platform.SetColors();
                return platform;
            }
        }
    }

    public sealed class ThemeMac : ITheme
    {
        public ThemeMac(){
            SetColors();
        }

        public Dictionary<string, Color> _colors {get; set;}

        public ConsoleColor DefaultBackground(){
            return ConsoleColor.Black;
        }

        public ConsoleColor DefaultForeground(){
            return ConsoleColor.Black;
        }

        public Color AddColor(ConsoleColor? background, ConsoleColor? foreground){
            var color = new Color(
                background ?? DefaultBackground(),
                foreground ?? DefaultForeground()
            );
            return color;
        }
        public void SetColors(){
            _colors.Add("text-default", AddColor(null                   , null                   ));
            _colors.Add("bg-default"  , AddColor(null                   , null                   ));
            _colors.Add("text-muted"  , AddColor(null                   , ConsoleColor.Gray      ));
            _colors.Add("text-primary", AddColor(null                   , ConsoleColor.DarkGray  ));
            _colors.Add("text-warning", AddColor(null                   , ConsoleColor.DarkYellow));
            _colors.Add("text-danger" , AddColor(null                   , ConsoleColor.DarkRed   ));
            _colors.Add("bg-muted"    , AddColor(ConsoleColor.Gray      , ConsoleColor.Black     ));
            _colors.Add("bg-primary"  , AddColor(ConsoleColor.DarkGray  , ConsoleColor.White     ));
            _colors.Add("bg-warning"  , AddColor(ConsoleColor.DarkYellow, ConsoleColor.White     ));
            _colors.Add("bg-danger"   , AddColor(ConsoleColor.DarkRed   , ConsoleColor.White     ));
            _colors.Add("text-success", AddColor(null                   , ConsoleColor.DarkGreen ));
            _colors.Add("text-info"   , AddColor(null                   , ConsoleColor.DarkCyan  ));
            _colors.Add("bg-success"  , AddColor(ConsoleColor.DarkGreen , ConsoleColor.White     ));
            _colors.Add("bg-info"     , AddColor(ConsoleColor.DarkCyan  , ConsoleColor.White     ));
        }
    }
}

