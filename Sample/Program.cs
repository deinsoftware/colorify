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
            Console.ReadKey();
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
        }

        static void Sample(){
            _format.PadLeft("Left text", Colors.txtDefault);
            _format.PadRight("Right text", Colors.txtDefault);
        }
    }
}
