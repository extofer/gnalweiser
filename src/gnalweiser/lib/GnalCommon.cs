using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace gnalweiser.lib
{
    public static class GnalCommon
    {
        private static readonly string appname = ConfigurationManager.AppSettings["AppName"];
        private static readonly string logFile = ConfigurationManager.AppSettings["LogFile"];

        public static string LogFile
        {
            get { return logFile; }
        }

        public static string GetVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfo.ProductVersion;

            return appname + version;

        }

        public static bool ValidateText(string txt)
        {
            if (txt == "" || txt == string.Empty)
            {
                return false;
            }
            return true;
        }

    }
}
