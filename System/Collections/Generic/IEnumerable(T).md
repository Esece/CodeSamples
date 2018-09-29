###### System.Collections.Generic
## IEnumerable\<T\>

Simple Implementation
``` csharp
class SomeClass : IEnumerable<object>
{
    object[] _data;
    
    public IEnumerator<object> GetEnumerator()
    {
        foreach (var d in _data)
        {
            yield return d;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
```
