###### System.IO.Compression.ZipArchive
### ZipArchive

``` csharp
byte[] zipfile;
:
IDictionary<string, byte[]> files = S78.IO.ZipFile.Unzip(zipfile);
```
``` csharp
public static IDictionary<string, byte[]> Unzip(byte[] data)
{
    var result = new Dictionary<string, byte[]>();

    using (var fileStream = new MemoryStream(data))
    {
        using (var archive = new ZipArchive(fileStream, ZipArchiveMode.Read, false))
        {
            foreach (var entry in archive.Entries)
            {
                using (var reader = new BinaryReader(entry.Open()))
                {
                    result.Add(entry.FullName, reader.ReadAllBytes());
                }
            }
        }
    }

    return result;
}
```
``` csharp
public static byte[] Zip(IDictionary<string, byte[]> entries, CompressionLevel compressionLevel)
{
    using (var fileStream = new MemoryStream())
    {
        using (var archive = new ZipArchive(fileStream, ZipArchiveMode.Create, false))
        {
            foreach (var entry in entries)
            {
                var zipArchiveEntry = archive.CreateEntry(entry.Key, compressionLevel);

                using (var zipStream = zipArchiveEntry.Open())
                {
                    zipStream.Write(entry.Value, 0, entry.Value.Length);
                }
            }
        }

        return fileStream.ToArray();
    }
}
```

