###### System.Convert
## Convert

Hex String to Int32
``` csharp
Convert.ToInt32("8A", 16)  // 138
```

Int32 to Bit String
``` csharp
Convert.ToString(4, 2).PadLeft(32, '0')  // 00000000000000000000000000000101
```

Null-safe
``` csharp
Convert.ToDecimal(null)  // returns 0m
```

Convert to Bit String
``` csharp
ToBitString(Guid.NewGuid().ToByteArray())  // 01110100101...10000

static string ToBitString(byte[] bytes)
{
    return new String(bytes.SelectMany(b => Convert.ToString(b, 2).PadLeft(8, '0').ToCharArray()).ToArray());
}
```
