﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System;
using ImageMagick;
using Xunit;

namespace Magick.NET.Tests
{
    public partial class MagickImageTests
    {
        public class TheSampleMethod
        {
            [Fact]
            public void ShouldThrowExceptionWhenGeometryIsNull()
            {
                using (var image = new MagickImage())
                {
                    Assert.Throws<ArgumentNullException>("geometry", () => image.Sample(null));
                }
            }

            [Fact]
            public void ShouldResizeTheImage()
            {
                using (var image = new MagickImage(Files.Builtin.Logo))
                {
                    image.Sample(400, 400);
                    Assert.Equal(400, image.Width);
                    Assert.Equal(300, image.Height);
                }
            }

            [Fact]
            public void ShouldUseTheSpecifiedGeometry()
            {
                using (var image = new MagickImage(Files.Builtin.Logo))
                {
                    image.Sample(new MagickGeometry(300, 300));
                    Assert.Equal(300, image.Width);
                    Assert.Equal(225, image.Height);
                }
            }

            [Fact]
            public void ShouldUseTheSpecifiedPercentage()
            {
                using (var image = new MagickImage(Files.Builtin.Logo))
                {
                    image.Sample(new Percentage(50));
                    Assert.Equal(320, image.Width);
                    Assert.Equal(240, image.Height);
                }
            }
        }
    }
}
