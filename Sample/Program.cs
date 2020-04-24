using System;
using Colorify;
using static Colorify.Colors;
using Colorify.UI;
using ToolBox.Platform;

namespace Sample
{
    static class Program
    {
        private static Format _colorify { get; set; }

        static void Main(string[] args)
        {
            try
            {
                switch (OS.GetCurrent())
                {
                    case "win":
                        _colorify = new Format(Theme.Dark);
                        break;
                    case "gnu":
                        _colorify = new Format(new ThemeDark());
                        break;
                    case "mac":
                        _colorify = new Format(Theme.Light);
                        break;
                }
                Menu();
                _colorify.ResetColor();
                _colorify.Clear();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageException("Ahh my eyes! Why this console is too small?");
            }
            catch (Exception ex)
            {
                MessageException(ex.ToString());
            }
        }

        static void Menu()
        {
            _colorify.Clear();
            _colorify.DivisionLine('=', Colorify.Colors.bgInfo);
            _colorify.AlignCenter("COLORIFY SAMPLE", Colorify.Colors.bgInfo);
            _colorify.DivisionLine('=', Colorify.Colors.bgInfo);
            _colorify.BlankLines();
            _colorify.Write($"{" 1]",-4}"); _colorify.WriteLine("Colors");
            _colorify.Write($"{" 2]",-4}"); _colorify.WriteLine("Write");
            _colorify.Write($"{" 3]",-4}"); _colorify.WriteLine("WriteLine");
            _colorify.Write($"{" 4]",-4}"); _colorify.WriteLine("Text Align");
            _colorify.Write($"{" 5]",-4}"); _colorify.WriteLine("Blank Lines");
            _colorify.Write($"{" 6]",-4}"); _colorify.WriteLine("Division Lines");
            _colorify.BlankLines();
            _colorify.Write($"{" D]",-4}"); _colorify.WriteLine("Theme Dark");
            _colorify.Write($"{" L]",-4}"); _colorify.WriteLine("Theme Light");
            _colorify.BlankLines();
            _colorify.AlignRight("[X] Exit ", Colorify.Colors.txtDanger);
            _colorify.BlankLines();
            _colorify.DivisionLine('=', Colorify.Colors.bgInfo);
            _colorify.BlankLines();
            _colorify.Write($"{" Make your choice:",-25}");
            string opt = Console.ReadLine();
            opt = opt.ToLower();

            _colorify.Clear();
            switch (opt)
            {
                case "1": ThemeColors(); break;
                case "2": Write(); break;
                case "3": WriteLine(); break;
                case "4": TextAlign(); break;
                case "5": BlankLines(); break;
                case "6": DivisionLine(); break;
                case "d":
                case "l":
                    ThemeSwitch(opt);
                    break;
                case "x": break;
                default: Menu(); break;
            }
        }

        static void Back()
        {
            _colorify.BlankLines();
            _colorify.Write("Press [ANY] key to continue ");
            Console.ReadKey();
            Menu();
        }

        static void MessageException(string message)
        {
            _colorify.ResetColor();
            _colorify.Clear();
            _colorify.WriteLine(message, bgDanger);
        }

        static void ThemeColors()
        {
            try
            {
                _colorify.WriteLine("Text Default", txtDefault);
                _colorify.WriteLine("Text Muted", txtMuted);
                _colorify.WriteLine("Text Primary", txtPrimary);
                _colorify.WriteLine("Text Success", txtSuccess);
                _colorify.WriteLine("Text Info", txtInfo);
                _colorify.WriteLine("Text Warning", txtWarning);
                _colorify.WriteLine("Text Danger", txtDanger);
                _colorify.WriteLine("Background Default", bgDefault);
                _colorify.WriteLine("Background Muted", bgMuted);
                _colorify.WriteLine("Background Primary", bgPrimary);
                _colorify.WriteLine("Background Success", bgSuccess);
                _colorify.WriteLine("Background Info", bgInfo);
                _colorify.WriteLine("Background Warning", bgWarning);
                _colorify.WriteLine("Background Danger", bgDanger);

                Back();
            }
            catch (Exception ex)
            {
                MessageException(ex.ToString());
            }
        }

        static void Write()
        {
            try
            {
                _colorify.Write(" Default ", bgDefault);
                _colorify.Write(" Muted   ", bgMuted);
                _colorify.Write(" Primary ", bgPrimary);
                _colorify.Write(" Success ", bgSuccess);
                _colorify.Write(" Info    ", bgInfo);
                _colorify.Write(" Warning ", bgWarning);
                _colorify.WriteLine(" Danger  ", bgDanger);

                Back();
            }
            catch (Exception ex)
            {
                MessageException(ex.ToString());
            }
        }

        static void WriteLine()
        {
            try
            {
                _colorify.Write("Short Text at First Preceded with a ", bgInfo);
                _colorify.WriteLine(" Long Multi line text with Line Wrap that bring a new line", bgSuccess);
                _colorify.Wrap("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed turpis in ligula aliquet ornare tristique sed ante. Nam pretium ullamcorper condimentum. Aliquam quis sodales ex, vitae gravida metus. Suspendisse potenti. Maecenas nunc sapien, semper vel tincidunt sed, scelerisque ut est. Nunc eu venenatis libero. Nulla consectetur pretium leo. Nullam suscipit scelerisque neque fringilla volutpat. Aliquam condimentum, neque quis malesuada ultrices, mauris velit tincidunt arcu, vel sodales tortor felis quis velit. Aliquam tempus ullamcorper orci, vitae pretium leo maximus ut. Aliquam iaculis leo sed tempor mattis.", bgWarning);

                Back();
            }
            catch (Exception ex)
            {
                MessageException(ex.ToString());
            }
        }

        static void TextAlign()
        {
            try
            {
                _colorify.AlignCenter("Text Aligned to Center", bgInfo);
                _colorify.AlignRight("Text Aligned to Right", txtDefault);
                _colorify.AlignLeft("Text Aligned to Left", txtDanger);
                _colorify.AlignSplit("<-Left|Right->", bgSuccess);

                Back();
            }
            catch (Exception ex)
            {
                MessageException(ex.ToString());
            }
        }

        static void BlankLines()
        {
            try
            {
                _colorify.BlankLines();
                _colorify.BlankLines(Colors.bgDanger);
                _colorify.BlankLines(3);
                _colorify.BlankLines(3, bgSuccess);

                Back();
            }
            catch (Exception ex)
            {
                MessageException(ex.ToString());
            }
        }

        static void DivisionLine()
        {
            try
            {
                _colorify.DivisionLine('-', Colorify.Colors.bgDefault);
                _colorify.DivisionLine('+', Colorify.Colors.bgMuted);
                _colorify.DivisionLine('~', Colorify.Colors.bgPrimary);
                _colorify.DivisionLine('=', Colorify.Colors.bgSuccess);
                _colorify.DivisionLine('-', Colorify.Colors.bgInfo);
                _colorify.DivisionLine('*', Colorify.Colors.bgWarning);
                _colorify.DivisionLine('.', Colorify.Colors.bgDanger);

                Back();
            }
            catch (Exception ex)
            {
                MessageException(ex.ToString());
            }
        }

        public static void ThemeSwitch(string option)
        {
            if (!String.IsNullOrEmpty(option))
            {
                switch (option)
                {
                    case "d":
                        _colorify = new Format(Theme.Dark);
                        break;
                    case "l":
                        _colorify = new Format(Theme.Light);
                        break;
                }
            }
            Menu();
        }
    }
}
