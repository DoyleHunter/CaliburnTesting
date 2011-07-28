using Caliburn.Micro;

namespace BackofficeDesktop.ViewModels
{
    public class ShellViewModel : PropertyChangedBase
    {
        private TopMenuViewModel _topMenu;
        private OptionsViewModel _options;

        public ShellViewModel()
        {
            _topMenu = new TopMenuViewModel();
            _options = new OptionsViewModel();
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
