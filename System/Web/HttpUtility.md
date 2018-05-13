###### System.Web.HttpUtility
## HttpUtility

ParseQueryString
``` csharp
NameValueCollection nameValues = HttpUtility.ParseQueryString("v=tIGmoRdlosI&a=78945");
```

Build Query String
``` csharp
static string MakeQueryString(NameValueCollection nvc)
{
    if (nvc.Count > 0)
    {
        return "?" + String.Join("&", nvc.AllKeys.Select(k => HttpUtility.UrlEncode(k) + "=" + HttpUtility.UrlEncode(nvc[k])));
    }
    else
    {
        return "";
    }
}
```
