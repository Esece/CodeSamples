###### System.HashSet
### HashSet

Case-Insensitive String HashSet
``` csharp
new HashSet<string>(StringComparer.OrdinalIgnoreCase)
```

Null can be passed as key (does not throw)
``` scharp
var hashSet = new HashSet<string>();
var hasNull = hashSet.Contains(null);  // false
```
