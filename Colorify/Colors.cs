using System;
using ToolBox.Validations;

namespace Colorify
{
    public static class Colors
    {
        public const string txtDefault = "text-default";
        public const string txtMuted   = "text-muted"  ;
        public const string txtPrimary = "text-primary";
        public const string txtSuccess = "text-success";
        public const string txtInfo    = "text-info"   ;
        public const string txtWarning = "text-warning";
        public const string txtDanger  = "text-danger" ;
        public const string bgDefault  = "bg-default"  ;
        public const string bgMuted    = "bg-muted"    ;
        public const string bgPrimary  = "bg-primary"  ;
        public const string bgSuccess  = "bg-success"  ;
        public const string bgInfo     = "bg-info"     ;
        public const string bgWarning  = "bg-warning"  ;
        public const string bgDanger   = "bg-danger"   ;

        public static string txtStatus  (params bool[] values) {
            if (Bool.SomeFalse(values))
            {
                return txtMuted;
            } else {
                return txtPrimary;
            }
        }
    }
}

