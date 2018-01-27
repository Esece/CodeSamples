###### System.Drawing.Bitmap
### Bitmap

Draw in Memory
``` csharp
using (var image = new Bitmap(500, 500))
{
    using (var g = System.Drawing.Graphics.FromImage(image))
    {
        // draw..
    }
}
```

Resize Image
``` csharp
Image original;
:
Image resized = new Bitmap(original, new Size(width, height))
```

Crop Image
``` csharp
var image = new Bitmap(image);
var cropped = image.Clone(new Rectangle(x, y, width, height), image.PixelFormat);
```

Create Non-Indexed Image
``` csharp
Bitmap original;
:
var copy = new Bitmap(original.Width, original.Height, PixelFormat.Format32bppArgb);

using (var img = Graphics.FromImage(copy))
{
    img.DrawImage(original, 0, 0);
}

return copy;
```

