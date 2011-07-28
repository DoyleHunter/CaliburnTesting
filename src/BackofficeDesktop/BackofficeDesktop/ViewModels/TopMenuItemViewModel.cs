using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BackofficeDesktop.Messages;
using Caliburn.Micro;

namespace BackofficeDesktop.ViewModels
{
    public class TopMenuItemViewModel
    {
        private readonly IEventAggregator _pubsub;

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
