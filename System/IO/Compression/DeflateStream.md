##### System.IO.Compression
## DeflateStream

Compress (byte[] to byte[])
``` csharp
static byte[] Compress(byte[] data)
{
    var memoryStream = new MemoryStream();

    using (var deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress))  // use CompressionLevel.Optimal for smaller bytes
    {
        deflateStream.Write(data, 0, data.Length);
    }

    return memoryStream.ToArray();
}
```

Decompress (byte[] to byte[])
``` csharp
static byte[] Decompress(byte[] data)
{
    var output = new MemoryStream();
    
    using (var deflateStream = new DeflateStream(new MemoryStream(data), CompressionMode.Decompress))
    {
        deflateStream.CopyTo(output);
    }

    output.Position = 0;
    
    return output.ToArray();
}
```
