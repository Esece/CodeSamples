###### System.Drawing.Text.InstalledFontCollection
### InstalledFontCollection

Get All Fonts
``` csharp
static IEnumerable<string> GetFonts()
{
    foreach (var font in new System.Drawing.Text.InstalledFontCollection().Families)
    {
        yield return font.Name;
    }
}
```
