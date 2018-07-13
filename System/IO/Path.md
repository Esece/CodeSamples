###### System.IO.Path
### Path 

File Name
``` csharp
var path = @"C:\Users\A\Downloads\Doc.pdf";
var fileName = Path.GetFileName(file);  // "Doc.pdf"
```

Temp File Name with Custom Extension
``` csharp
var tempPdfFilePath = Path.ChangeExtension(Path.GetTempFileName(), "pdf");
```

ChangeExtension
``` csharp
Path.ChangeExtension("C:\test.dat", "txt")
```

