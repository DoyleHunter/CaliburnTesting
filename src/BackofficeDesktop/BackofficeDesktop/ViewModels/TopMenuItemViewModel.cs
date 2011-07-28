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
        private EventAggregator _pubsub = new EventAggregator();

        public TopMenuItemViewModel()
        {
            
        }

        public string Caption { get; set; }

        public void ShowSubmenu()
        {
            _pubsub.Publish(new TopMenuItemSelected(Caption));
        }
    }
}
