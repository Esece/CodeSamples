###### System.DateTime
### DateTime

ToString("hh:mm:ss")
``` csharp
DateTime.Now.ToString("hh:mm:ss")  // 07:23:40
```

TryParseExact
``` csharp
DateTime.TryParseExact("01/03/2018", "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out var dateTime)
```
