using System.Threading;
using Xamarin.Forms;
using MFIAlertApp.iOS.Interfaces;
using MFIAlertApp.Interfaces;

[assembly: Dependency(typeof(CloseApplication))]
namespace MFIAlertApp.iOS.Interfaces
{
    public class CloseApplication : ICloseApplication
    {
        public void closeApplication()
        {
            Thread.CurrentThread.Abort();
        }
    }
}