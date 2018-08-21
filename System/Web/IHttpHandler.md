###### System.Web.IHttpHandler
## IHttpHandler

Template
``` csharp
public class CustomHandler : IHttpHandler
{
    public bool IsReusable
    {
        get { return true; }
    }

    public void ProcessRequest(HttpContext context)
    {
    }
}
```
