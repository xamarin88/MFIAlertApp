﻿using System;
using System.IO;
using Xamarin.Forms;
using NLog;
using NLog.Config;
using NLog.Targets;
using MFIAlertApp.iOS.Helpers;

[assembly: Dependency(typeof(NLogManager))]
namespace MFIAlertApp.iOS.Helpers
{
    public class NLogManager : MFIAlertApp.Interfaces.ILogManager
    {
        public NLogManager()
        {
            var config = new LoggingConfiguration();

            var consoleTarget = new ConsoleTarget();
            config.AddTarget("console", consoleTarget);

            var consoleRule = new LoggingRule("*", LogLevel.Trace, consoleTarget);
            config.LoggingRules.Add(consoleRule);

            var fileTarget = new FileTarget();
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            fileTarget.FileName = Path.Combine(folder, "Log.txt");
            config.AddTarget("file", fileTarget);

            var fileRule = new LoggingRule("*", LogLevel.Warn, fileTarget);
            config.LoggingRules.Add(fileRule);

            LogManager.Configuration = config;
        }
        public MFIAlertApp.Interfaces.ILogger GetLog([System.Runtime.CompilerServices.CallerFilePath] string callerFilePath = "")
        {
            string fileName = callerFilePath;

            if (fileName.Contains("/"))
            {
                fileName = fileName.Substring(fileName.LastIndexOf("/", StringComparison.CurrentCultureIgnoreCase) + 1);
            }

            var logger = LogManager.GetLogger(fileName);
            return new NLogLogger(logger);
        }
    }
}
