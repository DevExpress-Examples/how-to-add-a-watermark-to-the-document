using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Office.Utils;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace RichEditWatermark {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            richEditControl1.Text = StringSample.SampleText;
            richEditControl1.ActiveView.ZoomFactor = .5f;
        }

        private void button1_Click(object sender, EventArgs e) {
            SetTextWatermark(richEditControl1, "DevExpress XtraRichEdit");
        }

        private void button2_Click(object sender, EventArgs e) {
            SetImageWatermark(richEditControl1, Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\..\..\preview.png"));
        }

        public static void SetTextWatermark(RichEditControl richEditControl, string text) {
            Section section = richEditControl.Document.Sections[0];
            SubDocument subDocument = section.BeginUpdateHeader();
            subDocument.Delete(subDocument.Range);
            Shape shape = subDocument.Shapes.InsertTextBox(subDocument.Range.Start);
            shape.TextBox.Document.AppendText(text);

            CharacterProperties cp = shape.TextBox.Document.BeginUpdateCharacters(shape.TextBox.Document.Range);
            cp.FontName = "Comic Sans MS";
            cp.FontSize = 32;
            cp.ForeColor = Color.Red;
            Font measureFont = new Font(cp.FontName, cp.FontSize.Value);
            shape.TextBox.Document.EndUpdateCharacters(cp);

            shape.RotationAngle = -45;
            Size sizeInPixels = TextRenderer.MeasureText(text, measureFont);
            shape.Size = new SizeF(Units.PixelsToDocumentsF(sizeInPixels.Width, richEditControl.DpiX), Units.PixelsToDocumentsF(sizeInPixels.Height, richEditControl.DpiY));
            shape.TextBox.HeightRule = TextBoxSizeRule.Auto;
            shape.Offset = new PointF(section.Page.Width / 2 - shape.Size.Width / 2, section.Page.Height / 2 - shape.Size.Height / 2);
            section.EndUpdateHeader(subDocument);
        }

        public static void SetImageWatermark(RichEditControl richEditControl, Image image) {
            Section section = richEditControl.Document.Sections[0];
            SubDocument subDocument = section.BeginUpdateHeader();
            subDocument.Delete(subDocument.Range);
            Shape shape = subDocument.Shapes.InsertPicture(subDocument.Range.Start, image);

            shape.RotationAngle = -45;
            shape.Offset = new PointF(section.Page.Width / 2 - shape.Size.Width / 2, section.Page.Height / 2 - shape.Size.Height / 2);
            section.EndUpdateHeader(subDocument);
        }
    }
}