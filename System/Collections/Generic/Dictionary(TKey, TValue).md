###### System.Collections.Generic
### Dictionary<TKey, TValue>

C#6.0 Initializer
``` csharp
var aliases = new Dictionary<string, string>
{
    [ "System.String" ] = "string",
    [ "System.Int32" ] = "int",
    [ "System.Double" ] = "double",
};
```

Case-Insensitive Dictionary
``` csharp
new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
```
