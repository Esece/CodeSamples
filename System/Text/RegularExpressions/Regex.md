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
Regex.Replace(value, "<.*?>", "")
```

Replace (complex)
``` csharp
Regex.Replace(value, "<.*?>", m => m.Value.ToUpper())  // replace with all caps
```

"Singleline" Mode for Multiline Text Matching
``` csharp
var multilineText = String.Join("\r\n", "line1", "line2");
var matchFound = Regex.IsMatch(multilineText, "line.*?line", RegexOptions.Singleline);  // true  
```

> **Extremely confusing, but the dot expression does NOT work with 'RegexOptions.Multiline'**

Regex Escape
``` csharp
Regex.Escape("[12.34]")  // \[12\.34]
```

By Examples (C#)

|Description|Value|Pattern|Result|
|-----|-----|-----|-----|
|Extract index|"Labels[5]"|@"([a-zA-Z_][a-zA-Z0-9_]*\\[)(\d+)(\\])$"|5|
