### Regex
###### System.Text.RegularExpressions.Regex

Matches
``` csharp
foreach (Match match in Regex.Matches(result, @"(<pre>)(.*?)(</pre>)"))  // cannot use 'var' here..
{
    var innerText = WebUtility.HtmlDecode(match.Groups[2].Value);
    Console.WriteLine(innerText);
};
```

Replace
``` csharp
Regex.Replace(null, "<.*?>", "")
```

