namespace EtwMonitor
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.label1 = new System.Windows.Forms.Label();
      this.processNameTextBox = new System.Windows.Forms.TextBox();
      this.chooseProcessButton = new System.Windows.Forms.Button();
      this.exitButton = new System.Windows.Forms.Button();
      this.startStopButton = new System.Windows.Forms.Button();
      this.operationsGrid = new System.Windows.Forms.DataGridView();
      this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Calls = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SentBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ReceivedBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.resetButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.operationsGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(121, 31);
      this.label1.TabIndex = 0;
      this.label1.Text = "Process:";
      // 
      // processNameTextBox
      // 
      this.processNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.processNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.processNameTextBox.Location = new System.Drawing.Point(140, 10);
      this.processNameTextBox.Name = "processNameTextBox";
      this.processNameTextBox.ReadOnly = true;
      this.processNameTextBox.Size = new System.Drawing.Size(586, 38);
      this.processNameTextBox.TabIndex = 1;
      // 
      // chooseProcessButton
      // 
      this.chooseProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.chooseProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.chooseProcessButton.Location = new System.Drawing.Point(732, 10);
      this.chooseProcessButton.Name = "chooseProcessButton";
      this.chooseProcessButton.Size = new System.Drawing.Size(75, 38);
      this.chooseProcessButton.TabIndex = 2;
      this.chooseProcessButton.Text = "...";
      this.chooseProcessButton.UseVisualStyleBackColor = true;
      this.chooseProcessButton.Click += new System.EventHandler(this.chooseProcessButton_Click);
      // 
      // exitButton
      // 
      this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.exitButton.Location = new System.Drawing.Point(671, 365);
      this.exitButton.Name = "exitButton";
      this.exitButton.Size = new System.Drawing.Size(136, 41);
      this.exitButton.TabIndex = 4;
      this.exitButton.Text = "Close";
      this.exitButton.UseVisualStyleBackColor = true;
      this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
      // 
      // startStopButton
      // 
      this.startStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.startStopButton.Enabled = false;
      this.startStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.startStopButton.Location = new System.Drawing.Point(19, 365);
      this.startStopButton.Name = "startStopButton";
      this.startStopButton.Size = new System.Drawing.Size(115, 41);
      this.startStopButton.TabIndex = 5;
      this.startStopButton.Text = "Start";
      this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
      // 
      // operationsGrid
      // 
      this.operationsGrid.AllowUserToAddRows = false;
      this.operationsGrid.AllowUserToDeleteRows = false;
      this.operationsGrid.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.operationsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.operationsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.operationsGrid.BackgroundColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.operationsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.operationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.operationsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Operation,
            this.Calls,
            this.Duration,
            this.SentBytes,
            this.ReceivedBytes});
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.operationsGrid.DefaultCellStyle = dataGridViewCellStyle3;
      this.operationsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
      this.operationsGrid.Location = new System.Drawing.Point(19, 65);
      this.operationsGrid.Name = "operationsGrid";
      this.operationsGrid.ReadOnly = true;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.operationsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.operationsGrid.RowHeadersVisible = false;
      this.operationsGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.operationsGrid.RowTemplate.Height = 33;
      this.operationsGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.operationsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.operationsGrid.Size = new System.Drawing.Size(788, 294);
      this.operationsGrid.TabIndex = 0;
      // 
      // Operation
      // 
      this.Operation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.Operation.HeaderText = "Operation";
      this.Operation.Name = "Operation";
      this.Operation.ReadOnly = true;
      this.Operation.Width = 305;
      // 
      // Calls
      // 
      this.Calls.HeaderText = "Calls";
      this.Calls.Name = "Calls";
      this.Calls.ReadOnly = true;
      // 
      // Duration
      // 
      this.Duration.HeaderText = "Duration";
      this.Duration.Name = "Duration";
      this.Duration.ReadOnly = true;
      this.Duration.Width = 120;
      // 
      // SentBytes
      // 
      this.SentBytes.HeaderText = "Sent";
      this.SentBytes.Name = "SentBytes";
      this.SentBytes.ReadOnly = true;
      this.SentBytes.Width = 130;
      // 
      // ReceivedBytes
      // 
      this.ReceivedBytes.HeaderText = "Received";
      this.ReceivedBytes.Name = "ReceivedBytes";
      this.ReceivedBytes.ReadOnly = true;
      this.ReceivedBytes.Width = 130;
      // 
      // resetButton
      // 
      this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.resetButton.Location = new System.Drawing.Point(152, 365);
      this.resetButton.Name = "resetButton";
      this.resetButton.Size = new System.Drawing.Size(115, 41);
      this.resetButton.TabIndex = 6;
      this.resetButton.Text = "Reset";
      this.resetButton.UseVisualStyleBackColor = true;
      this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(819, 418);
      this.Controls.Add(this.resetButton);
      this.Controls.Add(this.operationsGrid);
      this.Controls.Add(this.startStopButton);
      this.Controls.Add(this.exitButton);
      this.Controls.Add(this.chooseProcessButton);
      this.Controls.Add(this.processNameTextBox);
      this.Controls.Add(this.label1);
      this.Name = "MainForm";
      this.Text = "WCF Monitor";
      ((System.ComponentModel.ISupportInitialize)(this.operationsGrid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox processNameTextBox;
    private System.Windows.Forms.Button chooseProcessButton;
    private System.Windows.Forms.Button exitButton;
    private System.Windows.Forms.Button startStopButton;
    private System.Windows.Forms.DataGridView operationsGrid;
    private System.Windows.Forms.Button resetButton;
    private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
    private System.Windows.Forms.DataGridViewTextBoxColumn Calls;
    private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
    private System.Windows.Forms.DataGridViewTextBoxColumn SentBytes;
    private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedBytes;
  }
}

