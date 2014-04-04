using System;
using Umbraco.Core;

namespace IOMG.Umbraco.StandaloneServices.Construction
{
    internal class StandaloneBase : UmbracoApplicationBase
    {
        protected override IBootManager GetBootManager()
        {
            return new BootManager(this);
        }

        public void Start(object Sender, EventArgs Args)
        {
            Application_Start(Sender, Args);
        }
    }
}