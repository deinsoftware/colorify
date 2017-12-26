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
        public Dictionary<string, Color> Colors {get; set;}

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
            Colors.Add("text-default", AddColor(null                   , null                   ));
            Colors.Add("bg-default"  , AddColor(null                   , null                   ));
            Colors.Add("text-muted"  , AddColor(null                   , ConsoleColor.DarkGray  ));
            Colors.Add("text-primary", AddColor(null                   , ConsoleColor.Gray      ));
            Colors.Add("text-warning", AddColor(null                   , ConsoleColor.Yellow    ));
            Colors.Add("text-danger" , AddColor(null                   , ConsoleColor.Red       ));
            Colors.Add("bg-muted"    , AddColor(ConsoleColor.DarkGray  , ConsoleColor.Black     ));
            Colors.Add("bg-primary"  , AddColor(ConsoleColor.Gray      , ConsoleColor.White     ));
            Colors.Add("bg-warning"  , AddColor(ConsoleColor.Yellow    , ConsoleColor.Black     ));
            Colors.Add("bg-danger"   , AddColor(ConsoleColor.Red       , ConsoleColor.White     ));
            Colors.Add("text-success", AddColor(null                   , ConsoleColor.DarkGreen ));
            Colors.Add("text-info"   , AddColor(null                   , ConsoleColor.DarkCyan  ));
            Colors.Add("bg-success"  , AddColor(ConsoleColor.DarkGreen , ConsoleColor.White     ));
            Colors.Add("bg-info"     , AddColor(ConsoleColor.DarkCyan  , ConsoleColor.White     ));
        }
    }
}

