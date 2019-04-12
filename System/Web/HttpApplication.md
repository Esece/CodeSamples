## HttpApplication

Handle HTTP 404 Response with Custom View
``` csharp
protected void Application_Error(object sender, EventArgs e)
{
    var ex = Server.GetLastError();

    if (ex is HttpException httpException)
    {
        var status = httpException.GetHttpCode();
    
        if (status == 404)
        {
            Server.ClearError();
            Response.Clear();
            
            var routeData = new RouteData();
            routeData.Values.Add("controller", "Home");
            routeData.Values.Add("action", "NotFound");
            
            Response.StatusCode = status;
            new ErrorController().Execute(new RequestContext(new HttpContextWrapper(Context), routeData));
        }
    }
}
```
