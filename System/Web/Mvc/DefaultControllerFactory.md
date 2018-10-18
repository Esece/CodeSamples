##### System.Web.Mvc
## DefaultControllerFactory

CustomControllerFactory
``` csharp
public class CustomControllerFactory : DefaultControllerFactory
{
    protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
    {
        if (controllerType == null)
        {
            throw new HttpException(404, "Controller not found");
        }

        return (IController)Activator.CreateInstance(controllerType);  // replace this line with custom instance creation logic..
    }
}

// registration
public class MvcApplication : System.Web.HttpApplication
{
    :
    ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());
    :
}
```
