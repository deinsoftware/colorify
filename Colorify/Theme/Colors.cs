using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using ToolBox.Validations;
using Colorify.Terminal;

namespace Colorify.List
{
    public static class Colors
    {
    
        public static string txtStatus  (params bool[] values) {
            if (Bool.SomeFalse(values))
            {
                return txtMuted();
            } else {
                return txtPrimary();
            }
        }
        public static string txtDefault () { return "text-default"; }
        public static string txtMuted   () { return "text-muted"  ; }
        public static string txtPrimary () { return "text-primary"; }
        public static string txtSuccess () { return "text-success"; }
        public static string txtInfo    () { return "text-info"   ; }
        public static string txtWarning () { return "text-warning"; }
        public static string txtDanger  () { return "text-danger" ; }
        public static string bgDefault  () { return "bg-default"  ; }
        public static string bgMuted    () { return "bg-muted"    ; }
        public static string bgPrimary  () { return "bg-primary"  ; }
        public static string bgSuccess  () { return "bg-success"  ; }
        public static string bgInfo     () { return "bg-info"     ; }
        public static string bgWarning  () { return "bg-warning"  ; }
        public static string bgDanger   () { return "bg-danger"   ; }
    }
}

