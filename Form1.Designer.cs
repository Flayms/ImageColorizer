
namespace ImageColorizer {
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
      if (disposing && (components != null)) {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.pbImagePreview = new System.Windows.Forms.PictureBox();
      this.tbPath = new System.Windows.Forms.TextBox();
      this.lblImagePath = new System.Windows.Forms.Label();
      this.btnSelectImage = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.btnSelectColor = new System.Windows.Forms.Button();
      this.tbColorCode = new System.Windows.Forms.TextBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbImagePreview)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.pbImagePreview, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.tbPath, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.lblImagePath, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnSelectImage, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.btnSelectColor, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.tbColorCode, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 5);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 6;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 418);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // pbImagePreview
      // 
      this.pbImagePreview.BackColor = System.Drawing.SystemColors.ControlDark;
      this.pbImagePreview.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pbImagePreview.Location = new System.Drawing.Point(70, 58);
      this.pbImagePreview.Name = "pbImagePreview";
      this.pbImagePreview.Size = new System.Drawing.Size(527, 273);
      this.pbImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbImagePreview.TabIndex = 2;
      this.pbImagePreview.TabStop = false;
      // 
      // tbPath
      // 
      this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbPath.Location = new System.Drawing.Point(70, 32);
      this.tbPath.Name = "tbPath";
      this.tbPath.Size = new System.Drawing.Size(527, 20);
      this.tbPath.TabIndex = 1;
      this.tbPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPath_KeyUp);
      // 
      // lblImagePath
      // 
      this.lblImagePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblImagePath.AutoSize = true;
      this.lblImagePath.Location = new System.Drawing.Point(3, 35);
      this.lblImagePath.Name = "lblImagePath";
      this.lblImagePath.Size = new System.Drawing.Size(61, 13);
      this.lblImagePath.TabIndex = 0;
      this.lblImagePath.Text = "Image Path";
      // 
      // btnSelectImage
      // 
      this.btnSelectImage.AutoSize = true;
      this.btnSelectImage.Location = new System.Drawing.Point(70, 3);
      this.btnSelectImage.Name = "btnSelectImage";
      this.btnSelectImage.Size = new System.Drawing.Size(79, 23);
      this.btnSelectImage.TabIndex = 4;
      this.btnSelectImage.Text = "Select Image";
      this.btnSelectImage.UseVisualStyleBackColor = true;
      this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 369);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(56, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "ColorCode";
      // 
      // btnSelectColor
      // 
      this.btnSelectColor.Location = new System.Drawing.Point(70, 337);
      this.btnSelectColor.Name = "btnSelectColor";
      this.btnSelectColor.Size = new System.Drawing.Size(75, 23);
      this.btnSelectColor.TabIndex = 7;
      this.btnSelectColor.Text = "Select Color";
      this.btnSelectColor.UseVisualStyleBackColor = true;
      this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
      // 
      // tbColorCode
      // 
      this.tbColorCode.Location = new System.Drawing.Point(70, 366);
      this.tbColorCode.Name = "tbColorCode";
      this.tbColorCode.Size = new System.Drawing.Size(100, 20);
      this.tbColorCode.TabIndex = 8;
      this.tbColorCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbColorCode_KeyUp);
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSave.Location = new System.Drawing.Point(522, 392);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 9;
      this.btnSave.Text = "Save Image";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(600, 418);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "Image Colorizer";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbImagePreview)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.PictureBox pbImagePreview;
    private System.Windows.Forms.TextBox tbPath;
    private System.Windows.Forms.Label lblImagePath;
    private System.Windows.Forms.Button btnSelectImage;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnSelectColor;
    private System.Windows.Forms.TextBox tbColorCode;
    private System.Windows.Forms.Button btnSave;
  }
}

