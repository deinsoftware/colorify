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
            _format.RepeatLine('=', Colors.bgInfo);
            _format.AlignCenter("COLORIFY SAMPLE", Colors.bgInfo);
            _format.RepeatLine('=', Colors.bgInfo);
            _format.BlankLines();
            _format.Write($"{" 1]", -4}"); _format.WriteLine("Colors Combination");
            _format.Write($"{" 2]", -4}"); _format.WriteLine("Write and Write Line");
            _format.Write($"{" 3]", -4}"); _format.WriteLine("Text Align");
            _format.Write($"{" 4]", -4}"); _format.WriteLine("Blank Lines");
            _format.Write($"{" 5]", -4}"); _format.WriteLine("Division Lines");
            _format.BlankLines();
            _format.AlignRight("[X] Exit ", Colors.txtDanger);
            _format.BlankLines();
            _format.RepeatLine('=', Colors.bgInfo);
            _format.BlankLines();
            _format.Write($"{" Make your choice:", -25}");
            string opt = Console.ReadLine();
            opt = opt.ToLower();

            _format.Clear();
            switch (opt)
            {
                case "1": ColorsCombination(); break;
                case "2": WriteAndWriteLine(); break;
                case "3": TextAlign(); break;
                case "4": BlankLines(); break;
                case "5": DivisionLines(); break;
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

        static void ColorsCombination(){
            _format.WriteLine("Text Default", Colors.txtDefault);
            _format.WriteLine("Text Muted", Colors.txtMuted);
            _format.WriteLine("Text Primary", Colors.txtPrimary);
            _format.WriteLine("Text Success", Colors.txtSuccess);
            _format.WriteLine("Text Info", Colors.txtInfo);
            _format.WriteLine("Text Warning", Colors.txtWarning);
            _format.WriteLine("Text Danger", Colors.txtDanger);
            _format.WriteLine("Background Default", Colors.bgDefault);
            _format.WriteLine("Background Muted", Colors.bgMuted);
            _format.WriteLine("Background Primary", Colors.bgPrimary);
            _format.WriteLine("Background Success", Colors.bgSuccess);
            _format.WriteLine("Background Info", Colors.bgInfo);
            _format.WriteLine("Background Warning", Colors.bgWarning);
            _format.WriteLine("Background Danger", Colors.bgDanger);

            Back();
        }

        static void WriteAndWriteLine(){
            _format.Clear();
            _format.Write(    " Default ", Colors.bgDefault);
            _format.Write(    " Muted   ", Colors.bgMuted);
            _format.Write(    " Primary ", Colors.bgPrimary);
            _format.Write(    " Success ", Colors.bgSuccess);
            _format.Write(    " Info    ", Colors.bgInfo);
            _format.Write(    " Warning ", Colors.bgWarning);
            _format.WriteLine(" Danger  ", Colors.bgDanger);
            _format.BlankLines();
            _format.Write("Short Text at First Preceded with a ", Colors.bgInfo);
            _format.WriteLine(" Long Multilinetext with Line Wrap that bring a new line", Colors.bgSuccess);

            Back();
        }

        static void TextAlign(){
            _format.AlignCenter("Text Aligned to Center", Colors.bgInfo);
            _format.AlignRight("Text Aligned to Right", Colors.txtDefault);
            _format.AlignLeft("Text Aligned to Left", Colors.txtDanger);
            _format.Extreme("<-Left|Right->", Colors.bgSuccess);

            Back();
        }

        static void BlankLines(){
            _format.BlankLines();
            _format.BlankLines(Colors.bgDanger);
            _format.BlankLines(3);
            _format.BlankLines(3, Colors.bgSuccess);

            Back();
        }

        static void DivisionLines(){
            _format.RepeatLine('-', Colors.bgDefault);
            _format.RepeatLine('+', Colors.bgMuted);
            _format.RepeatLine('~', Colors.bgPrimary);
            _format.RepeatLine('=', Colors.bgSuccess);
            _format.RepeatLine('-', Colors.bgInfo);
            _format.RepeatLine('*', Colors.bgWarning);
            _format.RepeatLine('.', Colors.bgDanger);

            Back();
        }
    }
}
