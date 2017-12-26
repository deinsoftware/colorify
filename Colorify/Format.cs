using System;
using System.Collections.Generic;
using Colorify.Terminal;
using Colorify.UI;

namespace Colorify
{
    public class Format
    {
        Dictionary<string, Color> _theme {get; set;}

        public Format(ITheme theme){
            if (theme == null)
            {
                throw new ArgumentException(nameof(theme));
            }
            _theme = theme._colors;
        }



        void SetColor(string color = "text-default"){
            Color value;
            if (_theme.TryGetValue(color, out value))
            {
                Console.BackgroundColor = value._background;
                Console.ForegroundColor = value._foreground;
            } 
            else 
            {
                throw new KeyNotFoundException();
            }
        }

        void DefaultColor(string color = "bg-default")
        {
            var t = _theme[color];
            Console.BackgroundColor = t._background;
            Console.ForegroundColor = t._foreground;
            Console.Clear();
        }

        void ResetColor(){
            Console.ResetColor();
        }



        public void Write(string text, string color)
        {
            SetColor(color);
            Out.Write(text);
            ResetColor();
        }

        public void WriteLine(string text, string color)
        {
            SetColor(color);
            Out.WriteLine(text);
            ResetColor();
        }

        public void PadLeft(string text, string color)
        {
            SetColor(color);
            Out.PadLeft(text);
            ResetColor();
        }

        public void PadRight(string text, string color)
        {
            SetColor(color);
            Out.PadRight(text);
            ResetColor();
        }

        public void Extreme(string text, string color)
        {
            SetColor(color);
            string left = text.Split('|')[0];
            string right = text.Split('|')[1];
            Out.Extreme(left, right);
            ResetColor();
        }

        public void Repeat(string text, string color){
            SetColor(color);
            char c = ( String.IsNullOrEmpty(text) ? ' ' : text[0] );
            Out.RepeatLine(c);
            ResetColor();
        }

        public void Wrap(string text, string color){
            SetColor(color);
            Wrapper.Text(text);
            ResetColor();
        }
    }
}

