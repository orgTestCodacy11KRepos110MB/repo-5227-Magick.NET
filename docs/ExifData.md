# Exif data

## Read exif data

```C#
// Read image from file
using (var image = new MagickImage("c:\path\to\FujiFilmFinePixS1Pro.jpg"))
{
    // Retrieve the exif information
    var profile = image.GetExifProfile();

    // Check if image contains an exif profile
    if (profile is null)
        Console.WriteLine("Image does not contain exif information.");
    else
    {
        // Write all values to the console
        foreach (var value in profile.Values)
        {
            Console.WriteLine("{0}({1}): {2}", value.Tag, value.DataType, value.ToString());
        }
    }
}
```

## Create thumbnail from exif data

```C#
// Read image from file
using (var image = new MagickImage("c:\path\to\FujiFilmFinePixS1Pro.jpg"))
{
    // Retrieve the exif information
    var profile = image.GetExifProfile();

    // Create thumbnail from exif information
    using (var thumbnail = profile.CreateThumbnail())
    {
        // Check if exif profile contains thumbnail and save it
        if (thumbnail != null)
            thumbnail.Write("c:\path\to\FujiFilmFinePixS1Pro.thumb.jpg");
    }
}
```
