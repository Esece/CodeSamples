###### System.BitConverter
## BitConverter

Bytes to 'short'
``` csharp
// the byte array size must align with the 'short' size..
BitConverter.ToUInt16(new byte[] { 0x63, 0x0 }, 0)  // 99
```

Bytes to Hex Notation
``` csharp
BitConverter.GetBytes(2659).Select(b => b.ToString("X2"))  // [ "63", "0A", "00", "00" ]
```

Convert and Restore
``` csharp
BitConverter.ToInt32(BitConverter.GetBytes(int.MaxValue), 0)  // 2147483647
```
