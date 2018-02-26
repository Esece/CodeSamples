###### System.Web.Script.Serialization.JavaScriptSerializer
## JavaScriptSerializer

``` csharp
var data = new 
{
    status = "failure",
    message = "Username is required.",
};

var serializer = new JavaScriptSerializer();
var json = serializer.Serialize(data);
Console.WriteLine(json);  // prints {"status":"failure","message":"Username is required."}
```

``` csharp
var json = "{\"status\":\"failure\",\"message\":\"Username is required.\"}";
var serializer = new JavaScriptSerializer();
var obj = (Dictionary<string, object>)serializer.DeserializeObject(json);

Console.WriteLine(obj["status"]);  // prints "failure"
```

``` csharp
string data = new JavaScriptSerializer().Deserialize<string>(data);   
```
