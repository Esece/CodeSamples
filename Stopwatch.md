### Stopwatch
###### System.Diagnostics.Stopwatch

Simple Profiling
``` csharp
var sw = Stopwatch.StartNew();

// do something..

sw.Stop();
Console.WriteLine(sw.ElapsedTicks);
Console.WriteLine(sw.ElapsedMilliseconds);
```
