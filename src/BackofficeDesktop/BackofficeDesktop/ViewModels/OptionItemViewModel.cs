using System.ComponentModel.Composition;
using BackofficeDesktop.Services;

namespace BackofficeDesktop.ViewModels
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Export(typeof (OptionItemViewModel))]
    public class OptionItemViewModel
    {
        private readonly AppLauncher _appLauncher;

        [ImportingConstructor]
        public OptionItemViewModel(AppLauncher launcher)
        {
            _appLauncher = launcher;
        }

        public string Caption { get; set; }
        public string CommandLine { get; set; }

        public void RunItem()
        {
            _appLauncher.Launch(CommandLine);
        }
    }
}