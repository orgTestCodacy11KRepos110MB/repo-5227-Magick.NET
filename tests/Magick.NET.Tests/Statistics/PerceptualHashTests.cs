﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System;
using ImageMagick;
using Xunit;

namespace Magick.NET.Tests
{
    public class PerceptualHashTests
    {
        [Fact]
        public void Test_Channel()
        {
            using (var image = new MagickImage(Files.ImageMagickJPG))
            {
                var phash = image.PerceptualHash();
                var channel = phash.GetChannel(PixelChannel.Red);

                Assert.Throws<ArgumentOutOfRangeException>(() =>
                {
                    channel.HclpHuPhash(7);
                });

                Assert.Throws<ArgumentOutOfRangeException>(() =>
                {
                    channel.SrgbHuPhash(7);
                });

#if Q8
                TestChannel(channel, 0, 0.6980, 0.6980, 0.0974, 0.0993);
                TestChannel(channel, 1, 3.4388, 3.4390, 0.6582, 0.6685);
                TestChannel(channel, 2, 3.9123, 3.9123, 0.9238, 0.9195);
                TestChannel(channel, 3, 4.2922, 4.2920, 2.3627, 2.3354);
                TestChannel(channel, 4, 8.7570, 8.7574, 4.9574, 5.2273);
                TestChannel(channel, 5, 8.2422, 8.2149, 2.8422, 2.8360);
                TestChannel(channel, 6, 8.4397, 8.4394, 4.0087, 3.9636);
#elif Q16
                TestChannel(channel, 0, 0.6979, 0.6979, 0.2575, 0.2570);
                TestChannel(channel, 1, 3.4385, 3.4385, 1.0621, 1.0552);
                TestChannel(channel, 2, 3.9123, 3.9123, 1.3756, 1.3800);
                TestChannel(channel, 3, 4.2920, 4.2920, 2.8341, 2.8360);
                TestChannel(channel, 4, 8.7557, 8.7557, 5.1134, 5.1087);
                TestChannel(channel, 5, 8.3019, 8.3018, 3.4791, 3.4733);
                TestChannel(channel, 6, 8.4398, 8.4398, 5.0679, 5.0815);
#else
                TestChannel(channel, 0, 0.6979, 0.6979, 0.2944, 0.2945);
                TestChannel(channel, 1, 3.4385, 3.4385, 1.1850, 1.1834);
                TestChannel(channel, 2, 3.9123, 3.9123, 1.5006, 1.5009);
                TestChannel(channel, 3, 4.2920, 4.2920, 3.0480, 3.0419);
                TestChannel(channel, 4, 8.7557, 8.7557, 5.3844, 5.3651);
                TestChannel(channel, 5, 8.3018, 8.3018, 3.6804, 3.6675);
                TestChannel(channel, 6, 8.4398, 8.4398, 5.6247, 5.6501);
#endif

                channel = phash.GetChannel(PixelChannel.Green);
#if Q8
                TestChannel(channel, 0, 0.6942, 0.6942, -0.0601, -0.0601);
                TestChannel(channel, 1, 3.3993, 3.3995, 0.3090, 0.3093);
                TestChannel(channel, 2, 4.1171, 4.1172, 0.6084, 0.6083);
                TestChannel(channel, 3, 4.4847, 4.4847, 0.7559, 0.7566);
                TestChannel(channel, 4, 8.8180, 8.8183, 1.7224, 1.7237);
                TestChannel(channel, 5, 6.4829, 6.4832, 0.9413, 0.9421);
                TestChannel(channel, 6, 9.2143, 9.2141, 1.5065, 1.5074);
#elif Q16
                TestChannel(channel, 0, 0.6942, 0.6942, -0.0601, -0.0601);
                TestChannel(channel, 1, 3.3989, 3.3989, 0.3092, 0.3092);
                TestChannel(channel, 2, 4.1169, 4.1169, 0.6084, 0.6084);
                TestChannel(channel, 3, 4.4844, 4.4844, 0.7559, 0.7559);
                TestChannel(channel, 4, 8.8174, 8.8174, 1.7230, 1.7230);
                TestChannel(channel, 5, 6.4821, 6.4821, 0.9413, 0.9413);
                TestChannel(channel, 6, 9.2148, 9.2148, 1.5063, 1.5063);
#else
                TestChannel(channel, 0, 0.6942, 0.6942, -0.0601, -0.0601);
                TestChannel(channel, 1, 3.3989, 3.3989, 0.3092, 0.3092);
                TestChannel(channel, 2, 4.1169, 4.1169, 0.6084, 0.6084);
                TestChannel(channel, 3, 4.4844, 4.4844, 0.7559, 0.7559);
                TestChannel(channel, 4, 8.8174, 8.8174, 1.7230, 1.7230);
                TestChannel(channel, 5, 6.4821, 6.4821, 0.9413, 0.9413);
                TestChannel(channel, 6, 9.2148, 9.2148, 1.5063, 1.5063);
#endif

                channel = phash.GetChannel(PixelChannel.Blue);
#if Q8
                TestChannel(channel, 0, 0.7223, 0.7223, 0.6984, 0.6984);
                TestChannel(channel, 1, 3.8298, 3.8298, 3.4611, 3.4612);
                TestChannel(channel, 2, 5.1301, 5.1301, 4.1312, 4.1312);
                TestChannel(channel, 3, 5.0217, 5.0218, 4.4867, 4.4867);
                TestChannel(channel, 4, 10.4769, 10.4761, 8.8669, 8.8670);
                TestChannel(channel, 5, 6.9453, 6.9454, 6.6108, 6.6110);
                TestChannel(channel, 6, 10.1394, 10.1396, 9.0725, 9.0722);
#elif Q16
                TestChannel(channel, 0, 0.7222, 0.7222, 0.6984, 0.6984);
                TestChannel(channel, 1, 3.8295, 3.8295, 3.4609, 3.4609);
                TestChannel(channel, 2, 5.1304, 5.1304, 4.1314, 4.1314);
                TestChannel(channel, 3, 5.0214, 5.0214, 4.4866, 4.4866);
                TestChannel(channel, 4, 10.4771, 10.4772, 8.8663, 8.8663);
                TestChannel(channel, 5, 6.9448, 6.9448, 6.6094, 6.6094);
                TestChannel(channel, 6, 10.1388, 10.1388, 9.0737, 9.0737);
#else
                TestChannel(channel, 0, 0.7222, 0.7222, 0.6984, 0.6984);
                TestChannel(channel, 1, 3.8295, 3.8295, 3.4609, 3.4609);
                TestChannel(channel, 2, 5.1304, 5.1304, 4.1314, 4.1314);
                TestChannel(channel, 3, 5.0214, 5.0214, 4.4866, 4.4866);
                TestChannel(channel, 4, 10.4772, 10.4772, 8.8663, 8.8663);
                TestChannel(channel, 5, 6.9448, 6.9448, 6.6094, 6.6094);
                TestChannel(channel, 6, 10.1388, 10.1388, 9.0737, 9.0737);
#endif
            }
        }

        [Fact]
        public void Test_Constructor()
        {
            Assert.Throws<ArgumentNullException>("hash", () =>
            {
                new PerceptualHash(null);
            });

            Assert.Throws<ArgumentException>("hash", () =>
            {
                new PerceptualHash(string.Empty);
            });

            Assert.Throws<ArgumentException>("hash", () =>
            {
                new PerceptualHash("a0df");
            });

            Assert.Throws<ArgumentException>("hash", () =>
            {
                new PerceptualHash("H00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            });
        }

        [Fact]
        public void Test_ToString()
        {
            using (var image = new MagickImage(Files.ImageMagickJPG))
            {
                var phash = image.PerceptualHash();
                var hash = phash.ToString();
                Assert.Equal(210, hash.Length);
#if Q8
                OpenCLValue.Assert("81b4488655898d38a7aa6223562032620f8a2614819b78241685c4b8c1a786f0689c9881b1f884ca8a0d38af2f622728fd3d623fedeacea78bcaedaa81d8884349824c583ad981c37895998c8658c42a628ed61b216279b81b49887348a1608af44622a3619d362371", "81b4488656898d38a7a96223562017620f7a26cd81a1e823ec85b3b8cc3186ec889ad481b1f884cb8a0d58af30622728fd41623fedea8aa78d4aeda481d8f84355824cd83ae281c378959a8c8668c42a628ec61b216279c81b49887348a1608af44622a3619d362370", hash);
#elif Q16
                OpenCLValue.Assert("81b4488652898d48a7a9622346206e620f8a649d8297d835bd86eb58c7be887e78c5f881b1e884c58a0d18af2d622718fd35623ffdeac9a78cbaedaa81d888434e824c683ad781c37895978c8688c426628ed61b216279b81b48887318a1628af43622a2619d162372", "81b4488652898d48a7a9622346206e620f8a646682939835e986ec98c78f887ae8c67f81b1e884c58a0d18af2d622718fd35623ffdeac9a78cbaedaa81d888434e824c683ad781c37895978c8688c426628ed61b216279b81b48887318a1628af43622a2619d162372", hash);
#else
                OpenCLValue.Assert("81b4488652898d48a7a9622346206e620f8a730882e4a83a9e877108d25488fc58dbb781b1e884c58a0d18af2d622718fd35623ffdeac9a78cbaedaa81d888434e824c683ad781c37895978c8688c426628ed61b216279b81b48887318a1628af43622a2619d162372", "81b4488652898d48a7a9622346206e620f8a731182e3a83aa2876d48d19488f438dcb581b1e884c58a0d18af2d622718fd35623ffdeac9a78cbaedaa81d888434e824c683ad781c37895978c8688c426628ed61b216279b81b48887318a1628af43622a2619d162372", hash);
#endif
                var clone = new PerceptualHash(hash);
                Assert.InRange(phash.SumSquaredDistance(clone), 0.0, 0.001);
            }
        }

        [Fact]
        public void Test_SumSquaredDistance()
        {
            using (var image = new MagickImage(Files.ImageMagickJPG))
            {
                var phash = image.PerceptualHash();

                using (var other = new MagickImage(Files.MagickNETIconPNG))
                {
                    other.HasAlpha = false;
                    Assert.Equal(3, other.ChannelCount);

                    var otherPhash = other.PerceptualHash();
#if Q8
                    OpenCLValue.Assert(394.74, 394.90, phash.SumSquaredDistance(otherPhash), 0.01);
#elif Q16
                    OpenCLValue.Assert(395.35, 395.39, phash.SumSquaredDistance(otherPhash), 0.02);
#else
                    OpenCLValue.Assert(395.60, 395.68, phash.SumSquaredDistance(otherPhash), 0.02);
#endif
                }
            }
        }

        private void TestChannel(IChannelPerceptualHash channel, int index, double srgbHuPhashWithOpenCL, double srgbHuPhashWithoutOpenCL, double hclpHuPhashWithOpenCL, double hclpHuPhashWithoutOpenCL)
        {
            OpenCLValue.Assert(srgbHuPhashWithOpenCL, srgbHuPhashWithoutOpenCL, channel.SrgbHuPhash(index), 0.0001);
            OpenCLValue.Assert(hclpHuPhashWithOpenCL, hclpHuPhashWithoutOpenCL, channel.HclpHuPhash(index), 0.0001);
        }
    }
}
