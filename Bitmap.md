### Bitmap
###### System.Drawing.Bitmap

``` csharp
using (var image = new Bitmap(500, 500))
{
    using (var g = System.Drawing.Graphics.FromImage(image))
    {
        // draw..
    }
}
```
