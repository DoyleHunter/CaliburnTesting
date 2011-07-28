using Caliburn.Micro;

namespace BackofficeDesktop.ViewModels
{
    public interface IShell 
    {}

    public class ShellViewModel : PropertyChangedBase, IShell
    {
        private readonly TopMenuViewModel _topMenu;
        private readonly OptionsViewModel _options;

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
