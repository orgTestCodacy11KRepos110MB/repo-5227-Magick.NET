﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System;
using System.IO;
using ImageMagick;

namespace Magick.NET.Samples
{
    public static class ReadImageSamples
    {
        private static MemoryStream LoadMemoryStreamImage()
        {
            return new MemoryStream(LoadImageBytes());
        }

        private static byte[] LoadImageBytes()
        {
            return File.ReadAllBytes(SampleFiles.SnakewarePng);
        }

        public static void ReadImage()
        {
            // Read from file.
            using (var image = new MagickImage(SampleFiles.SnakewareJpg))
            {
            }

            // Read from stream.
            using (var memStream = LoadMemoryStreamImage())
            {
                using (var image = new MagickImage(memStream))
                {
                }
            }

            // Read from byte array.
            var data = LoadImageBytes();
            using (var image = new MagickImage(data))
            {
            }

            // Read image that has no predefined dimensions.
            var settings = new MagickReadSettings();
            settings.Width = 800;
            settings.Height = 600;
            using (var image = new MagickImage("xc:yellow", settings))
            {
            }

            using (var image = new MagickImage())
            {
                image.Read(SampleFiles.SnakewareJpg);
                image.Read(data);
                image.Read("xc:yellow", settings);

                using (var memStream = LoadMemoryStreamImage())
                {
                    image.Read(memStream);
                }
            }
        }

        public static void ReadBasicImageInformation()
        {
            // Read from file
            var info = new MagickImageInfo(SampleFiles.SnakewarePng);

            // Read from stream
            using (var memStream = LoadMemoryStreamImage())
            {
                info = new MagickImageInfo(memStream);
            }

            // Read from byte array
            var data = LoadImageBytes();
            info = new MagickImageInfo(data);

            info = new MagickImageInfo();
            info.Read(SampleFiles.SnakewarePng);
            using (var memStream = LoadMemoryStreamImage())
            {
                info.Read(memStream);
            }
            info.Read(data);

            Console.WriteLine(info.Width);
            Console.WriteLine(info.Height);
            Console.WriteLine(info.ColorSpace);
            Console.WriteLine(info.Format);
            Console.WriteLine(info.Density.X);
            Console.WriteLine(info.Density.Y);
            Console.WriteLine(info.Density.Units);
        }

        public static void ReadImageWithMultipleFrames()
        {
            // Read from file
            using (var images = new MagickImageCollection(SampleFiles.SnakewareJpg))
            {
            }

            // Read from stream
            using (var memStream = LoadMemoryStreamImage())
            {
                using (var images = new MagickImageCollection(memStream))
                {
                }
            }

            // Read from byte array
            var data = LoadImageBytes();
            using (var images = new MagickImageCollection(data))
            {
            }

            // Read pdf with custom density.
            var settings = new MagickReadSettings();
            settings.Density = new Density(144);

            using (var images = new MagickImageCollection(SampleFiles.SnakewarePdf, settings))
            {
            }

            using (var images = new MagickImageCollection())
            {
                images.Read(SampleFiles.SnakewareJpg);
                using (var memStream = LoadMemoryStreamImage())
                {
                    images.Read(memStream);
                }
                images.Read(data);
                images.Read(SampleFiles.SnakewarePdf, settings);
            }
        }
    }
}
