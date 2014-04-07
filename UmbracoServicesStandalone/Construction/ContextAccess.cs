using System;
using System.Configuration;
using Umbraco.Core;
using Umbraco.Core.Services;
using UmbracoServicesStandalone;

namespace IOMG.Umbraco.StandaloneServices.Construction
{
    internal class ContextAccess
    {
        public static ServiceContext CreateServiceContext()
        {
            VerifySetup();
            var AppBase = new StandaloneBase();
            if (ApplicationContext.Current == null)
                AppBase.Start(AppBase, new EventArgs());
            var AppContext = ApplicationContext.Current;
            var DatabaseContext = AppContext.DatabaseContext;
            return AppContext.Services;
        }

        private static void VerifySetup()
        {
            if(ConfigurationManager.ConnectionStrings["umbracoDbDSN"] == null)
            {
                throw new MissingConfigurationException("umbracoDbDSN");
            }            
        }
    }
}