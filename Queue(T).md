###### System.Collections.Generic.Queue\<T\>
## Queue\<T\>


Extension method to simplify the creation of an instance
``` csharp
public static Queue<T> ToQueue<T>(this IEnumerable<T> source)
{
    return new Queue<T>(source);
}
```

> No need to specify the type in a ctor.
