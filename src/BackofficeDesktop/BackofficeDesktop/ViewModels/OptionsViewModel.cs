using System;
using System.Collections.ObjectModel;
using BackofficeDesktop.Messages;
using Caliburn.Micro;

namespace BackofficeDesktop.ViewModels
{
    public class OptionsViewModel : IHandle<TopMenuItemSelected>
    {
        private readonly IEventAggregator _pubsub;

        public OptionsViewModel(IEventAggregator pubsub)
        {
            _pubsub = pubsub;
        }

        public void Handle(TopMenuItemSelected message)
        {
            OptionItems = new ObservableCollection<OptionItemViewModel>
                (
                    new[] { new OptionItemViewModel(message.Caption) }
                );
                
        }

        public ObservableCollection<OptionItemViewModel> OptionItems { get; set; }
    }
}