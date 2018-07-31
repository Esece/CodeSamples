## JsonSerializerSettings

Ignore Parse Error(s)
``` csharp
new JsonSerializerSettings
{
    Error = (sender, e) => { Debug.WriteLine(e.ErrorContext.Error.Message); e.ErrorContext.Handled = true; },
}
```
