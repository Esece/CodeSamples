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

Read Values
``` csharp
string json = @"{
  ""created_at"": ""2010-12-25T13:35:39Z"",
  ""is_return"": true,
  ""id"": 123456, 
  ""messages"": [
    {
      ""type"": ""error"",
      ""message"": ""Unable to locate""
    }
  ],
}";

var responseJson = (JObject)JsonConvert.DeserializeObject(json);

var created_at = responseJson["created_at"].Value<DateTime>();  // 12/25/2010 1:35:39 PM

var is_return = responseJson["is_return"] != null ? responseJson["is_return"].Value<bool>() : false;  // true

var id = responseJson["id"].Value<int>();  // 123456
var idLong = responseJson["id"].Value<long>();  // 123456L

var message = responseJson["messages"][0]["message"].Value<string>();  // "Unable to locate the shipper_id: fghj"
message = responseJson["messages"][0]["message"].Value<string>();  // "Unable to locate the shipper_id: fghj"

var array = (JArray)responseJson["messages"];

foreach (JObject element in array)
{
    message = element["message"].Value<string>();  // "Unable to locate the shipper_id: fghj"
}
```
