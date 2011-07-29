using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using BackofficeDesktop.Messages;
using BackofficeDesktop.Services;
using Caliburn.Micro;

namespace BackofficeDesktop.ViewModels
{
    [Export(typeof (OptionsViewModel))]
    public class OptionsViewModel : PropertyChangedBase, IHandle<TopMenuItemSelected>
    {
        private readonly NavigationDataFeed _navData;
        private readonly IEventAggregator _pubsub;

        [ImportingConstructor]
        public OptionsViewModel(IEventAggregator pubsub, NavigationDataFeed navData)
        {
            _pubsub = pubsub;
            _navData = navData;

            _pubsub.Subscribe(this);
        }

        public ObservableCollection<OptionItemViewModel> OptionItems { get; set; }

        #region IHandle<TopMenuItemSelected> Members

        public void Handle(TopMenuItemSelected message)
        {
            List<ApplicationItem> items = _navData.GetOptionsForGroup(message.Caption);

            OptionItems = new ObservableCollection<OptionItemViewModel>(items.Select(CreateOptionItem));

            NotifyOfPropertyChange(() => OptionItems);
        }

        #endregion

        private static OptionItemViewModel CreateOptionItem(ApplicationItem item)
        {
            var optionItemViewModel = IoC.Get<OptionItemViewModel>();
            optionItemViewModel.Caption = item.Caption;
            optionItemViewModel.CommandLine = item.CommandLine;

            return optionItemViewModel;
        }
    }
}