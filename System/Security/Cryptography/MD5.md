###### System.Security.Cryptography.MD5
### MD5

Get MD5 Hash
``` csharp
static string GetMD5HashString(string value)
{
    byte[] hash = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(value));

    return new String(hash.SelectMany(h => h.ToString("x2")).ToArray());
}
```
