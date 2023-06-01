namespace RichEditWatermark {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Form1layoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.button2item = new DevExpress.XtraLayout.LayoutControlItem();
            this.button1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.richEditControl1item = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.Form1layoutControl1ConvertedLayout)).BeginInit();
            this.Form1layoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button2item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditControl1item)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richEditControl1.Location = new System.Drawing.Point(12, 12);
            this.richEditControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(1852, 1111);
            this.richEditControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(12, 1127);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(920, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Text watermark";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(936, 1127);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(928, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Image watermark";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1layoutControl1ConvertedLayout
            // 
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.button2);
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.button1);
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.richEditControl1);
            this.Form1layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Form1layoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.Form1layoutControl1ConvertedLayout.Name = "Form1layoutControl1ConvertedLayout";
            this.Form1layoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.Form1layoutControl1ConvertedLayout.Size = new System.Drawing.Size(1876, 1194);
            this.Form1layoutControl1ConvertedLayout.TabIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.button2item,
            this.button1item,
            this.richEditControl1item});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1876, 1194);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // button2item
            // 
            this.button2item.Control = this.button2;
            this.button2item.Location = new System.Drawing.Point(924, 1115);
            this.button2item.Name = "button2item";
            this.button2item.Size = new System.Drawing.Size(932, 59);
            this.button2item.TextSize = new System.Drawing.Size(0, 0);
            this.button2item.TextVisible = false;
            // 
            // button1item
            // 
            this.button1item.Control = this.button1;
            this.button1item.Location = new System.Drawing.Point(0, 1115);
            this.button1item.Name = "button1item";
            this.button1item.Size = new System.Drawing.Size(924, 59);
            this.button1item.TextSize = new System.Drawing.Size(0, 0);
            this.button1item.TextVisible = false;
            // 
            // richEditControl1item
            // 
            this.richEditControl1item.Control = this.richEditControl1;
            this.richEditControl1item.Location = new System.Drawing.Point(0, 0);
            this.richEditControl1item.Name = "richEditControl1item";
            this.richEditControl1item.Size = new System.Drawing.Size(1856, 1115);
            this.richEditControl1item.TextSize = new System.Drawing.Size(0, 0);
            this.richEditControl1item.TextVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1876, 1194);
            this.Controls.Add(this.Form1layoutControl1ConvertedLayout);
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Rich Text Editor";
            ((System.ComponentModel.ISupportInitialize)(this.Form1layoutControl1ConvertedLayout)).EndInit();
            this.Form1layoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button2item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditControl1item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraLayout.LayoutControl Form1layoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem button2item;
        private DevExpress.XtraLayout.LayoutControlItem button1item;
        private DevExpress.XtraLayout.LayoutControlItem richEditControl1item;
    }
}

