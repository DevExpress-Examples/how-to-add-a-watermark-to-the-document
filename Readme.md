<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [StringSample.cs](./CS/StringSample.cs) (VB: [StringSample.vb](./VB/StringSample.vb))
<!-- default file list end -->
# How to add a watermark with a text or image to the document


<p>This example illustrates how you can add a watermark to the document. The main idea is to add a corresponding <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument10941"><u>Floating Object</u></a> (TextBox or Picture) to the <a href="https://docs.devexpress.com/WindowsForms/8305/controls-and-libraries/rich-text-editor/richeditcontrol-document/document-elements/headers-and-footers">header section</a>. Take special note of the <a href="http://msdn.microsoft.com/en-us/library/y4xdbe66.aspx"><u>TextRenderer.MeasureText Method</u></a>, which is used to calculate the correct size of a textual watermark.</p><p><strong>See Also:</strong><br />
<a href="https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.ShapeCollection.InsertPicture.overloads"><u>ShapeCollection.InsertPicture method</u></a><br />
<a href="https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.ShapeCollection.InsertTextBox.overloads"><u>ShapeCollection.InsertTextBox method</u></a></p>

<br/>


