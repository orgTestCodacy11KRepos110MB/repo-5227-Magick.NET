﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System;
using System.IO;
using ImageMagick;
using Xunit;

namespace Magick.NET.Tests
{
    public partial class StreamWrapperTests
    {
        public class TheSeekMethod
        {
            [Fact]
            public unsafe void ShouldNotThrowExceptionWhenWhenStreamThrowsExceptionDuringSeeking()
            {
                using (var memStream = new MemoryStream())
                {
                    using (var stream = new SeekExceptionStream(memStream))
                    {
                        using (var streamWrapper = StreamWrapper.CreateForReading(stream))
                        {
                            var buffer = new byte[255];
                            fixed (byte* p = buffer)
                            {
                                var count = streamWrapper.Seek(0, IntPtr.Zero, IntPtr.Zero);
                                Assert.Equal(-1, count);
                            }
                        }
                    }
                }
            }

            [Fact]
            public unsafe void ShouldUseStartPositionOfStreamAsBegin()
            {
                using (var memStream = new MemoryStream())
                {
                    memStream.Position = 42;

                    using (var streamWrapper = StreamWrapper.CreateForReading(memStream))
                    {
                        memStream.Position = 0;

                        var result = streamWrapper.Seek(0, (IntPtr)SeekOrigin.Begin, IntPtr.Zero);

                        Assert.Equal(0, result);
                        Assert.Equal(42, memStream.Position);
                    }
                }
            }

            [Fact]
            public unsafe void ShouldUseStartPositionAsOffset()
            {
                using (var memStream = new MemoryStream())
                {
                    memStream.Position = 42;

                    using (var streamWrapper = StreamWrapper.CreateForReading(memStream))
                    {
                        var result = streamWrapper.Seek(10, (IntPtr)SeekOrigin.Current, IntPtr.Zero);

                        Assert.Equal(10, result);
                        Assert.Equal(52, memStream.Position);
                    }
                }
            }

            [Fact]
            public unsafe void ShouldRemoveStartPositionFromEndOffset()
            {
                using (var memStream = new MemoryStream(new byte[64]))
                {
                    memStream.Position = 42;

                    using (var streamWrapper = StreamWrapper.CreateForReading(memStream))
                    {
                        var result = streamWrapper.Seek(0, (IntPtr)SeekOrigin.End, IntPtr.Zero);

                        Assert.Equal(22, result);
                        Assert.Equal(64, memStream.Position);
                    }
                }
            }

            [Fact]
            public unsafe void ShouldReturnMinusOneForInvalidWhence()
            {
                using (var memStream = new MemoryStream())
                {
                    using (var streamWrapper = StreamWrapper.CreateForReading(memStream))
                    {
                        var result = streamWrapper.Seek(0, (IntPtr)3, IntPtr.Zero);

                        Assert.Equal(-1, result);
                    }
                }
            }
        }
    }
}
