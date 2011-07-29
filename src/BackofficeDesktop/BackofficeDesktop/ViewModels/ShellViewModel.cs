using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace BackofficeDesktop.ViewModels
{
    public interface IShell
    {
    }

    [Export(typeof (IShell))]
    public class ShellViewModel : PropertyChangedBase, IShell
    {
        private readonly OptionsViewModel _options;
        private readonly TopMenuViewModel _topMenu;

        [ImportingConstructor]
        public ShellViewModel(TopMenuViewModel topMenu, OptionsViewModel options)
        {
            _topMenu = topMenu;
            _options = options;
        }

        public TopMenuViewModel TopMenu
        {
            get { return _topMenu; }
        }

        public OptionsViewModel Options
        {
            get { return _options; }
        }
    }
}