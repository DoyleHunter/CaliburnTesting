using System.Collections.ObjectModel;

namespace BackofficeDesktop.ViewModels
{
    public class TopMenuViewModel
    {
        public TopMenuViewModel()
        {
            var items = new[]
                            {
                                new TopMenuItemViewModel(){Caption = "Financials"},
                                new TopMenuItemViewModel(){Caption = "Labor"}
                            };
            MenuItems = new ObservableCollection<TopMenuItemViewModel>(items);

        }

        public ObservableCollection<TopMenuItemViewModel> MenuItems { get; set; }

    }
}