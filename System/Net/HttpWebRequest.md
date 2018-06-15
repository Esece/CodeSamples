## HttpWebRequest

CreateHttp Example
``` csharp
var request = HttpWebRequest.CreateHttp("");
request.Accept = "application/json";
request.ContentType = "application/json";
request.Credentials = new NetworkCredential("", "");

try
{
    using (var response = (HttpWebResponse)request.GetResponse())
    {
        using (var reader = new StreamReader(response.GetResponseStream()))
        {
            var result = reader.ReadToEnd();
        }
    }
}
catch (WebException ex)
{
    var response = (HttpWebResponse)ex.Response;
    
    if (response != null)
    {
        using (var response = (HttpWebResponse)request.GetResponse())
        {
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var error = reader.ReadToEnd();
            }
        }
    }
}
```
