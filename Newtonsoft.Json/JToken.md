###### Newtonsoft.Json.Linq.JToken
### JToken

Compare Values for Equality
``` csharp
static bool AreIdentical<T>(T a, T b)
{
    // objects need to be wrapped to avoid serialization error for types like Guid..
    return JToken.DeepEquals(JObject.FromObject(new { a }), JObject.FromObject(new { b }));
}
```

