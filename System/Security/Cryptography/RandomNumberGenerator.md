###### System.Security.Cryptography
## RandomNumberGenerator

Unbiased Random GUID
``` csharp
var bytes = new byte[16];
using (var random = RandomNumberGenerator.Create())
{
    random.GetBytes(bytes);
}
var unbiasedGuid = new Guid(bytes);
```

> System.Guid.NewGuid() generates the same bits from 56th bit to 65th bit within the same machine to achieve randomness across multiple machines. The above method removes this bias.
