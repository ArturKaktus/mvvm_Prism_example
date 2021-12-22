using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testPrism.Views;

namespace testPrism
{
    public class Main : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(Content1));
            regionManager.RequestNavigate(RegionNames.ContentRegion2, nameof(Footer1));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Content1>();
            containerRegistry.RegisterForNavigation<Content2>();
            containerRegistry.RegisterForNavigation<Footer1>();
        }
    }
}
