IOMG.Umbraco.StandaloneServices
===============================

This simple package enables access to Umbraco's Services from outside of Umbraco.

We created this package to simplify our LinqPad scripts that access Umbraco's Service APIs (Umbraco 6+). The package is simple to use in your own code.

1) Download the source here, or add the NuGet package (https://www.nuget.org/packages/IOMG.Umbraco.StandaloneServices/).

2) Make sure that your environment's config contains a connection string for "umbracoDbDSN", which points to an Umbraco 6+ database.

3) In your code, create a new ServiceAccess object, which acts as a wrapper to the Umbraco ServiceContext.
