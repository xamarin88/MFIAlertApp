using Android.App;
using Xamarin.Forms;
using MFIAlertApp.Droid.Interfaces;
using MFIAlertApp.Interfaces;
using Android.OS;

[assembly: Dependency(typeof(CloseApplication))]
namespace MFIAlertApp.Droid.Interfaces
{
    public class CloseApplication : ICloseApplication
    {
        public void closeApplication()
        {
            var activity = (Activity)Forms.Context;
            activity.FinishAffinity();

            int pid = Process.MyPid();
            Process.KillProcess(pid);
        }
    }
}