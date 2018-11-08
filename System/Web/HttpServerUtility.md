##### System.Web.HttpServerUtility
## HttpServerUtility

Web-Safe Base64 Encoding
``` csharp
var data = "public class TestClass \r\n{\r\n    //implementation here...\r\n}\r\n";
var bytes = Encoding.ASCII.GetBytes(data);

var encoded = HttpServerUtility.UrlTokenEncode(bytes);  // "cHVibGljIGNsYXNzIFRlc3RDbGFzcyANCnsNCiAgICAvL2ltcGxlbWVudGF0aW9uIGhlcmUuLi4NCn0NCg2"

var decoded = HttpServerUtility.UrlTokenDecode(encoded);
```
