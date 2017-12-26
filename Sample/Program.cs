using System;
using Colorify;
using Colorify.UI;
using ToolBox.Platform;

namespace Sample
{
    class Program
    {
        private static Format _format {get; set;}

        static void Main(string[] args)
        {
            switch (OS.GetCurrent())
            {
                case "win":
                    _format = new Format(Theme.Win);
                    break;
                case "mac":
                    _format = new Format(Theme.Mac);
                    break;
            }
            Menu();
            _format.ResetColor();
        }

        static void Menu(){
            _format.Clear();
            _format.RepeatLine('=', Colorify.Colors.bgInfo);
            _format.AlignCenter("COLORIFY SAMPLE", Colorify.Colors.bgInfo);
            _format.RepeatLine('=', Colorify.Colors.bgInfo);
            _format.BlankLines();
            _format.Write($"{" 1]", -4}"); _format.WriteLine("Colors");
            _format.Write($"{" 2]", -4}"); _format.WriteLine("Write");
            _format.Write($"{" 3]", -4}"); _format.WriteLine("WriteLine");
            _format.Write($"{" 4]", -4}"); _format.WriteLine("Text Align");
            _format.Write($"{" 5]", -4}"); _format.WriteLine("Blank Lines");
            _format.Write($"{" 6]", -4}"); _format.WriteLine("Division Lines");
            _format.BlankLines();
            _format.AlignRight("[X] Exit ", Colorify.Colors.txtDanger);
            _format.BlankLines();
            _format.RepeatLine('=', Colorify.Colors.bgInfo);
            _format.BlankLines();
            _format.Write($"{" Make your choice:", -25}");
            string opt = Console.ReadLine();
            opt = opt.ToLower();

            _format.Clear();
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
            _format.BlankLines();
            _format.Write("Press [ANY] key to continue ");
            Console.ReadKey();
            Menu();
        }

        static void Colors(){
            _format.WriteLine("Text Default", Colorify.Colors.txtDefault);
            _format.WriteLine("Text Muted", Colorify.Colors.txtMuted);
            _format.WriteLine("Text Primary", Colorify.Colors.txtPrimary);
            _format.WriteLine("Text Success", Colorify.Colors.txtSuccess);
            _format.WriteLine("Text Info", Colorify.Colors.txtInfo);
            _format.WriteLine("Text Warning", Colorify.Colors.txtWarning);
            _format.WriteLine("Text Danger", Colorify.Colors.txtDanger);
            _format.WriteLine("Background Default", Colorify.Colors.bgDefault);
            _format.WriteLine("Background Muted", Colorify.Colors.bgMuted);
            _format.WriteLine("Background Primary", Colorify.Colors.bgPrimary);
            _format.WriteLine("Background Success", Colorify.Colors.bgSuccess);
            _format.WriteLine("Background Info", Colorify.Colors.bgInfo);
            _format.WriteLine("Background Warning", Colorify.Colors.bgWarning);
            _format.WriteLine("Background Danger", Colorify.Colors.bgDanger);

            Back();
        }

        static void Write(){
            _format.Write(    " Default ", Colorify.Colors.bgDefault);
            _format.Write(    " Muted   ", Colorify.Colors.bgMuted);
            _format.Write(    " Primary ", Colorify.Colors.bgPrimary);
            _format.Write(    " Success ", Colorify.Colors.bgSuccess);
            _format.Write(    " Info    ", Colorify.Colors.bgInfo);
            _format.Write(    " Warning ", Colorify.Colors.bgWarning);
            _format.WriteLine(" Danger  ", Colorify.Colors.bgDanger);
            
            Back();
        }

        static void WriteLine(){
            _format.Write("Short Text at First Preceded with a ", Colorify.Colors.bgInfo);
            _format.WriteLine(" Long Multilinetext with Line Wrap that bring a new line", Colorify.Colors.bgSuccess);

            Back();
        }

        static void TextAlign(){
            _format.AlignCenter("Text Aligned to Center", Colorify.Colors.bgInfo);
            _format.AlignRight("Text Aligned to Right", Colorify.Colors.txtDefault);
            _format.AlignLeft("Text Aligned to Left", Colorify.Colors.txtDanger);
            _format.AlignSplit("<-Left|Right->", Colorify.Colors.bgSuccess);

            Back();
        }

        static void BlankLines(){
            _format.BlankLines();
            _format.BlankLines(Colorify.Colors.bgDanger);
            _format.BlankLines(3);
            _format.BlankLines(3, Colorify.Colors.bgSuccess);

            Back();
        }

        static void DivisionLines(){
            _format.RepeatLine('-', Colorify.Colors.bgDefault);
            _format.RepeatLine('+', Colorify.Colors.bgMuted);
            _format.RepeatLine('~', Colorify.Colors.bgPrimary);
            _format.RepeatLine('=', Colorify.Colors.bgSuccess);
            _format.RepeatLine('-', Colorify.Colors.bgInfo);
            _format.RepeatLine('*', Colorify.Colors.bgWarning);
            _format.RepeatLine('.', Colorify.Colors.bgDanger);

            Back();
        }
    }
}
