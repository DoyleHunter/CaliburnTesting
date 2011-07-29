using System.ComponentModel.Composition;
using BackofficeDesktop.Messages;
using Caliburn.Micro;

namespace BackofficeDesktop.ViewModels
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Export(typeof (TopMenuItemViewModel))]
    public class TopMenuItemViewModel
    {
        private readonly IEventAggregator _pubsub;

        [ImportingConstructor]
        public TopMenuItemViewModel(IEventAggregator pubsub)
        {
            _pubsub = pubsub;
        }

        public string Caption { get; set; }

        public void ShowSubmenu()
        {
            _pubsub.Publish(new TopMenuItemSelected(Caption));
        }
    }
}