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
                return new ThemeMac();
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
            return ConsoleColor.White;
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
            var colors = new Dictionary<string, Color>();
            colors.Add("text-default", AddColor(null                   , null                   ));
            colors.Add("bg-default"  , AddColor(null                   , null                   ));
            colors.Add("text-muted"  , AddColor(null                   , ConsoleColor.Gray      ));
            colors.Add("text-primary", AddColor(null                   , ConsoleColor.DarkGray  ));
            colors.Add("text-warning", AddColor(null                   , ConsoleColor.DarkYellow));
            colors.Add("text-danger" , AddColor(null                   , ConsoleColor.DarkRed   ));
            colors.Add("bg-muted"    , AddColor(ConsoleColor.Gray      , ConsoleColor.Black     ));
            colors.Add("bg-primary"  , AddColor(ConsoleColor.DarkGray  , ConsoleColor.White     ));
            colors.Add("bg-warning"  , AddColor(ConsoleColor.DarkYellow, ConsoleColor.White     ));
            colors.Add("bg-danger"   , AddColor(ConsoleColor.DarkRed   , ConsoleColor.White     ));
            colors.Add("text-success", AddColor(null                   , ConsoleColor.DarkGreen ));
            colors.Add("text-info"   , AddColor(null                   , ConsoleColor.DarkCyan  ));
            colors.Add("bg-success"  , AddColor(ConsoleColor.DarkGreen , ConsoleColor.White     ));
            colors.Add("bg-info"     , AddColor(ConsoleColor.DarkCyan  , ConsoleColor.White     ));
            _colors = colors;
        }
    }
}

