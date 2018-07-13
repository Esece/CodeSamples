###### System.Collections.Generic.Stack\<T\>
## Stack\<T\>


Extension method to simplify the creation of an instance
``` csharp
public static Stack<T> ToStack<T>(this IEnumerable<T> source)
{
    return new Stack<T>(source);
}
```

> No need to specify the type in a ctor.
