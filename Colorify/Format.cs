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
            DefaultColor();
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
            Console.Clear();
        }

        public void ResetColor(){
            Console.ResetColor();
            Clear();
        }

        public void Clear(){
            Console.Clear();
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

        public void AlignCenter(string text, string color = Colors.txtDefault)
        {
            SetColor(color);
            Out.AlignCenter(text);
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

        public void AlignSplit(string text, string color = Colors.txtDefault)
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

        public void RepeatLine(char character){
            RepeatLine(character, Colors.txtDefault);
        }

        public void RepeatLine(char character, string color){
            SetColor(color);
            Out.RepeatLine(character);
        }

        public void BlankLines(int lines = 1){
            BlankLines(lines, Colors.txtDefault);
        }

        public void BlankLines(string color){
            BlankLines(1, color);
        }

        public void BlankLines(int lines, string color = Colors.txtDefault){
            SetColor(color);
            Out.BlankLines(lines);
        }
    }
}

