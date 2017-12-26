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
            Sample();
            Console.ReadKey();
            _format.ResetColor();
        }

        static void Sample(){
            _format.AlignRight("Right text", Colors.txtDefault);
            _format.AlignLeft("Left text");
            _format.Extreme("<-Left->|<-Right->");
            _format.BlankLines(2);
        }
    }
}
