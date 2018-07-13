###### System.Web.Mvc.UrlHelper
### UrlHelper

Url to Action (Global)
``` html
@Url.Action("Index", "Home")
```

Url to Action (Area)
``` html
@Url.Action("Index", "Home", new { area = "User" })
```

Code
``` csharp
var url = new UrlHelper(Request.RequestContext).Action("Index", "Home");
```
