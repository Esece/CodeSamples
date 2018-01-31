###### System.DateTime
### DateTime

ToString("hh:mm:ss")
``` csharp
DateTime.Now.ToString("hh:mm:ss")  // 07:23:40
```

ParseExact
``` csharp
DateTime.ParseExact("Fri, 26-Feb-2016 01:37:30 GMT", "ddd, dd-MMM-yyyy hh:mm:ss GMT", null)
```

TryParseExact
``` csharp
DateTime.TryParseExact("01/03/2018", "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out var dateTime)
```

Ad hoc Repeater 
``` csharp
var timeout = DateTime.UtcNow.AddMinutes(3);

while (DateTime.UtcNow < timeout)  // repeast every second for 3 minutes..
{
    :
    Thread.Sleep(1000);
}
```
