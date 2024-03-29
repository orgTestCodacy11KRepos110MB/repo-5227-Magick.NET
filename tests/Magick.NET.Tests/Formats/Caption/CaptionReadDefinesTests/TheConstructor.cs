﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using ImageMagick;
using ImageMagick.Formats;
using Xunit;

namespace Magick.NET.Tests
{
    public partial class CaptionReadDefinesTests
    {
        public class TheConstructor
        {
            [Fact]
            public void ShouldNotSetAnyDefines()
            {
                using (var image = new MagickImage())
                {
                    image.Settings.SetDefines(new CaptionReadDefines());

                    Assert.Null(image.Settings.GetDefine(MagickFormat.Caption, "max-pointsize"));
                    Assert.Null(image.Settings.GetDefine(MagickFormat.Caption, "start-pointsize"));
                }
            }
        }
    }
}
