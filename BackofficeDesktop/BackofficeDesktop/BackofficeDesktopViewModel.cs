using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Caliburn.Micro;

namespace BackofficeDesktop
{
	public class BackofficeDesktopViewModel : PropertyChangedBase
	{
		private string _name = "Go for it";
		private string _notName = "Counter";

		public BackofficeDesktopViewModel()
		{
			Toolbox = new ToolboxViewModel();
		}

		public ToolboxViewModel Toolbox
		{
			get
			{
				return _toolbox;
			}
			set
			{
				_toolbox = value;
				base.NotifyOfPropertyChange(() => Toolbox);
			}
		}
		
		private ToolboxViewModel _toolbox;

		public string NotName
		{
			get
			{
				return _notName;
			}
			set
			{
				_notName = value;
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		public void NameMouseEnter(string text)
		{
			NotName = "Mouse Enter warning" + DateTime.Now.ToString("HH:mm:ss");
			RaisePropertyChangedEventImmediately("NotName");


			// Vanessa Carlton
		}
	}
}
