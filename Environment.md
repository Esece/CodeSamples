###### System.Environment
### Environment

CLR Version
``` csharp
Environment.Version.ToString()  // could be "4.0.30319.42000"
```

MyDocuments Folder Path (Special Folder)
``` csharp
Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)  // AppData\Local
```

Exit Application with Error Code
``` csharp
Environment.Exit(1)

Get Callstack
``` csharp
System.Environment.StackTrace.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).Skip(3).ToArray()
```
