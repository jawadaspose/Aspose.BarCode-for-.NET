﻿Imports Aspose.BarCode

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.ManageBarCodes
    Class CreateUpcaGs1DatabarCoupon
        Public Shared Sub Run()
            ' ExStart:CreateUpcaGs1DatabarCoupon
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ManageBarCodes()

            ' Initialize BarCode builder class object
            Dim barCodeBuilder As New BarCodeBuilder()

            ' Set symbology type as UPCA & GS1 Databar coupon and set the barcode text
            barCodeBuilder.SymbologyType = Symbology.UpcaGs1DatabarCoupon

            ' Upca part is "514141100906", GS1Databar part is "(8110)001234502239811110555"
            barCodeBuilder.CodeText = "512345678900(8110)001234502239811110555"

            ' Set barcode caption and barcode
            barCodeBuilder.CaptionAbove.Text = "012345-022398"
            barCodeBuilder.Save(dataDir & Convert.ToString("couponUpcaDatabar.png"))
            ' ExEnd:CreateUpcaGs1DatabarCoupon
        End Sub
    End Class
End Namespace