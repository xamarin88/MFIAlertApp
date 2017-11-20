using System;

namespace MFIAlertApp.Interfaces
{
    public interface ILogManager
    {
        ILogger GetLog([System.Runtime.CompilerServices.CallerFilePath]string callerFilePath = "");
    }
}
