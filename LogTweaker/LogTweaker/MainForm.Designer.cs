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
      this.appDomainsGrid = new System.Windows.Forms.DataGridView();
      this.AppDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MsgAtServiceLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.LogLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ActivityTracing = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.appDomainConfigurationGroupBox = new System.Windows.Forms.GroupBox();
      this.applyButton = new System.Windows.Forms.Button();
      this.activityTracingCheckbox = new System.Windows.Forms.CheckBox();
      this.serviceModelTraceLevel = new System.Windows.Forms.ComboBox();
      this.logLevelLabel = new System.Windows.Forms.Label();
      this.logMessagesAtServiceLevelBox = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.appDomainsGrid)).BeginInit();
      this.appDomainConfigurationGroupBox.SuspendLayout();
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
      this.processNameTextBox.Size = new System.Drawing.Size(541, 38);
      this.processNameTextBox.TabIndex = 1;
      // 
      // chooseProcessButton
      // 
      this.chooseProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.chooseProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.chooseProcessButton.Location = new System.Drawing.Point(687, 10);
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
      this.exitButton.Location = new System.Drawing.Point(626, 465);
      this.exitButton.Name = "exitButton";
      this.exitButton.Size = new System.Drawing.Size(136, 41);
      this.exitButton.TabIndex = 4;
      this.exitButton.Text = "Close";
      this.exitButton.UseVisualStyleBackColor = true;
      this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
      // 
      // appDomainsGrid
      // 
      this.appDomainsGrid.AllowUserToAddRows = false;
      this.appDomainsGrid.AllowUserToDeleteRows = false;
      this.appDomainsGrid.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.appDomainsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.appDomainsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.appDomainsGrid.BackgroundColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.appDomainsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.appDomainsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.appDomainsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppDomain,
            this.MsgAtServiceLevel,
            this.LogLevel,
            this.ActivityTracing});
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.appDomainsGrid.DefaultCellStyle = dataGridViewCellStyle3;
      this.appDomainsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
      this.appDomainsGrid.Location = new System.Drawing.Point(19, 65);
      this.appDomainsGrid.Name = "appDomainsGrid";
      this.appDomainsGrid.ReadOnly = true;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.appDomainsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.appDomainsGrid.RowHeadersVisible = false;
      this.appDomainsGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.appDomainsGrid.RowTemplate.Height = 33;
      this.appDomainsGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.appDomainsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.appDomainsGrid.Size = new System.Drawing.Size(743, 323);
      this.appDomainsGrid.TabIndex = 0;
      this.appDomainsGrid.SelectionChanged += new System.EventHandler(this.appDomainsGrid_SelectionChanged);
      // 
      // AppDomain
      // 
      this.AppDomain.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.AppDomain.HeaderText = "AppDomain";
      this.AppDomain.Name = "AppDomain";
      this.AppDomain.ReadOnly = true;
      this.AppDomain.Width = 200;
      // 
      // MsgAtServiceLevel
      // 
      this.MsgAtServiceLevel.HeaderText = "Msg @ Service Level";
      this.MsgAtServiceLevel.Name = "MsgAtServiceLevel";
      this.MsgAtServiceLevel.ReadOnly = true;
      this.MsgAtServiceLevel.Width = 170;
      // 
      // LogLevel
      // 
      this.LogLevel.HeaderText = "Log Level";
      this.LogLevel.Name = "LogLevel";
      this.LogLevel.ReadOnly = true;
      this.LogLevel.Width = 200;
      // 
      // ActivityTracing
      // 
      this.ActivityTracing.HeaderText = "Activity Tracing";
      this.ActivityTracing.Name = "ActivityTracing";
      this.ActivityTracing.ReadOnly = true;
      this.ActivityTracing.Width = 170;
      // 
      // appDomainConfigurationGroupBox
      // 
      this.appDomainConfigurationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.appDomainConfigurationGroupBox.Controls.Add(this.applyButton);
      this.appDomainConfigurationGroupBox.Controls.Add(this.activityTracingCheckbox);
      this.appDomainConfigurationGroupBox.Controls.Add(this.serviceModelTraceLevel);
      this.appDomainConfigurationGroupBox.Controls.Add(this.logLevelLabel);
      this.appDomainConfigurationGroupBox.Controls.Add(this.logMessagesAtServiceLevelBox);
      this.appDomainConfigurationGroupBox.Enabled = false;
      this.appDomainConfigurationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.appDomainConfigurationGroupBox.Location = new System.Drawing.Point(19, 394);
      this.appDomainConfigurationGroupBox.Name = "appDomainConfigurationGroupBox";
      this.appDomainConfigurationGroupBox.Size = new System.Drawing.Size(582, 112);
      this.appDomainConfigurationGroupBox.TabIndex = 2;
      this.appDomainConfigurationGroupBox.TabStop = false;
      this.appDomainConfigurationGroupBox.Text = "AppDomain configuration";
      // 
      // applyButton
      // 
      this.applyButton.Location = new System.Drawing.Point(486, 71);
      this.applyButton.Name = "applyButton";
      this.applyButton.Size = new System.Drawing.Size(80, 35);
      this.applyButton.TabIndex = 4;
      this.applyButton.Text = "Apply";
      this.applyButton.UseVisualStyleBackColor = true;
      this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
      // 
      // activityTracingCheckbox
      // 
      this.activityTracingCheckbox.AutoSize = true;
      this.activityTracingCheckbox.Location = new System.Drawing.Point(286, 66);
      this.activityTracingCheckbox.Name = "activityTracingCheckbox";
      this.activityTracingCheckbox.Size = new System.Drawing.Size(147, 28);
      this.activityTracingCheckbox.TabIndex = 3;
      this.activityTracingCheckbox.Text = "Activity tracing";
      this.activityTracingCheckbox.UseVisualStyleBackColor = true;
      // 
      // serviceModelTraceLevel
      // 
      this.serviceModelTraceLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.serviceModelTraceLevel.FormattingEnabled = true;
      this.serviceModelTraceLevel.Location = new System.Drawing.Point(121, 33);
      this.serviceModelTraceLevel.Name = "serviceModelTraceLevel";
      this.serviceModelTraceLevel.Size = new System.Drawing.Size(159, 32);
      this.serviceModelTraceLevel.TabIndex = 2;
      // 
      // logLevelLabel
      // 
      this.logLevelLabel.AutoSize = true;
      this.logLevelLabel.Location = new System.Drawing.Point(7, 36);
      this.logLevelLabel.Name = "logLevelLabel";
      this.logLevelLabel.Size = new System.Drawing.Size(108, 24);
      this.logLevelLabel.TabIndex = 1;
      this.logLevelLabel.Text = "Trace level:";
      // 
      // logMessagesAtServiceLevelBox
      // 
      this.logMessagesAtServiceLevelBox.AutoSize = true;
      this.logMessagesAtServiceLevelBox.Location = new System.Drawing.Point(286, 32);
      this.logMessagesAtServiceLevelBox.Name = "logMessagesAtServiceLevelBox";
      this.logMessagesAtServiceLevelBox.Size = new System.Drawing.Size(280, 28);
      this.logMessagesAtServiceLevelBox.TabIndex = 0;
      this.logMessagesAtServiceLevelBox.Text = "Log messages at service level";
      this.logMessagesAtServiceLevelBox.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(774, 518);
      this.Controls.Add(this.exitButton);
      this.Controls.Add(this.chooseProcessButton);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.appDomainConfigurationGroupBox);
      this.Controls.Add(this.processNameTextBox);
      this.Controls.Add(this.appDomainsGrid);
      this.Name = "MainForm";
      this.Text = "Log Tweaker";
      ((System.ComponentModel.ISupportInitialize)(this.appDomainsGrid)).EndInit();
      this.appDomainConfigurationGroupBox.ResumeLayout(false);
      this.appDomainConfigurationGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox processNameTextBox;
    private System.Windows.Forms.Button chooseProcessButton;
    private System.Windows.Forms.Button exitButton;
    private System.Windows.Forms.DataGridView appDomainsGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn AppDomain;
    private System.Windows.Forms.DataGridViewTextBoxColumn MsgAtServiceLevel;
    private System.Windows.Forms.DataGridViewTextBoxColumn LogLevel;
    private System.Windows.Forms.DataGridViewTextBoxColumn ActivityTracing;
    private System.Windows.Forms.GroupBox appDomainConfigurationGroupBox;
    private System.Windows.Forms.Button applyButton;
    private System.Windows.Forms.CheckBox activityTracingCheckbox;
    private System.Windows.Forms.ComboBox serviceModelTraceLevel;
    private System.Windows.Forms.Label logLevelLabel;
    private System.Windows.Forms.CheckBox logMessagesAtServiceLevelBox;
  }
}

