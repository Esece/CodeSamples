###### System.String
# String

Split
``` csharp
var lines = "one\r\ntwo\r\nthree".Split(new[] { "\r\n" }, StringSplitOptions.None);
```

Split
``` csharp
var values = "key:value:value2".Split(new[] { ':' }, 2);  // returns { "key", "value:value2" }
```
