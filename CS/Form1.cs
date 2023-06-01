using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Office.Utils;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace RichEditWatermark {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1() {
            InitializeComponent();

            richEditControl1.Text = StringSample.SampleText;
            richEditControl1.ActiveView.ZoomFactor = .5f;
        }

        private void button1_Click(object sender, EventArgs e) {
            Section section = richEditControl1.Document.Sections[0];
            TextWatermarkOptions options = new TextWatermarkOptions() 
            { 
                FontFamily = "Comic Sans MS", 
                FontSize = 32, 
                Color = Color.Red, 
                Layout = WatermarkLayout.Diagonal 
            };
            richEditControl1.Document.WatermarkManager.SetText(section, HeaderFooterType.Primary, "DevExpress XtraRichEdit", options);
        }

        private void button2_Click(object sender, EventArgs e) {

            // Define image watermark options.
            var imageWatermarkOptions = new ImageWatermarkOptions
            { Washout = false };

            var firstSection = richEditControl1.Document.Sections[0];

            // Add an image watermark to the first page header. 
            firstSection.DifferentFirstPage = true;
            richEditControl1.Document.WatermarkManager.SetImage(firstSection, HeaderFooterType.First,
                DocumentImageSource.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\..\..\preview.png"), imageWatermarkOptions);
        }
    }
}