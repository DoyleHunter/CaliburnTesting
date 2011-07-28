using System;
using System.Collections.ObjectModel;

namespace BackofficeDesktop.ViewModels
{
    public class TopMenuViewModel
    {
        public TopMenuViewModel(Func<TopMenuItemViewModel> getTopMenuViewModel)
        {
            //;

            //var financials = getTopMenuViewModel(); 
            //financials.Caption = "Financials";
            
            //var labor = getTopMenuViewModel();
            //labor.Caption = "Labor";

            //var items = new[] {financials, labor};
            //MenuItems = new ObservableCollection<TopMenuItemViewModel>(items);

        }

        public ObservableCollection<TopMenuItemViewModel> MenuItems { get; set; }

    }
}