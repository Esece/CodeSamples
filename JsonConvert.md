### JsonConvert
###### Newtonsoft.Json.JsonConvert

Deep Copy using JSON Serialization
``` csharp
static T DeepClone<T>(T obj)
{
    if (Object.ReferenceEquals(obj, null))
    {
        return default(T);
    }
    
    var json = JsonConvert.SerializeObject(obj).Dump();
    var settings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace };
    
    return JsonConvert.DeserializeObject<T>(json, settings);
}
```
