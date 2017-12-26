using System;
using System.Collections.Generic;

namespace Colorify.UI
{
    public static partial class Theme
    {
        public static ITheme Win
        {
            get
            {
                return new ThemeWin();
            }
        }
    }

    public sealed class ThemeWin : ITheme
    {
        public ThemeWin(){
            SetColors();
        }

        public Dictionary<string, Color> _colors {get; set;}

        public ConsoleColor DefaultBackground(){
            return ConsoleColor.Black;
        }

        public ConsoleColor DefaultForeground(){
            return ConsoleColor.White;
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
            _colors.Add("text-default", AddColor(null                   , null                   ));
            _colors.Add("bg-default"  , AddColor(null                   , null                   ));
            _colors.Add("text-muted"  , AddColor(null                   , ConsoleColor.DarkGray  ));
            _colors.Add("text-primary", AddColor(null                   , ConsoleColor.Gray      ));
            _colors.Add("text-warning", AddColor(null                   , ConsoleColor.Yellow    ));
            _colors.Add("text-danger" , AddColor(null                   , ConsoleColor.Red       ));
            _colors.Add("bg-muted"    , AddColor(ConsoleColor.DarkGray  , ConsoleColor.Black     ));
            _colors.Add("bg-primary"  , AddColor(ConsoleColor.Gray      , ConsoleColor.White     ));
            _colors.Add("bg-warning"  , AddColor(ConsoleColor.Yellow    , ConsoleColor.Black     ));
            _colors.Add("bg-danger"   , AddColor(ConsoleColor.Red       , ConsoleColor.White     ));
            _colors.Add("text-success", AddColor(null                   , ConsoleColor.DarkGreen ));
            _colors.Add("text-info"   , AddColor(null                   , ConsoleColor.DarkCyan  ));
            _colors.Add("bg-success"  , AddColor(ConsoleColor.DarkGreen , ConsoleColor.White     ));
            _colors.Add("bg-info"     , AddColor(ConsoleColor.DarkCyan  , ConsoleColor.White     ));
            _colors = colors;
        }
    }
}

