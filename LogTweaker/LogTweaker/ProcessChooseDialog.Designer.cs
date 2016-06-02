namespace EtwMonitor
{
  partial class ProcessChooseDialog
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.selectButton = new System.Windows.Forms.Button();
      this.processList = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // selectButton
      // 
      this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.selectButton.Location = new System.Drawing.Point(317, 277);
      this.selectButton.Name = "selectButton";
      this.selectButton.Size = new System.Drawing.Size(75, 38);
      this.selectButton.TabIndex = 1;
      this.selectButton.Text = "OK";
      this.selectButton.UseVisualStyleBackColor = true;
      this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
      // 
      // processList
      // 
      this.processList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.processList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.processList.FormattingEnabled = true;
      this.processList.ItemHeight = 20;
      this.processList.Location = new System.Drawing.Point(12, 12);
      this.processList.Name = "processList";
      this.processList.Size = new System.Drawing.Size(380, 244);
      this.processList.TabIndex = 2;
      this.processList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProcessChooseDialog_MouseDoubleClick);
      // 
      // ProcessChooseDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(404, 327);
      this.Controls.Add(this.processList);
      this.Controls.Add(this.selectButton);
      this.Name = "ProcessChooseDialog";
      this.Text = "Choose Process";
      this.Load += new System.EventHandler(this.ProcessChooseDialog_Load);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button selectButton;
    private System.Windows.Forms.ListBox processList;
  }
}