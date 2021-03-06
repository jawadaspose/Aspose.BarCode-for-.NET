﻿using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class Create2DBarcodes
    {
        public static void Run()
        {
            // ExStart:Create2DBarcodes
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Instantiate barcode object and set CodeText & Barcode Symbology
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("this is some test code text. \n Second line \n third line.", EncodeTypes.Pdf417)
           {
               // Set width and height
               xDimension = 0.6f,
               yDimension = 1.2f
           };

            // Save the Barcode image
            barCodeBuilder.Save(dataDir + "2d-barcode_out.jpg", BarCodeImageFormat.Jpeg);
            // ExEnd:Create2DBarcodes
        }
    }
}
