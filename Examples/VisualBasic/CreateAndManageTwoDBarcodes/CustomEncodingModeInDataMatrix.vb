﻿Imports System.Drawing.Imaging
Imports System.Text
Imports Aspose.BarCode.Generation

'
' This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
' When the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
' Install it and then add its reference to this project. For any issues, questions or suggestions 
' Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class CustomEncodingModeInDataMatrix
        Public Shared Sub Run()
            'ExStart:CustomEncodingModeInDataMatrix
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            ' Instantiate barcode object and set CodeText & Barcode Symbology
            Dim barCodeBuilder As New BarCodeBuilder("Г¶Г¤ГјГ©Г ГЁ", EncodeTypes.DataMatrix)

            ' Set Data Matrix EncodeMode to Custom and  CodeText Encoding Property 
            barCodeBuilder.DataMatrixEncodeMode = DataMatrixEncodeMode.[Custom]
            barCodeBuilder.CodeTextEncoding = Encoding.UTF8
            barCodeBuilder.Save(dataDir & Convert.ToString("CustomEncodingModeInDataMatrix_out.bmp"), ImageFormat.Bmp)
            'ExEnd:CustomEncodingModeInDataMatrix
        End Sub
    End Class
End Namespace