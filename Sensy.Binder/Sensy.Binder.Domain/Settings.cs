using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain
{
    public class Settings
    {
        private static readonly Settings instance = new Settings();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Settings()
        {
        }

        private Settings()
        {
        }

        public static Settings Instance
        {
            get
            {
                return instance;
            }
        }

        public static string PythonScriptPath { get; set; }
        public static string ChamberIPAddress { get; set; }
        public static string MeasurementDeviceComPort { get; set; }
        public static string ReportModelPath { get; set; }
        public static string ReportsDirectory { get; set; }
        public static string StepsDirectory { get; set; }
    }
}
