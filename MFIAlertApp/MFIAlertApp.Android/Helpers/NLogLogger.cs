using NLog;
using Xamarin.Forms;
using MFIAlertApp.Droid.Helpers;
using MFIAlertApp.Helpers;

[assembly: Dependency(typeof(NLogLogger))]
namespace MFIAlertApp.Droid.Helpers
{
    public class NLogLogger : MFIAlertApp.Interfaces.ILogger
    {
        private Logger log;

        string traceEnabled = ConfigurationService.GetConfigurationValue("traceEnabled");

        public NLogLogger(Logger log)
        {
            this.log = log;
        }

        public void Debug(string text, params object[] args)
        {
            if (traceEnabled == "1") { log.Debug(text, args); }
        }

        public void Error(string text, params object[] args)
        {
            if (traceEnabled == "1") { log.Error(text, args); }
        }

        public void Fatal(string text, params object[] args)
        {
            if (traceEnabled == "1") { log.Fatal(text, args); }
        }

        public void Info(string text, params object[] args)
        {
            if (traceEnabled == "1") { log.Info(text, args); }
        }

        public void Trace(string text, params object[] args)
        {
            if (traceEnabled == "1") { log.Trace(text, args); }
        }

        public void Warn(string text, params object[] args)
        {
            if (traceEnabled == "1") { log.Warn(text, args); }
        }
    }
}
