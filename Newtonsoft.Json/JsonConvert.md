###### Newtonsoft.Json.JsonConvert
## JsonConvert

Serialize
``` csharp
JsonConvert.SerializeObject(value)
```

Serialize with Indentation
``` csharp
JsonConvert.SerializeObject(value, Formatting.Indented)
```

Pretty Print JSON (String)
``` csharp
JsonConvert.SerializeObject(JsonConvert.DeserializeObject(json), Newtonsoft.Json.Formatting.Indented);
```

Deep Copy using JSON Serialization
``` csharp
static T DeepClone<T>(T obj)
{
    if (Object.ReferenceEquals(obj, null))
    {
        return default(T);
    }
    
    var json = JsonConvert.SerializeObject(obj);
    var settings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace };
    
    return JsonConvert.DeserializeObject<T>(json, settings);
}
```
