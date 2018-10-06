## JsonSerializerSettings

Ignore Parse Error(s)
``` csharp
new JsonSerializerSettings
{
    Error = (sender, e) => { Debug.WriteLine(e.ErrorContext.Error.Message); e.ErrorContext.Handled = true; },
}
```

Not to render value if null
``` csharp
var json = JsonConvert.SerializeObject(data, new JsonSerializerSettings()
{
    NullValueHandling = NullValueHandling.Ignore
});
```
