Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Office.Utils
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditWatermark

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            richEditControl1.Text = SampleText
            richEditControl1.ActiveView.ZoomFactor = .5F
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            SetTextWatermark(richEditControl1, "DevExpress XtraRichEdit")
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Call SetImageWatermark(richEditControl1, Image.FromFile(IO.Directory.GetCurrentDirectory() & "\..\..\preview.png"))
        End Sub

        Public Shared Sub SetTextWatermark(ByVal richEditControl As RichEditControl, ByVal text As String)
            Dim section As Section = richEditControl.Document.Sections(0)
            Dim subDocument As SubDocument = section.BeginUpdateHeader()
            subDocument.Delete(subDocument.Range)
            Dim shape As Shape = subDocument.InsertTextBox(subDocument.Range.Start)
            shape.TextBox.Document.AppendText(text)
            Dim cp As CharacterProperties = shape.TextBox.Document.BeginUpdateCharacters(shape.TextBox.Document.Range)
            cp.FontName = "Comic Sans MS"
            cp.FontSize = 32
            cp.ForeColor = Color.Red
            Dim measureFont As Font = New Font(cp.FontName, cp.FontSize.Value)
            shape.TextBox.Document.EndUpdateCharacters(cp)
            shape.RotationAngle = -45
            Dim sizeInPixels As Size = TextRenderer.MeasureText(text, measureFont)
            shape.Size = New SizeF(Units.PixelsToDocumentsF(sizeInPixels.Width, richEditControl.DpiX), Units.PixelsToDocumentsF(sizeInPixels.Height, richEditControl.DpiY))
            shape.Offset = New PointF(section.Page.Width / 2 - shape.Size.Width / 2, section.Page.Height / 2 - shape.Size.Height / 2)
            section.EndUpdateHeader(subDocument)
        End Sub

        Public Shared Sub SetImageWatermark(ByVal richEditControl As RichEditControl, ByVal image As Image)
            Dim section As Section = richEditControl.Document.Sections(0)
            Dim subDocument As SubDocument = section.BeginUpdateHeader()
            subDocument.Delete(subDocument.Range)
            Dim shape As Shape = subDocument.InsertPicture(subDocument.Range.Start, image)
            shape.RotationAngle = -45
            shape.Offset = New PointF(section.Page.Width / 2 - shape.Size.Width / 2, section.Page.Height / 2 - shape.Size.Height / 2)
            section.EndUpdateHeader(subDocument)
        End Sub
    End Class
End Namespace
