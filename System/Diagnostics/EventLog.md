## EventLog

Write to Event Viewer
``` csharp
using (var log = new EventLog("Application"))
{
    log.Source = "Test Application";
    log.WriteEntry("Log message example", EventLogEntryType.Information, 101, 1);
}
```
