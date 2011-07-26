using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CollapsibleToolbox
{
	public class PinnableToolboxViewModel : INotifyPropertyChanged
	{
		private string _panelCaption;

		public string PanelCaption
		{
			get
			{
				return _panelCaption;
			}
			set
			{
				_panelCaption = value;
			}
		}
		#region INotifyPropertyChanged Members

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion
	}
}
