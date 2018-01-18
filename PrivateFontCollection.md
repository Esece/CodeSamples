### PrivateFontCollection
###### System.Drawing.Text.PrivateFontCollection

Load and use a font privately
``` csharp
using (var fonts = new PrivateFontCollection())
{
    fonts.AddFontFile(@"C:\AwesomeFont.ttf");

    var fontFamily = fonts.Families.First();
    :
    
}
```
