# Defines

## Command line option -define

```C#
// Read image from file
using (var image = new MagickImage("c:\path\to\Snakeware.png"))
{
    // Tells the dds coder to use dxt1 compression when writing the image
    image.Settings.SetDefine(MagickFormat.Dds, "compression", "dxt1");
    // Write the image
    image.Write("c:\path\to\Snakeware.dds");
}
```

## Defines that need to be set before reading an image

```C#
var settings = new MagickReadSettings();
// Set define that tells the jpeg coder that the output image will be 32x32
settings.SetDefine(MagickFormat.Jpeg, "size", "32x32");

// Read image from file
using (var image = new MagickImage("c:\path\to\Snakeware.jpg"))
{
    // Create thumnail that is 32 pixels wide and 32 pixels high
    image.Thumbnail(32,32);
    // Save image as tiff
    image.Write("c:\path\to\Snakeware.tiff");
}
```
