using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Media;
using System.Resources;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Threading;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Forms.VisualStyles;
using System.Windows.Threading;
using Clio.Utilities;
using Common.Logging.Simple;
using ff14bot;
using ff14bot.Enums;
using ff14bot.Helpers;

using  rlogging = ff14bot.Helpers.Logging;

namespace Assimilator.Helpers
{
    internal static class LogColors
    {
        internal static Color Error => Colors.OrangeRed;
        internal static Color Info => Colors.MediumOrchid;
        internal static Color Verbose => Colors.BlueViolet;
        internal static Color Warn => Colors.Goldenrod;
    }
    public class Logger
    {
        public static List<string> LogList = new List<string>();
        internal static string Name => "Assimilator";
        internal static string Prefix => $"[{Name}] ";
        private static void Log(Color c, string message, object[] args) 
        {
            rlogging.Write(c, Prefix + string.Format(message, args));

            var logStr = "[" + DateTime.Now + "]" + " " + Prefix + string.Format(message, args);
            if(LogList.Count >= 50) 
                LogList.RemoveAt(0);
            if(!LogList.Contains(logStr))
                LogList.Add(logStr);
        }

        [StringFormatMethod("format")]
        internal static void Error(string message, params object[] args)
        {
            Log(LogColors.Error, message, args);
        }

        public static void Info(string message, params object[] args)
        {
            Log(LogColors.Info, message, args);
        }
        public static void Verbose(string message, params object[] args) 
        {
            Log(LogColors.Verbose, message, args);
        }

        public static void Warn(string message, params object[] args)
        {
            Log(LogColors.Warn, message, args);
        }

    }
}