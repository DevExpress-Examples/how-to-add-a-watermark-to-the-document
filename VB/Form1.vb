Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Office.Utils
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditWatermark
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            richEditControl1.Text = StringSample.SampleText
            richEditControl1.ActiveView.ZoomFactor =.5F
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            SetTextWatermark(richEditControl1, "DevExpress XtraRichEdit")
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
            SetImageWatermark(richEditControl1, Image.FromFile(System.IO.Directory.GetCurrentDirectory() & "\..\..\preview.png"))
        End Sub

        Public Shared Sub SetTextWatermark(ByVal richEditControl As RichEditControl, ByVal text As String)
            Dim section As Section = richEditControl.Document.Sections(0)
            Dim subDocument As SubDocument = section.BeginUpdateHeader()
            subDocument.Delete(subDocument.Range)
            Dim shape As Shape = subDocument.Shapes.InsertTextBox(subDocument.Range.Start)
            shape.ShapeFormat.TextBox.Document.AppendText(text)

            Dim cp As CharacterProperties = shape.ShapeFormat.TextBox.Document.BeginUpdateCharacters(shape.ShapeFormat.TextBox.Document.Range)
            cp.FontName = "Comic Sans MS"
            cp.FontSize = 32
            cp.ForeColor = Color.Red
            Dim measureFont As New Font(cp.FontName, cp.FontSize.Value)
            shape.ShapeFormat.TextBox.Document.EndUpdateCharacters(cp)

            shape.RotationAngle = -45
            Dim sizeInPixels As Size = TextRenderer.MeasureText(text, measureFont)
            shape.Size = New SizeF(Units.PixelsToDocumentsF(sizeInPixels.Width, richEditControl.DpiX), Units.PixelsToDocumentsF(sizeInPixels.Height, richEditControl.DpiY))
            shape.ShapeFormat.TextBox.HeightRule = TextBoxSizeRule.Auto
            shape.Offset = New PointF(CLng(section.Page.Width) \ 2 - CLng(shape.Size.Width) \ 2, CLng(section.Page.Height) \ 2 - CLng(shape.Size.Height) \ 2)
            section.EndUpdateHeader(subDocument)
        End Sub

        Public Shared Sub SetImageWatermark(ByVal richEditControl As RichEditControl, ByVal image As Image)
            Dim section As Section = richEditControl.Document.Sections(0)
            Dim subDocument As SubDocument = section.BeginUpdateHeader()
            subDocument.Delete(subDocument.Range)
            Dim shape As Shape = subDocument.Shapes.InsertPicture(subDocument.Range.Start, image)

            shape.RotationAngle = -45
            shape.Offset = New PointF(CLng(section.Page.Width) \ 2 - CLng(shape.Size.Width) \ 2, CLng(section.Page.Height) \ 2 - CLng(shape.Size.Height) \ 2)
            section.EndUpdateHeader(subDocument)
        End Sub
    End Class
End Namespace