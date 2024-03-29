﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System;
using ImageMagick;
using Xunit;

namespace Magick.NET.Tests
{
    public class QuantumConverterTests
    {
        [Fact]
        public void Test_ToArray()
        {
            var value = QuantumConverter.ToArray(IntPtr.Zero, 4);
            Assert.Null(value);
        }
    }
}
