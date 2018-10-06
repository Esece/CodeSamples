###### Newtonsoft.Json.JsonConverter
## JsonConverter

Use enum underlying value strings for enum values
``` csharp
class EnumUnderlyingValueToStringConverter : .JsonConverter
{
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        var converted = Convert.ChangeType(value, value.GetType().GetEnumUnderlyingType()).ToString();
        serializer.Serialize(writer, converted);
    }

    public override object ReadJson(JsonReader reader, Type type, object value, JsonSerializer serializer)
    {
        throw new NotSupportedException();
    }

    public override bool CanRead
    {
        get { return false; }
    }

    public override bool CanConvert(Type type)
    {
        return type.IsEnum;
    }
}
```
Example
``` csharp
enum PackageType
{
    Unknown,
    Bag,
    Crate,
}
```
``` javascript
{"PackageType":"1"}
```
