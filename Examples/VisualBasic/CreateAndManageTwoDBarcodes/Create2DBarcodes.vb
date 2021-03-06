﻿Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class Create2DBarcodes
        Public Shared Sub Run()
            'ExStart:Create2DBarcodes
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            ' Instantiate barcode object and set dimensions
            Dim barCodeBuilder As New BarCodeBuilder("this is some test code text. " & vbLf & " Second line " & vbLf & " third line.", EncodeTypes.Pdf417) With { _
                .xDimension = 0.6F, _
                .yDimension = 1.2F _
            }
            ' Save the Barcode image
            barCodeBuilder.Save(dataDir & Convert.ToString("2d-barcode_out.jpg"), BarCodeImageFormat.Jpeg)
            'ExEnd:Create2DBarcodes
        End Sub
    End Class
End Namespace
