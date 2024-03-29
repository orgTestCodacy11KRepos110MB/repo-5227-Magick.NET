﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System.IO;
using System.Linq;
using ImageMagick;
using Xunit;

namespace Magick.NET.Tests
{
    // TODO: Move methods to another class
    public partial class ExifProfileTests
    {
        [Fact]
        public void Test_Fraction()
        {
            using (var memStream = new MemoryStream())
            {
                var exposureTime = 1.0 / 1600;

                using (var image = new MagickImage(Files.FujiFilmFinePixS1ProJPG))
                {
                    var profile = image.GetExifProfile();

                    profile.SetValue(ExifTag.ExposureTime, new Rational(exposureTime));
                    image.SetProfile(profile);

                    image.Write(memStream);
                }

                memStream.Position = 0;
                using (var image = new MagickImage(memStream))
                {
                    var profile = image.GetExifProfile();

                    Assert.NotNull(profile);

                    var value = profile.GetValue(ExifTag.ExposureTime);
                    Assert.NotNull(value);
                    Assert.NotEqual(exposureTime, value.Value.ToDouble());
                }

                memStream.Position = 0;
                using (var image = new MagickImage(Files.FujiFilmFinePixS1ProJPG))
                {
                    var profile = image.GetExifProfile();

                    profile.SetValue(ExifTag.ExposureTime, new Rational(exposureTime, true));
                    image.SetProfile(profile);

                    image.Write(memStream);
                }

                memStream.Position = 0;
                using (var image = new MagickImage(memStream))
                {
                    var profile = image.GetExifProfile();

                    Assert.NotNull(profile);

                    var value = profile.GetValue(ExifTag.ExposureTime);
                    Assert.Equal(exposureTime, value.Value.ToDouble());
                }
            }
        }

        [Fact]
        public void Test_Infinity()
        {
            using (var image = new MagickImage(Files.FujiFilmFinePixS1ProJPG))
            {
                var profile = image.GetExifProfile();
                profile.SetValue(ExifTag.ExposureBiasValue, new SignedRational(double.PositiveInfinity));
                image.SetProfile(profile);

                profile = image.GetExifProfile();
                var value = profile.GetValue(ExifTag.ExposureBiasValue);
                Assert.NotNull(value);
                Assert.Equal(double.PositiveInfinity, value.Value.ToDouble());

                profile.SetValue(ExifTag.ExposureBiasValue, new SignedRational(double.NegativeInfinity));
                image.SetProfile(profile);

                profile = image.GetExifProfile();
                value = profile.GetValue(ExifTag.ExposureBiasValue);
                Assert.NotNull(value);
                Assert.Equal(double.NegativeInfinity, value.Value.ToDouble());

                profile.SetValue(ExifTag.FlashEnergy, new Rational(double.NegativeInfinity));
                image.SetProfile(profile);

                profile = image.GetExifProfile();
                var flashValue = profile.GetValue(ExifTag.FlashEnergy);
                Assert.NotNull(flashValue);
                Assert.Equal(double.PositiveInfinity, flashValue.Value.ToDouble());
            }
        }

        [Fact]
        public void Test_Values()
        {
            using (var image = new MagickImage(Files.FujiFilmFinePixS1ProJPG))
            {
                var profile = image.GetExifProfile();
                TestExifProfile(profile);

                using (var emptyImage = new MagickImage(Files.ImageMagickJPG))
                {
                    Assert.Null(emptyImage.GetExifProfile());
                    emptyImage.SetProfile(profile);

                    profile = emptyImage.GetExifProfile();
                    TestExifProfile(profile);
                }
            }
        }

        [Fact]
        public void Test_ExifTypeUndefined()
        {
            using (var image = new MagickImage(Files.ExifUndefTypeJPG))
            {
                var profile = image.GetExifProfile();
                Assert.NotNull(profile);

                foreach (var value in profile.Values)
                {
                    if (value.DataType == ExifDataType.Undefined)
                    {
                        var data = (byte[])value.GetValue();
                        Assert.Equal(4, data.Length);
                    }
                }
            }
        }

        private static void TestExifProfile(IExifProfile profile)
        {
            Assert.NotNull(profile);

            Assert.Equal(44, profile.Values.Count());

            foreach (var value in profile.Values)
            {
                Assert.NotNull(value.GetValue());

                if (value.Tag == ExifTag.Software)
                    Assert.Equal("Adobe Photoshop 7.0", value.ToString());

                if (value.Tag == ExifTag.XResolution)
                    Assert.Equal(new Rational(300, 1), (Rational)value.GetValue());

                if (value.Tag == ExifTag.GPSLatitude)
                {
                    var pos = (Rational[])value.GetValue();
                    Assert.Equal(54, pos[0].ToDouble());
                    Assert.Equal(59.38, pos[1].ToDouble());
                    Assert.Equal(0, pos[2].ToDouble());
                }

                if (value.Tag == ExifTag.ShutterSpeedValue)
                    Assert.Equal(9.5, ((SignedRational)value.GetValue()).ToDouble());
            }
        }
    }
}
