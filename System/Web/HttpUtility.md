###### System.Web.HttpUtility
## HttpUtility

ParseQueryString
``` csharp
NameValueCollection nameValues = HttpUtility.ParseQueryString("v=tIGmoRdlosI&a=78945");
```

Build Query String (automatically encoded)
``` csharp
var queryString = HttpUtility.ParseQueryString(String.Empty);

queryString["key1"] = "T&J";
queryString["key2"] = "https://www.google.com";

// if you don't want to override
queryString.Add("key1", "P&G");

queryString.ToString().Dump();  // key1=T%26J&key1=P%26G&key2=https%3a%2f%2fwww.google.com
```

Build Query String (manually encoded)
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


