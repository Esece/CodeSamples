##### Newtonsoft.Json.Serialization
## DefaultContractResolver

Null out the Id property
``` csharp
public class ShouldSerializeContractResolver : DefaultContractResolver
{
    protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
    {
        JsonProperty property = base.CreateProperty(member, memberSerialization);

        if (property.PropertyName == "Id")
        {
            return null;
        }

        return property;
    }
}

var json = JsonConvert.SerializeObject(data, new JsonSerializerSettings()
{
		ContractResolver = new ShouldSerializeContractResolver(),
});
```
