Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Office.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditWatermark
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()

            richEditControl1.Text = StringSample.SampleText
            richEditControl1.ActiveView.ZoomFactor = 0.5F
        End Sub

        Private Sub btnTextWatermark_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTextWatermark.Click
            Dim section As Section = richEditControl1.Document.Sections(0)
            Dim options As TextWatermarkOptions = New TextWatermarkOptions() With {
            .FontFamily = "Comic Sans MS",
            .FontSize = 32,
            .Color = Color.Red,
            .Layout = WatermarkLayout.Diagonal
        }
            richEditControl1.Document.WatermarkManager.SetText(section, HeaderFooterType.Primary, "DevExpress XtraRichEdit", options)
        End Sub

        Private Sub btnImageWatermark_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImageWatermark.Click
            ' Define image watermark options.
            Dim imageWatermarkOptions = New ImageWatermarkOptions With {
            .Washout = False
        }
            ' Add an image watermark to the first page header. 
            Dim firstSection = richEditControl1.Document.Sections(0)
            firstSection.DifferentFirstPage = True
            richEditControl1.Document.WatermarkManager.SetImage(firstSection, HeaderFooterType.First, Image.FromFile(System.IO.Directory.GetCurrentDirectory() & "\..\..\preview.png"), imageWatermarkOptions)
        End Sub
    End Class
End Namespace