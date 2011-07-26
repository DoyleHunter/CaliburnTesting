using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Caliburn.Micro;
using System.Collections.ObjectModel;

namespace BackofficeDesktop
{
	public class ToolboxViewModel : PropertyChangedBase
	{
		private string _panelCaption = "Backoffice Tools";
		private System.Windows.Visibility _panelVisibility = System.Windows.Visibility.Visible;
		private ObservableCollection<PanelItem> _panelItems;
		private bool _isPinned = true;

		public ToolboxViewModel()
		{
			_panelItems = new ObservableCollection<PanelItem>();
			_panelItems.Add(new PanelItem("Financials"));
			_panelItems.Add(new PanelItem("Labor"));
			_panelItems.Add(new PanelItem("Tools"));
		}

		public void CollapsedPanelButtonMouseEnter()
		{
			_panelVisibility = System.Windows.Visibility.Visible;
			NotifyOfPropertyChange("PanelVisibility");
		}

		public void CollapsedPanelButtonMouseLeave()
		{
			if (_isPinned == false)
			{
				_panelVisibility = System.Windows.Visibility.Collapsed;
			}
			NotifyOfPropertyChange("PanelVisibility");
		}

		public void FunctionPanelMouseEnter()
		{
			_panelVisibility = System.Windows.Visibility.Visible;
			NotifyOfPropertyChange("PanelVisibility");
		}

		public void FunctionPanelMouseLeave()
		{
			if (_isPinned == false)
			{
				_panelVisibility = System.Windows.Visibility.Collapsed;
			}
			NotifyOfPropertyChange("PanelVisibility");
		}

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

		public bool IsPinned
		{
			get
			{
				return _isPinned;
			}
			set
			{
				_isPinned = value;
				if (_isPinned)
				{
					_panelVisibility = System.Windows.Visibility.Visible;
				}
				else
				{
					_panelVisibility = System.Windows.Visibility.Collapsed;
				}
				NotifyOfPropertyChange("IsPinned");
				NotifyOfPropertyChange("PanelVisibility");
			}
		}

		public System.Windows.Visibility PanelVisibility
		{
			get
			{
				return _panelVisibility;
			}
			set
			{
				_panelVisibility = value;
			}
		}

		public ObservableCollection<PanelItem> PanelItems
		{
			get
			{
				return _panelItems;
			}
			set
			{
				_panelItems = value;
			}
		}
	}

	public class PanelItem
	{
		private string _caption;
		private string _description;
		private string _commandLine;
		private string _iconId;

		public PanelItem(string caption) //, string description, string commandLine, string iconId)
		{
			_caption = caption;
			//_description = description;
			//_commandLine = commandLine;
			//_iconId = iconId;
		}

		public string Caption
		{
			get
			{
				return _caption;
			}
			set
			{
				_caption = value;
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				_description = value;
			}
		}

		public string CommandLine
		{
			get
			{
				return _commandLine;
			}
			set
			{
				_commandLine = value;
			}
		}

		public string IconId
		{
			get
			{
				return _iconId;
			}
			set
			{
				_iconId = value;
			}
		}
	}
}
