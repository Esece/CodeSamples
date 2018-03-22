###### System.IO.FileStream
## FileStream

Open Read-Only File
``` csharp
string text;
using (var stream = new FileStream(@"C:\test.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
{
    using (var sr = new StreamReader(stream))
    {
        text = sr.ReadToEnd();
    }
}
```
