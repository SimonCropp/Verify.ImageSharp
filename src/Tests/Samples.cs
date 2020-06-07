﻿using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using Verify;
using VerifyNUnit;
using NUnit.Framework;

#region TestDefinition
[TestFixture]
public class Samples
{
    static Samples()
    {
        VerifyImageSharp.Initialize();
    }
    #endregion

    #region VerifyImageFile

    [Test]
    public Task VerifyImageFile()
    {
        return Verifier.VerifyFile("sample.jpg");
    }

    #endregion

    #region VerifyImage

    [Test]
    public Task VerifyImage()
    {
        var image = new Image<Rgba32>(11, 11)
        {
            [5, 5] = Rgba32.ParseHex("#0000FF")
        };
        var settings = new VerifySettings();
        settings.UseExtension("png");
        return Verifier.Verify(image, settings);
    }
    #endregion
}