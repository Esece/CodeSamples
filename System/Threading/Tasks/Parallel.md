###### System.Threading.Tasks.Parallel
## Parallel

MaxDegreeOfParallelism
``` csharp
System.Net.ServicePointManager.DefaultConnectionLimit = 1000;
System.Net.ServicePointManager.Expect100Continue = false;
ThreadPool.SetMaxThreads(1000, 1000);

var parallelOptions = new System.Threading.Tasks.ParallelOptions()
{
    MaxDegreeOfParallelism = 1000,
};

System.Threading.Tasks.Parallel.ForEach(Enumerable.Range(0, 1000), parallelOptions, i =>
{

});
```
