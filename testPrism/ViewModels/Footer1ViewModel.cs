using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using testPrism.ViewModels;
using testPrism.Views;

namespace testPrism.ViewModels
{
    public class Footer1ViewModel : ViewModelBase
    {
        public DelegateCommand<string> CommandName { get; }
        public Footer1ViewModel(IRegionManager regionManager) : base(regionManager)
        {
            //_regionManager = regionManager;
            CommandName = new DelegateCommand<string>(StaffDetails);
        }

        

        private void StaffDetails(string str)
        {

            RegionManager.RequestNavigate(RegionNames.ContentRegion, "Content2");
        }


    }
}
