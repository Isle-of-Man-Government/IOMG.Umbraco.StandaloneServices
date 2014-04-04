using Umbraco.Core;
using umbraco.editorControls;
using umbraco.interfaces;

namespace IOMG.Umbraco.StandaloneServices.Construction
{
    /// <summary>
    /// Extends the CoreBootManager for use in this Console app.
    /// </summary>
    internal class BootManager : CoreBootManager
    {
        internal BootManager(UmbracoApplicationBase UmbracoApplication)
            : base(UmbracoApplication)
        {
            //This is only here to ensure references to the assemblies needed for the DataTypesResolver
            //otherwise they won't be loaded into the AppDomain.
            var InterfacesAssemblyName = typeof(IDataType).Assembly.FullName;
            var EditorControlsAssemblyName = typeof(uploadField).Assembly.FullName;
        }
    }
}