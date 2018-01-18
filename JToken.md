### JToken
###### Newtonsoft.Json.Linq.JToken

DeepEquals (Compare Values for Equality)
``` csharp
var prod1 = new Product();
:

var prod2 = new Product();
:

bool same = JToken.DeepEquals(JObject.FromObject(prod1), JObject.FromObject(prod2));
```
