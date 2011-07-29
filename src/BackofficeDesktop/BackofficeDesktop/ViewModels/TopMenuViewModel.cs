using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace BackofficeDesktop.ViewModels
{
    [Export(typeof (TopMenuViewModel))]
    public class TopMenuViewModel
    {
        public TopMenuViewModel()
        {
            TopMenuItemViewModel financials = CreateMenuItem("Financials");
            TopMenuItemViewModel labor = CreateMenuItem("Labor");

            var items = new[] {financials, labor};
            MenuItems = new ObservableCollection<TopMenuItemViewModel>(items);
        }

        public ObservableCollection<TopMenuItemViewModel> MenuItems { get; set; }

        private static TopMenuItemViewModel CreateMenuItem(string caption)
        {
            var viewModel = IoC.Get<TopMenuItemViewModel>();

            viewModel.Caption = caption;

            return viewModel;
        }
    }
}