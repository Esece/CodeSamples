###### System.Web.Routing
## RouteCollection

Enable Route Attributes
``` csharp
public class RouteConfig
{
    public static void RegisterRoutes(RouteCollection routes)
    {
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

        routes.MapMvcAttributeRoutes();  // add this line after IgnoreRoute
    }
}
```
