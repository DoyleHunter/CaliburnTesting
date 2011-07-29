using System.ComponentModel.Composition;
using System.Diagnostics;

namespace BackofficeDesktop.Services
{
    [Export(typeof (AppLauncher))]
    public class AppLauncher
    {
        public void Launch(string path)
        {
            Process.Start(path);
        }
    }
}