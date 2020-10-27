using System;
using System.Collections.Generic;
using System.Text;

namespace Sensy.Binder.Domain
{
    public static class Settings
    {
        public static string PythonScriptPath { get; set; }
        public static string ChamberIPAddress { get; set; }
        public static string MeasurementDeviceComPort { get; set; }
        public static string ReportModelPath { get; set; }
        public static string ReportsDirectory { get; set; }
        public static string StepsDirectory { get; set; }
    }
}
