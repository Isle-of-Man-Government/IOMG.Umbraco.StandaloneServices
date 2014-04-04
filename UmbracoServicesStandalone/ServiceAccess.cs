using IOMG.Umbraco.StandaloneServices.Construction;
using Umbraco.Core.Services;

namespace IOMG.Umbraco.StandaloneServices
{
    public class ServiceAccess
    {
        private readonly ServiceContext _Services;

        public ServiceAccess()
        {
            _Services = ContextAccess.CreateServiceContext();            
        }

        /// <summary>
        /// Gets the current ServiceContext
        /// </summary>
        public ServiceContext Services {
            get { return _Services; }
        }      
    }
}