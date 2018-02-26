###### System.Net.HttpWebRequest
## HttpWebRequest

``` csharp
var request = HttpWebRequest.CreateHttp("https://www.google.com");

using (var response = (HttpWebResponse)request.GetResponse())
{
    var status = response.StatusCode;
    var statusDescription = response.StatusDescription;

    using (var reader = new StreamReader(response.GetResponseStream()))
    {
        string html = reader.ReadToEnd().Dump();   
    }
}
```
