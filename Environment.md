###### System.Environment
### Environment

Get Callstack
``` csharp
System.Environment.StackTrace.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).Skip(3).ToArray()
```
