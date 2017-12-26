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



        void SetColor(string color){
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

        void DefaultColor(string color = Colors.bgDefault)
        {
            var t = _theme[color];
            Console.BackgroundColor = t._background;
            Console.ForegroundColor = t._foreground;
        }

        public void ResetColor(){
            Console.ResetColor();
        }



        public void Write(string text, string color = Colors.txtDefault)
        {
            SetColor(color);
            Out.Write(text);
        }

        public void WriteLine(string text, string color = Colors.txtDefault)
        {
            SetColor(color);
            Out.WriteLine(text);
        }

        public void AlignRight(string text, string color = Colors.txtDefault)
        {
            SetColor(color);
            Out.AlignRight(text);
        }

        public void AlignLeft(string text, string color = Colors.txtDefault)
        {
            SetColor(color);
            Out.AlignLeft(text);
        }

        public void Extreme(string text, string color = Colors.txtDefault)
        {
            SetColor(color);
            string left = text.Split('|')[0];
            string right = text.Split('|')[1];
            Out.Extreme(left, right);
        }

        public void Wrap(string text, string color = Colors.txtDefault){
            SetColor(color);
            Wrapper.Text(text);
        }

        public void RepeatLine(string text, string color = Colors.txtDefault){
            SetColor(color);
            char c = ( String.IsNullOrEmpty(text) ? ' ' : text[0] );
            Out.RepeatLine(c);
        }

        public void BlankLines(int lines, string color = Colors.txtDefault){
            SetColor(color);
            Out.BlankLines(lines);
        }
    }
}

