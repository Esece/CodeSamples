###### System.Delegate
## Delegate

Convert lamdas in a uniform manner
``` csharp
var methods = new List<Delegate>();
methods.Add(new Func<int>(() => 20));
methods.Add(new Action<string>(m => { Log(); }));
```
