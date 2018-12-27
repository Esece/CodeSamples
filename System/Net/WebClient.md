###### System.Net.WebClient
## WebClient


HTTP GET
``` csharp
var wc = new WebClient();
var html = wc.DownloadString("https://www.google.com");
```

HTTP GET (as Google Chrome)
``` csharp
var wc = new WebClient();
wc.Encoding = Encoding.UTF8;
wc.Headers["Accept"] = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
wc.Headers["Accept-Encoding"] = "gzip, deflate, br";
wc.Headers["Accept-Language"] = "en-US,en;q=0.9,fr;q=0.8";
wc.Headers["Cache-Control"] = "no-cache";
wc.Headers["Pragma"] = "no-cache";
wc.Headers["User-Agent"] = "user-agent:Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36";
wc.Headers["Upgrade-Insecure-Requests"] = "1";

string result;
using (var gZipStream = new GZipStream(wc.OpenRead("https://en.wikipedia.org/wiki/Water"), CompressionMode.Decompress))
{
    using (var reader = new StreamReader(gZipStream, wc.Encoding))
    {
        result = reader.ReadToEnd();
    }
}
```

Get and Read Zip File Download (single file)
``` csharp
string data;

using (var fileStream = new WebClient().OpenRead("http://www2.census.gov/geo/docs/maps-data/data/gazetteer/Gaz_zcta_national.zip"))
{
    using (var archive = new ZipArchive(fileStream, ZipArchiveMode.Read, false))
    {
        var entry = archive.Entries[0];

        using (var reader = new BinaryReader(entry.Open()))
        {
            data = Encoding.UTF8.GetString(reader.ReadAllBytes());
        }
    }
}

Console.WriteLine(data);
```

Manually Set Authorization Header to AVOID Unwanted HTTP 401 Response
``` csharp
var encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}"));
var wc = new WebClient();
wc.Headers["Authorization"] = "Basic " + encoded;


wc.Crendentials = new NetworkCredential(username, password);  // this will first make a call for a 401 result (to discover)...
```

