IOMG.Umbraco.StandaloneServices
===============================

This simple package enables access to Umbraco's Services from outside of Umbraco.

We created this package to simplify our LinqPad scripts that access Umbraco's Service APIs (Umbraco 6+). The package is simple to use in your own code.

1. Get the source, or [add the NuGet package](https://www.nuget.org/packages/IOMG.Umbraco.StandaloneServices) to your project.
2. Make sure that your applications config contains a connection string for "umbracoDbDSN", which points to an Umbraco 6+ database.
3. In your code, create a new ServiceAccess object, which acts as a wrapper to the Umbraco ServiceContext:

```
var Access = new ServiceAccess();
var ContentPage = Access.Services.ContentService.GetById(1000);
```
