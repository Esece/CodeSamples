###### System.Collections.Specialized.NameValueCollection
## NameValueCollection

``` csharp
var collection = new NameValueCollection();
collection.Add("A", "111");
collection.Add("B", "888");
collection.Add("B", "999");  // will NOT throw a duplicate key error..

var value = collection["A"];  // most common way of reading the value by key (returns "111")
value = collection["a"];  // nice to be case-insensitive (still returns "111")

var values = collection.GetValues("B");  // very little-known method, returning [ "888", "999" ]  (this is handy when you expect more than one value for a single key)

value = collection["B"];  // returns "888,999" this is often inconvenient making the caller "(check and) split."
```

**Will NOT throw with a missing key**
``` csharp
var kn = new System.Collections.Specialized.NameValueCollection();
var values1 = kn.GetValues("BadKey");  // null
var values2 = kn["BadName"];  // also null
```
