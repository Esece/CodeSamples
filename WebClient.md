###### System.Net.WebClient
## WebClient


HTTP GET
``` csharp
var wc = new WebClient();
var html = wc.DownloadString("https://www.google.com");
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
