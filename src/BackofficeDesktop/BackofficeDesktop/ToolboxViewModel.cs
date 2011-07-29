using System;
using System.Collections.ObjectModel;
using System.Windows;
using Caliburn.Micro;

namespace BackofficeDesktop
{
    public class ToolboxViewModel : PropertyChangedBase
    {
        private int _fontSize = 16;
        private bool _isPinned = true;
        private string _panelCaption = "Backoffice Tools";
        private Visibility _panelVisibility = Visibility.Visible;
        private ObservableCollection<BackofficeToolGroup> _toolGroups;

        public ToolboxViewModel()
        {
            _toolGroups = new ObservableCollection<BackofficeToolGroup>();
            var group = new BackofficeToolGroup("Financials", "Financial Applications", "1");

            _toolGroups.Add(group);

            group = new BackofficeToolGroup("Labor", "Labor Applications", "2");
            _toolGroups.Add(group);

            group = new BackofficeToolGroup("Tools", "Tools", "3");
            _toolGroups.Add(group);
        }

        public int FontSize
        {
            get { return _fontSize; }
            set { _fontSize = value; }
        }

        public string PanelCaption
        {
            get { return _panelCaption; }
            set { _panelCaption = value; }
        }

        public bool IsPinned
        {
            get { return _isPinned; }
            set
            {
                _isPinned = value;
                if (_isPinned)
                {
                    _panelVisibility = Visibility.Visible;
                }
                else
                {
                    _panelVisibility = Visibility.Collapsed;
                }
                NotifyOfPropertyChange("IsPinned");
                NotifyOfPropertyChange("PanelVisible");
                NotifyOfPropertyChange("PanelCollapsed");
            }
        }

        public Visibility PanelCollapsed
        {
            get
            {
                if (_panelVisibility == Visibility.Collapsed)
                {
                    return Visibility.Visible;
                }
                else
                {
                    return Visibility.Collapsed;
                }
            }
        }

        public Visibility PanelVisible
        {
            get { return _panelVisibility; }
            set { _panelVisibility = value; }
        }

        public ObservableCollection<BackofficeToolGroup> ToolGroups
        {
            get { return _toolGroups; }
            set { _toolGroups = value; }
        }

        public void ToolGroupLabelMouseEnter()
        {
            MessageBox.Show("Hello");
        }

        public void CollapsedPanelButtonMouseEnter()
        {
            _panelVisibility = Visibility.Visible;
            NotifyOfPropertyChange("PanelVisible");
        }

        public void CollapsedPanelButtonMouseLeave()
        {
            if (_isPinned == false)
            {
                _panelVisibility = Visibility.Collapsed;
            }
            NotifyOfPropertyChange("PanelVisible");
        }

        public void FunctionPanelMouseEnter()
        {
            Console.WriteLine("FunctionPanelMouseEnter");
            _panelVisibility = Visibility.Visible;
            NotifyOfPropertyChange("PanelVisible");
        }

        public void FunctionPanelMouseLeave()
        {
            if (_isPinned == false)
            {
                _panelVisibility = Visibility.Collapsed;
            }
            NotifyOfPropertyChange("PanelVisible");
        }
    }

    public class BackofficeToolGroup
    {
        public BackofficeToolGroup(string caption, string description, string iconId)
        {
            Caption = caption;
            Description = description;
            IconId = iconId;
        }

        public string Caption { get; set; }

        public string Description { get; set; }

        public ObservableCollection<BackofficeTool> Tools { get; set; }

        public ObservableCollection<BackofficeToolGroup> ToolGroups { get; set; }

        public string IconId { get; set; }
    }

    public class BackofficeTool
    {
        public BackofficeTool(string caption, string description, string commandLine, string iconId)
        {
            Caption = caption;
            Description = description;
            CommandLine = commandLine;
            IconId = iconId;
        }

        public string Caption { get; set; }

        public string Description { get; set; }

        public string CommandLine { get; set; }

        public string IconId { get; set; }
    }
}