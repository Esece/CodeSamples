##### System.Web
## HttpCookie

Parse Set-Cookie (Header) Value
``` csharp
var setCookie = "1P_JAR=2019-10-03-16; expires=Sat, 02-Nov-2019 16:26:51 GMT; path=/; domain=.google.com; SameSite=none";
HttpCookie.TryParse(setCookie, out var cookie);
```
