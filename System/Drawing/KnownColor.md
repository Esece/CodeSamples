## KnownColor

Get All Known Colors
``` csharp
var KnownColors = typeof(KnownColor).GetFields()
                      .Where(f => f.FieldType == typeof(KnownColor))
                      .Select(f => (KnownColor)f.GetValue(null))
                      .ToArray();
```
