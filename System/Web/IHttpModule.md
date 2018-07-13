###### System.Web.IHttpModule
### IHttpModule

Http Module Template
``` csharp
public class CustomModule : IHttpModule
{
    public void Init(HttpApplication app)
    {
        app.BeginRequest += App_BeginRequest;
        app.EndRequest += App_EndRequest;
    }

    private void App_BeginRequest(object source, EventArgs e)
    {
        var app = (HttpApplication)source;
    }

    private void App_EndRequest(object source, EventArgs e)
    {
        var app = (HttpApplication)source;
    }

    public void Dispose() { }
}
```

Module Registration (Runtime)
``` csharp
[assembly: PreApplicationStartMethod(typeof(ModuleRegistration), "Start")]

public class ModuleRegistration
{
    public static void Start()
    {
        Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility.RegisterModule(typeof(CustomModule));
    }
}
```

Module Registration (web.config)
``` xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <system.webServer>
    <modules>
      <add name="CustomModule" type="CustomModule"/>
    </modules>
  </system.webServer>
</configuration>
```
