using System;
using Colorify;
using Colorify.UI;
using ToolBox.Platform;

namespace Sample
{
    class Program
    {
        private static Format _colorify {get; set;}

        static void Main(string[] args)
        {
            switch (OS.GetCurrent())
            {
                case "win":
                    _colorify = new Format(Theme.Win);
                    break;
                case "mac":
                    _colorify = new Format(Theme.Mac);
                    break;
            }
            Menu();
            _colorify.ResetColor();
        }

        static void Menu(){
            _colorify.Clear();
            _colorify.RepeatLine('=', Colorify.Colors.bgInfo);
            _colorify.AlignCenter("COLORIFY SAMPLE", Colorify.Colors.bgInfo);
            _colorify.RepeatLine('=', Colorify.Colors.bgInfo);
            _colorify.BlankLines();
            _colorify.Write($"{" 1]", -4}"); _colorify.WriteLine("Colors");
            _colorify.Write($"{" 2]", -4}"); _colorify.WriteLine("Write");
            _colorify.Write($"{" 3]", -4}"); _colorify.WriteLine("WriteLine");
            _colorify.Write($"{" 4]", -4}"); _colorify.WriteLine("Text Align");
            _colorify.Write($"{" 5]", -4}"); _colorify.WriteLine("Blank Lines");
            _colorify.Write($"{" 6]", -4}"); _colorify.WriteLine("Division Lines");
            _colorify.BlankLines();
            _colorify.AlignRight("[X] Exit ", Colorify.Colors.txtDanger);
            _colorify.BlankLines();
            _colorify.RepeatLine('=', Colorify.Colors.bgInfo);
            _colorify.BlankLines();
            _colorify.Write($"{" Make your choice:", -25}");
            string opt = Console.ReadLine();
            opt = opt.ToLower();

            _colorify.Clear();
            switch (opt)
            {
                case "1": Colors(); break;
                case "2": Write(); break;
                case "3": WriteLine(); break;
                case "4": TextAlign(); break;
                case "5": BlankLines(); break;
                case "6": DivisionLines(); break;
                case "x": break;
                default: Menu(); break;
            }
        }

        static void Back(){
            _colorify.BlankLines();
            _colorify.Write("Press [ANY] key to continue ");
            Console.ReadKey();
            Menu();
        }

        static void Colors(){
            _colorify.WriteLine("Text Default", Colorify.Colors.txtDefault);
            _colorify.WriteLine("Text Muted", Colorify.Colors.txtMuted);
            _colorify.WriteLine("Text Primary", Colorify.Colors.txtPrimary);
            _colorify.WriteLine("Text Success", Colorify.Colors.txtSuccess);
            _colorify.WriteLine("Text Info", Colorify.Colors.txtInfo);
            _colorify.WriteLine("Text Warning", Colorify.Colors.txtWarning);
            _colorify.WriteLine("Text Danger", Colorify.Colors.txtDanger);
            _colorify.WriteLine("Background Default", Colorify.Colors.bgDefault);
            _colorify.WriteLine("Background Muted", Colorify.Colors.bgMuted);
            _colorify.WriteLine("Background Primary", Colorify.Colors.bgPrimary);
            _colorify.WriteLine("Background Success", Colorify.Colors.bgSuccess);
            _colorify.WriteLine("Background Info", Colorify.Colors.bgInfo);
            _colorify.WriteLine("Background Warning", Colorify.Colors.bgWarning);
            _colorify.WriteLine("Background Danger", Colorify.Colors.bgDanger);

            Back();
        }

        static void Write(){
            _colorify.Write(    " Default ", Colorify.Colors.bgDefault);
            _colorify.Write(    " Muted   ", Colorify.Colors.bgMuted);
            _colorify.Write(    " Primary ", Colorify.Colors.bgPrimary);
            _colorify.Write(    " Success ", Colorify.Colors.bgSuccess);
            _colorify.Write(    " Info    ", Colorify.Colors.bgInfo);
            _colorify.Write(    " Warning ", Colorify.Colors.bgWarning);
            _colorify.WriteLine(" Danger  ", Colorify.Colors.bgDanger);
            
            Back();
        }

        static void WriteLine(){
            _colorify.Write("Short Text at First Preceded with a ", Colorify.Colors.bgInfo);
            _colorify.WriteLine(" Long Multilinetext with Line Wrap that bring a new line", Colorify.Colors.bgSuccess);

            Back();
        }

        static void TextAlign(){
            _colorify.AlignCenter("Text Aligned to Center", Colorify.Colors.bgInfo);
            _colorify.AlignRight("Text Aligned to Right", Colorify.Colors.txtDefault);
            _colorify.AlignLeft("Text Aligned to Left", Colorify.Colors.txtDanger);
            _colorify.AlignSplit("<-Left|Right->", Colorify.Colors.bgSuccess);

            Back();
        }

        static void BlankLines(){
            _colorify.BlankLines();
            _colorify.BlankLines(Colorify.Colors.bgDanger);
            _colorify.BlankLines(3);
            _colorify.BlankLines(3, Colorify.Colors.bgSuccess);

            Back();
        }

        static void DivisionLines(){
            _colorify.RepeatLine('-', Colorify.Colors.bgDefault);
            _colorify.RepeatLine('+', Colorify.Colors.bgMuted);
            _colorify.RepeatLine('~', Colorify.Colors.bgPrimary);
            _colorify.RepeatLine('=', Colorify.Colors.bgSuccess);
            _colorify.RepeatLine('-', Colorify.Colors.bgInfo);
            _colorify.RepeatLine('*', Colorify.Colors.bgWarning);
            _colorify.RepeatLine('.', Colorify.Colors.bgDanger);

            Back();
        }
    }
}
