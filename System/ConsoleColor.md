## ConsoleColor

Get All Console Colors
``` csharp
var colors = typeof(ConsoleColor).GetFields(BindingFlags.Public | BindingFlags.Static)
    .Select(f => (ConsoleColor)f.GetValue(null))
    .Select(c => c == ConsoleColor.DarkYellow ? Color.FromArgb(128, 128, 0) : Color.FromName(c.ToString()));
```
