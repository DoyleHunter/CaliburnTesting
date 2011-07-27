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
		private ObservableCollection<BackofficeToolGroup> _toolGroups;
		private bool _isPinned = true;
		private int _fontSize = 16;

		public ToolboxViewModel()
		{
			_toolGroups = new ObservableCollection<BackofficeToolGroup>();
			BackofficeToolGroup group = new BackofficeToolGroup("Financials", "Financial Applications", "1");
			_toolGroups.Add(group);

			group = new BackofficeToolGroup("Labor", "Labor Applications", "2");
			_toolGroups.Add(group);

			group = new BackofficeToolGroup("Tools", "Tools", "3");
			_toolGroups.Add(group);
		}

		public void ToolGroupLabelMouseEnter()
		{
			System.Windows.MessageBox.Show("Hello");
		}

		public int FontSize
		{
			get
			{
				return _fontSize;
			}
			set
			{
				_fontSize = value;
			}
		}

		public void CollapsedPanelButtonMouseEnter()
		{
			_panelVisibility = System.Windows.Visibility.Visible;
			NotifyOfPropertyChange("PanelVisible");
		}

		public void CollapsedPanelButtonMouseLeave()
		{
			if (_isPinned == false)
			{
				_panelVisibility = System.Windows.Visibility.Collapsed;
			}
			NotifyOfPropertyChange("PanelVisible");
		}

		public void FunctionPanelMouseEnter()
		{
			Console.WriteLine("FunctionPanelMouseEnter");
			_panelVisibility = System.Windows.Visibility.Visible;
			NotifyOfPropertyChange("PanelVisible");
		}

		public void FunctionPanelMouseLeave()
		{
			if (_isPinned == false)
			{
				_panelVisibility = System.Windows.Visibility.Collapsed;
			}
			NotifyOfPropertyChange("PanelVisible");
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
				NotifyOfPropertyChange("PanelVisible");
				NotifyOfPropertyChange("PanelCollapsed");
			}
		}

		public System.Windows.Visibility PanelCollapsed
		{
			get
			{
				if (_panelVisibility == System.Windows.Visibility.Collapsed)
				{
					return System.Windows.Visibility.Visible;
				}
				else
				{
					return System.Windows.Visibility.Collapsed;
				}
			}
		}

		public System.Windows.Visibility PanelVisible
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

		public ObservableCollection<BackofficeToolGroup> ToolGroups
		{
			get
			{
				return _toolGroups;
			}
			set
			{
				_toolGroups = value;
			}
		}
	}

	public class BackofficeToolGroup
	{
		private string _caption;
		private string _description;
		private ObservableCollection<BackofficeTool> _tools;
		private ObservableCollection<BackofficeToolGroup> _toolGroups;
		private string _iconId;

		public BackofficeToolGroup(string caption, string description, string iconId)
		{
			_caption = caption;
			_description = description;
			_iconId = iconId;
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

		public ObservableCollection<BackofficeTool> Tools
		{
			get
			{
				return _tools;
			}
			set
			{
				_tools = value;
			}
		}

		public ObservableCollection<BackofficeToolGroup> ToolGroups
		{
			get
			{
				return _toolGroups;
			}
			set
			{
				_toolGroups = value;
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

	public class BackofficeTool
	{
		private string _caption;
		private string _description;
		private string _commandLine;
		private string _iconId;

		public BackofficeTool(string caption, string description, string commandLine, string iconId)
		{
			_caption = caption;
			_description = description;
			_commandLine = commandLine;
			_iconId = iconId;
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
