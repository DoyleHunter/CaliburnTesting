using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace BackofficeDesktop.Services
{
    [Export(typeof (NavigationDataFeed))]
    public class NavigationDataFeed
    {
        public List<ApplicationItem> GetOptionsForGroup(string caption)
        {
            var result = new List<ApplicationItem>();

            for (int i = 1; i < 10; i++)
            {
                string number = i.ToString();
                result.Add(new ApplicationItem
                               {
                                   Caption = String.Format("Bogus {0} Item {1}", caption, number),
                                   CommandLine = "c:\\Windows\\notepad.exe"
                               });
            }

            return result;
        }
    }
}