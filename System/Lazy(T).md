## Lazy\<T\>

Typical Usage
``` csharp
class DataModel
{
    static readonly Lazy<int> VeryComplicatedValueCache = new Lazy<int>(() => Calculate());

    public static int VeryComplicatedValue
    {
        get { return VeryComplicatedValueCache.Value; }
    }
}
```
