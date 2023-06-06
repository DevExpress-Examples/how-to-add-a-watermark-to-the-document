Imports DevExpress.XtraEditors

Namespace RichEditWatermark
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.btnTextWatermark = New SimpleButton()
            Me.btnImageWatermark = New SimpleButton()
            Me.Form1layoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.button2item = New DevExpress.XtraLayout.LayoutControlItem()
            Me.button1item = New DevExpress.XtraLayout.LayoutControlItem()
            Me.richEditControl1item = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.Form1layoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Form1layoutControl1ConvertedLayout.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.button2item), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.button1item), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.richEditControl1item), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.richEditControl1.Anchor = (CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.richEditControl1.Location = New System.Drawing.Point(6, 6)
            Me.richEditControl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(926, 578)
            Me.richEditControl1.TabIndex = 0
            Me.btnTextWatermark.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.btnTextWatermark.Location = New System.Drawing.Point(6, 586)
            Me.btnTextWatermark.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.btnTextWatermark.Name = "btnTextWatermark"
            Me.btnTextWatermark.Size = New System.Drawing.Size(460, 29)
            Me.btnTextWatermark.TabIndex = 1
            Me.btnTextWatermark.Text = "Text watermark"
            Me.btnImageWatermark.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.btnImageWatermark.Location = New System.Drawing.Point(468, 586)
            Me.btnImageWatermark.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.btnImageWatermark.Name = "btnImageWatermark"
            Me.btnImageWatermark.Size = New System.Drawing.Size(464, 29)
            Me.btnImageWatermark.TabIndex = 2
            Me.btnImageWatermark.Text = "Image watermark"
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.btnImageWatermark)
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.btnTextWatermark)
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.richEditControl1)
            Me.Form1layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Form1layoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.Form1layoutControl1ConvertedLayout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Form1layoutControl1ConvertedLayout.Name = "Form1layoutControl1ConvertedLayout"
            Me.Form1layoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
            Me.Form1layoutControl1ConvertedLayout.Size = New System.Drawing.Size(938, 621)
            Me.Form1layoutControl1ConvertedLayout.TabIndex = 3
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.button2item, Me.button1item, Me.richEditControl1item})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(938, 621)
            Me.layoutControlGroup1.TextVisible = False
            Me.button2item.Control = Me.btnImageWatermark
            Me.button2item.Location = New System.Drawing.Point(462, 580)
            Me.button2item.Name = "button2item"
            Me.button2item.Size = New System.Drawing.Size(466, 31)
            Me.button2item.TextSize = New System.Drawing.Size(0, 0)
            Me.button2item.TextVisible = False
            Me.button1item.Control = Me.btnTextWatermark
            Me.button1item.Location = New System.Drawing.Point(0, 580)
            Me.button1item.Name = "button1item"
            Me.button1item.Size = New System.Drawing.Size(462, 31)
            Me.button1item.TextSize = New System.Drawing.Size(0, 0)
            Me.button1item.TextVisible = False
            Me.richEditControl1item.Control = Me.richEditControl1
            Me.richEditControl1item.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl1item.Name = "richEditControl1item"
            Me.richEditControl1item.Size = New System.Drawing.Size(928, 580)
            Me.richEditControl1item.TextSize = New System.Drawing.Size(0, 0)
            Me.richEditControl1item.TextVisible = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(938, 621)
            Me.Controls.Add(Me.Form1layoutControl1ConvertedLayout)
            Me.IconOptions.ShowIcon = False
            Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.Name = "Form1"
            Me.Text = "Rich Text Editor"
            CType((Me.Form1layoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.Form1layoutControl1ConvertedLayout.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.button2item), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.button1item), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.richEditControl1item), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private WithEvents btnTextWatermark As SimpleButton
        Private WithEvents btnImageWatermark As SimpleButton
        Private Form1layoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private button2item As DevExpress.XtraLayout.LayoutControlItem
        Private button1item As DevExpress.XtraLayout.LayoutControlItem
        Private richEditControl1item As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
