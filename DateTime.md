###### System.DateTime
## DateTime

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
DateTime.TryParseExact("01/03/2018", "MM/dd/yyyy", null, DateTimeStyles.None, out var dateTime)
DateTime.TryParseExact("2018-11-10", "yyyy-MM-dd", null, DateTimeStyles.AssumeLocal, out var dateTime)
DateTime.TryParseExact("2018-11-10 15:55:25", "yyyy-MM-dd HH:mm:ss", null, DateTimeStyles.None, out var dateTime)
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

HTTP response Date header
``` csharp
DateTime.UtcNow.ToString(@"ddd, dd MMM yyyy hh:mm:ss G\MT")
```

Create Local Time with UTC Offset
``` csharp
var offset = -360;
new DateTime(DateTime.UtcNow.Ticks, DateTimeKind.Local).AddMinutes(offset)
```

ToString("hh:mm:ss.fff")
``` csharp
DateTime.Now.ToString("hh:mm:ss.fff")
```

ToString("HH:mm")
``` csharp
DateTime.Now.ToString("HH:mm")
```

ToShortTimeString
``` csharp
DateTime.Now.ToShortTimeString()  // 1:41 PM;
```


