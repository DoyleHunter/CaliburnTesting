using System;
using System.Collections.ObjectModel;
using BackofficeDesktop.Messages;
using Caliburn.Micro;

namespace BackofficeDesktop.ViewModels
{
    public class OptionsViewModel : IHandle<TopMenuItemSelected>
    {
        private readonly EventAggregator _pubsub;

        public OptionsViewModel()
        {
            _pubsub = new EventAggregator();
            _pubsub.Subscribe(this);
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

    public class OptionItemViewModel
    {
        private readonly string _caption;

        public OptionItemViewModel(string caption)
        {
            _caption = caption;
        }

        public string Caption
        {
            get { return _caption; }
        }
    }
}