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

``` csharp
dynamic epdObj = new ExpandoObject();
epdObj.FirstName = "Robert";
epdObj.LastName = "Smith";
epdObj.Email = "rsmith@email.com";
```

``` csharp
var epdObj = (IDictionary<string, object>)new ExpandoObject();
epdObj["First Name"] = "Robert";
epdObj["Last Name"] = "Smith";
epdObj["Email"] = "rsmith@email.com";

var dynamicObject = (dynamic)epdObj;  // cast to dynamic
Console.WriteLine(dynamicObject.Email);  // prints "rsmith@email.com"
```
