# Convert image

## Convert image from one format to another

```C#
// Read first frame of gif image
using (var image = new MagickImage("c:\path\to\Snakeware.gif"))
{
    // Save frame as jpg
    image.Write("c:\path\to\Snakeware.jpg");
}

// Write to stream
var settings = new MagickReadSettings();
// Tells the xc: reader the image to create should be 800x600
settings.Width = 800;
settings.Height = 600;

using (var memStream = new MemoryStream())
{
    // Create image that is completely purple and 800x600
    using (var image = new MagickImage("xc:purple", settings))
    {
        // Sets the output format to png
        image.Format = MagickFormat.Png;

        // Write the image to the memorystream
        image.Write(memStream);
    }
}

// Read image from file
using (var image = new MagickImage("c:\path\to\Snakeware.png"))
{
    // Sets the output format to jpeg
    image.Format = MagickFormat.Jpeg;

    // Create byte array that contains a jpeg file
    byte[] data = image.ToByteArray();
}
```

## Convert CMYK to RGB

```C#
// Uses sRGB.icm, eps/pdf produce better result when you set this before loading.
var settings = new MagickReadSettings();
settings.ColorSpace = ColorSpace.sRGB;

// Create empty image 
using (var image = new MagickImage())
{
    // Reads the eps image, the specified settings tell Ghostscript to create an sRGB image
    image.Read("c:\path\to\Snakeware.eps", settings);

    // Save image as tiff
    image.Write("c:\path\to\Snakeware.tiff");
}

// Read image from file
using (var image = new MagickImage("c:\path\to\Snakeware.jpg"))
{
    // Will use the CMYK profile if the image does not contain a color profile.
    // The second profile will transform the colorspace from CMYK to RGB
    image.TransformColorSpace(ColorProfile.USWebCoatedSWOP, ColorProfile.SRGB);

    // Save image as png
    image.Write("c:\path\to\Snakeware.png");
}

// Use custom color profile
using (var image = new MagickImage("c:\path\to\Snakeware.jpg"))
{
    // Will use the CMYK profile if your image does not contain a color profile.
    // The second profile will transform the colorspace from your custom icc profile
    image.TransformColorSpace(ColorProfile.USWebCoatedSWOP, new ColorProfile("YourProfile.icc"));

    // Save image as tiff
    image.Write("c:\path\to\Snakeware.tiff");
}
```
