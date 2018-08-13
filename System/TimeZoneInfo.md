###### System.TimeZoneInfo
## TimeZoneInfo

Get UTC Offset
``` csharp
TimeSpan offset = TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow);
```

GetSystemTimeZones
``` csharp
TimeZoneInfo.GetSystemTimeZones()
```

FindSystemTimeZoneById
``` csharp
TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")
```
