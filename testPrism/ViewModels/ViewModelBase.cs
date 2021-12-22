using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPrism.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware
    {
        protected IRegionManager RegionManager { get; }

        public ViewModelBase(IRegionManager regionManager)
        {
            RegionManager = regionManager;
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }
    }
}
