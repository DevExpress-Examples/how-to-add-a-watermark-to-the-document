Imports Microsoft.VisualBasic
Imports System
Namespace RichEditWatermark
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.richEditControl1.Location = New System.Drawing.Point(12, 12)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(1227, 703)
			Me.richEditControl1.TabIndex = 0
			' 
			' button1
			' 
			Me.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
			Me.button1.Location = New System.Drawing.Point(489, 721)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(133, 31)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Text watermark"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
			Me.button2.Location = New System.Drawing.Point(628, 721)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(133, 31)
			Me.button2.TabIndex = 2
			Me.button2.Text = "Image watermark"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1251, 764)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.richEditControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
	End Class
End Namespace
