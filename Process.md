###### System.Diagnostics.Process
# Process

All Process Names
``` csharp
Process.GetProcesses().Select(p => p.ProcessName)
```

Start explorer.exe with a file/folder selected
``` csharp
string path = @"C:\temp\test.txt";
Process.Start("explorer", "/select,\"" + path + "\"");
```
