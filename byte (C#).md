###### C#
## byte

Parse Sequence of Hex Values
``` csharp
var hex = "65742E6D";
var bytes = Enumerable.Range(0, hex.Length / 2).Select(i => byte.Parse(hex.Substring(i*2, 2), NumberStyles.AllowHexSpecifier)).ToArray();
bytes.Select(b => (char)b).ToList().ForEach(Console.Write);  // "et.m"
```
