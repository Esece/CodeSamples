##### System.Threading.Thread
## Thread

Join threads
``` csharp
var threads = new List<Thread>();

foreach (var value in values)
{
    var thread = new Thread(v =>
    {
        :
    });
    
    thread.IsBackground = true;
    thread.Start(value);
    threads.Add(thread);
}

threads.ForEach(t => t.Join());
```

Get the current culture
``` csharp
Thread.CurrentThread.CurrentCulture
```

Get the current UI culture
``` csharp
Thread.CurrentThread.CurrentUICulture
```
