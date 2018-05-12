###### System.Dynamic.ExpandoObject
## ExpandoObject

``` csharp
dynamic expando = new System.Dynamic.ExpandoObject();
expando.Name = "Brian";
expando.Country = "USA";

string propertyName = "TestName";
int propertyValue = 987455615;

var expandoDict = expando as IDictionary<string, object>;

if (expandoDict.ContainsKey(propertyName))
{
    expandoDict[propertyName] = propertyValue;
}
else
{
    expandoDict.Add(propertyName, propertyValue);
}
```
