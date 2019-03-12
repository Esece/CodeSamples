## Console

Disable Console Output
``` csharp
Console.SetOut(new StreamWriter(new MemoryStream()));
Debug.Listeners.Clear();
```
