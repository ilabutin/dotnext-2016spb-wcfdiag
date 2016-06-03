namespace WCFClient
{
  partial class MainForm
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
      this.getStateButton = new System.Windows.Forms.Button();
      this.stateTextBox = new System.Windows.Forms.TextBox();
      this.stoppedRadioButton = new System.Windows.Forms.RadioButton();
      this.setStateGroupBox = new System.Windows.Forms.GroupBox();
      this.setButton = new System.Windows.Forms.Button();
      this.runningRadioButton = new System.Windows.Forms.RadioButton();
      this.setStateGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // getStateButton
      // 
      this.getStateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.getStateButton.Location = new System.Drawing.Point(13, 34);
      this.getStateButton.Name = "getStateButton";
      this.getStateButton.Size = new System.Drawing.Size(145, 59);
      this.getStateButton.TabIndex = 0;
      this.getStateButton.Text = "Get state";
      this.getStateButton.UseVisualStyleBackColor = true;
      this.getStateButton.Click += new System.EventHandler(this.getStateButton_Click);
      // 
      // stateTextBox
      // 
      this.stateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.stateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.stateTextBox.Location = new System.Drawing.Point(13, 148);
      this.stateTextBox.Multiline = true;
      this.stateTextBox.Name = "stateTextBox";
      this.stateTextBox.ReadOnly = true;
      this.stateTextBox.Size = new System.Drawing.Size(502, 206);
      this.stateTextBox.TabIndex = 1;
      // 
      // stoppedRadioButton
      // 
      this.stoppedRadioButton.AutoSize = true;
      this.stoppedRadioButton.Location = new System.Drawing.Point(6, 19);
      this.stoppedRadioButton.Name = "stoppedRadioButton";
      this.stoppedRadioButton.Size = new System.Drawing.Size(133, 35);
      this.stoppedRadioButton.TabIndex = 2;
      this.stoppedRadioButton.TabStop = true;
      this.stoppedRadioButton.Text = "Stopped";
      this.stoppedRadioButton.UseVisualStyleBackColor = true;
      // 
      // setStateGroupBox
      // 
      this.setStateGroupBox.Controls.Add(this.setButton);
      this.setStateGroupBox.Controls.Add(this.runningRadioButton);
      this.setStateGroupBox.Controls.Add(this.stoppedRadioButton);
      this.setStateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.setStateGroupBox.Location = new System.Drawing.Point(164, 12);
      this.setStateGroupBox.Name = "setStateGroupBox";
      this.setStateGroupBox.Size = new System.Drawing.Size(351, 100);
      this.setStateGroupBox.TabIndex = 3;
      this.setStateGroupBox.TabStop = false;
      // 
      // setButton
      // 
      this.setButton.Location = new System.Drawing.Point(176, 22);
      this.setButton.Name = "setButton";
      this.setButton.Size = new System.Drawing.Size(160, 63);
      this.setButton.TabIndex = 4;
      this.setButton.Text = "Set state";
      this.setButton.UseVisualStyleBackColor = true;
      this.setButton.Click += new System.EventHandler(this.setButton_Click);
      // 
      // runningRadioButton
      // 
      this.runningRadioButton.AutoSize = true;
      this.runningRadioButton.Location = new System.Drawing.Point(6, 55);
      this.runningRadioButton.Name = "runningRadioButton";
      this.runningRadioButton.Size = new System.Drawing.Size(133, 35);
      this.runningRadioButton.TabIndex = 3;
      this.runningRadioButton.TabStop = true;
      this.runningRadioButton.Text = "Running";
      this.runningRadioButton.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(527, 366);
      this.Controls.Add(this.stateTextBox);
      this.Controls.Add(this.getStateButton);
      this.Controls.Add(this.setStateGroupBox);
      this.Name = "MainForm";
      this.Text = "WCF Client";
      this.setStateGroupBox.ResumeLayout(false);
      this.setStateGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button getStateButton;
    private System.Windows.Forms.TextBox stateTextBox;
    private System.Windows.Forms.RadioButton stoppedRadioButton;
    private System.Windows.Forms.GroupBox setStateGroupBox;
    private System.Windows.Forms.Button setButton;
    private System.Windows.Forms.RadioButton runningRadioButton;
  }
}

