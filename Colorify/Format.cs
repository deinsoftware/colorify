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
            try
            {
                if (theme == null)
                {
                    throw new ArgumentException(nameof(theme));
                }
                _theme = theme._colors;
                DefaultColor();
            }
            catch (Exception)
            {
                throw;
            }
        }



        void SetColor(string color){
            try
            {
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
            catch (Exception)
            {
                throw;
            }
        }

        void DefaultColor(string color = Colors.bgDefault)
        {
            try
            {
                var t = _theme[color];
                Console.BackgroundColor = t._background;
                Console.ForegroundColor = t._foreground;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ResetColor(){
            try
            {
                Console.ResetColor();
                Clear();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Clear(){
            try
            {
                Console.Clear();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public void Write(string text, string color = Colors.txtDefault)
        {
            try
            {
                SetColor(color);
                Out.Write(text);
                DefaultColor();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void WriteLine(string text, string color = Colors.txtDefault)
        {
            try
            {
                SetColor(color);
                Out.WriteLine(text);
                DefaultColor();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AlignCenter(string text, string color = Colors.txtDefault)
        {
            try
            {
                SetColor(color);
                Out.AlignCenter(text);
                DefaultColor();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AlignRight(string text, string color = Colors.txtDefault)
        {
            try
            {
                SetColor(color);
                Out.AlignRight(text);
                DefaultColor();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AlignLeft(string text, string color = Colors.txtDefault)
        {
            try
            {
                SetColor(color);
                Out.AlignLeft(text);
                DefaultColor();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AlignSplit(string text, string color = Colors.txtDefault)
        {
            try
            {
                SetColor(color);
                string left = text.Split('|')[0];
                string right = text.Split('|')[1];
                Out.Extreme(left, right);
                DefaultColor();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Wrap(string text, string color = Colors.txtDefault){
            try
            {
                SetColor(color);
                Wrapper.Text(text);
                DefaultColor();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DivisionLine(char character){
            try
            {
                DivisionLine(character, Colors.txtDefault);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DivisionLine(char character, string color){
            try
            {
                SetColor(color);
                Out.DivisionLine(character);
                DefaultColor();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BlankLines(int lines = 1){
            try
            {
                BlankLines(lines, Colors.txtDefault);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BlankLines(string color){
            try
            {
                BlankLines(1, color);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BlankLines(int lines, string color = Colors.txtDefault){
            try
            {
                SetColor(color);
                Out.BlankLines(lines);
                DefaultColor();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
