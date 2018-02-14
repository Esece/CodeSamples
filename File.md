##### System.IO
## File

Remove 'ReadOnly' attribute
``` csharp
static void RemoveReadOnlyAttribute(string path)
{
    var attributes = File.GetAttributes(path);

    if (attributes.HasFlag(FileAttributes.ReadOnly))
    {
        File.SetAttributes(path, attributes & ~FileAttributes.ReadOnly);
    }
}
```
