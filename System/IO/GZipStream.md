##### System.IO.Compression
## GZipStream

Compress
``` csharp
static byte[] Compress(byte[] data)
{
    using (var memoryStream = new MemoryStream())
    {
        using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
        {
            gzipStream.Write(data, 0, data.Length);
        }

        return memoryStream.ToArray();
    }
}
```

Compress
``` csharp
static int Compress(Stream inStream, Stream outStream)
{
    using (var memoryStream = new MemoryStream())
    {
        inStream.CopyTo(memoryStream);

        using (GZipStream gzipStream = new GZipStream(outStream, CompressionMode.Compress))
        {
            var data = memoryStream.ToArray();
            gzipStream.Write(data, 0, data.Length);

            return data.Length;
        }
    }
}
```

Decompress (from stream to string)
``` csharp
static string Decompress(Stream stream, Encoding encoding)
{
    using (var zipStream = new GZipStream(stream, CompressionMode.Decompress))
    {
        using (var reader = new StreamReader(zipStream, encoding))
        {
            return reader.ReadToEnd();
        }
    }
}
```

Decompress (from byte array to byte array)
``` csharp
static byte[] Decompress(byte[] data)
{
    using (var compressedStream = new MemoryStream(data))
    {
        using (var zipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
        {
            using (var resultStream = new MemoryStream())
            {
                zipStream.CopyTo(resultStream);
                return resultStream.ToArray();
            }
        }
    }
}
```

Decompress (from byte array to string)
``` csharp
static string Decompress(byte[] data, Encoding encoding)
{
    using (var memoryStream = new MemoryStream(data))
    {
        using (var zipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
        {
            using (var reader = new StreamReader(zipStream, encoding))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
```
