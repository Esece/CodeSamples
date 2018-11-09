###### System
## Guid

Unbiased Random GUID
``` csharp
var bytes = new byte[16];
System.Security.Cryptography.RandomNumberGenerator.Create().GetBytes(bytes);
var unbiasedGuid = new Guid(bytes);
```

> Guid.NewGuid() generates the same bits from 56th bit to 65th bit within the same machine to achieve randomness across multiple machines. The above method removes this bias.
