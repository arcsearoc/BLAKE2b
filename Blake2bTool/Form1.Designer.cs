namespace Blake2bTool;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.lblInputSource = new System.Windows.Forms.Label();
        this.rbText = new System.Windows.Forms.RadioButton();
        this.rbFile = new System.Windows.Forms.RadioButton();
        this.txtInput = new System.Windows.Forms.TextBox();
        this.txtFile = new System.Windows.Forms.TextBox();
        this.btnBrowse = new System.Windows.Forms.Button();
        this.lblKey = new System.Windows.Forms.Label();
        this.txtKey = new System.Windows.Forms.TextBox();
        this.lblDigest = new System.Windows.Forms.Label();
        this.numDigest = new System.Windows.Forms.NumericUpDown();
        this.lblOutputFmt = new System.Windows.Forms.Label();
        this.cmbOutputFmt = new System.Windows.Forms.ComboBox();
        this.chkUppercase = new System.Windows.Forms.CheckBox();
        this.lblAlgo = new System.Windows.Forms.Label();
        this.cmbAlgo = new System.Windows.Forms.ComboBox();
        this.btnCompute = new System.Windows.Forms.Button();
        this.txtOutput = new System.Windows.Forms.TextBox();
        this.btnCopy = new System.Windows.Forms.Button();
        this.lblCreation = new System.Windows.Forms.Label();
        this.dtCreation = new System.Windows.Forms.DateTimePicker();
        this.lblWrite = new System.Windows.Forms.Label();
        this.dtWrite = new System.Windows.Forms.DateTimePicker();
        this.lblAccess = new System.Windows.Forms.Label();
        this.dtAccess = new System.Windows.Forms.DateTimePicker();
        this.btnReadTimes = new System.Windows.Forms.Button();
        this.btnApplyTimes = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.numDigest)).BeginInit();
        this.SuspendLayout();
        // 
        // lblInputSource
        // 
        this.lblInputSource.AutoSize = true;
        this.lblInputSource.Location = new System.Drawing.Point(12, 15);
        this.lblInputSource.Name = "lblInputSource";
        this.lblInputSource.Size = new System.Drawing.Size(56, 17);
        this.lblInputSource.TabIndex = 0;
        this.lblInputSource.Text = "输入源";
        // 
        // rbText
        // 
        this.rbText.AutoSize = true;
        this.rbText.Location = new System.Drawing.Point(90, 13);
        this.rbText.Name = "rbText";
        this.rbText.Size = new System.Drawing.Size(50, 21);
        this.rbText.TabIndex = 1;
        this.rbText.TabStop = true;
        this.rbText.Text = "文本";
        this.rbText.UseVisualStyleBackColor = true;
        this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
        // 
        // rbFile
        // 
        this.rbFile.AutoSize = true;
        this.rbFile.Location = new System.Drawing.Point(160, 13);
        this.rbFile.Name = "rbFile";
        this.rbFile.Size = new System.Drawing.Size(50, 21);
        this.rbFile.TabIndex = 2;
        this.rbFile.Text = "文件";
        this.rbFile.UseVisualStyleBackColor = true;
        this.rbFile.CheckedChanged += new System.EventHandler(this.rbFile_CheckedChanged);
        // 
        // txtInput
        // 
        this.txtInput.Location = new System.Drawing.Point(12, 45);
        this.txtInput.Multiline = true;
        this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtInput.Name = "txtInput";
        this.txtInput.Size = new System.Drawing.Size(620, 100);
        this.txtInput.TabIndex = 3;
        // 
        // txtFile
        // 
        this.txtFile.AllowDrop = true;
        this.txtFile.Location = new System.Drawing.Point(12, 45);
        this.txtFile.Name = "txtFile";
        this.txtFile.Size = new System.Drawing.Size(540, 23);
        this.txtFile.TabIndex = 4;
        // 
        // btnBrowse
        // 
        this.btnBrowse.Location = new System.Drawing.Point(560, 45);
        this.btnBrowse.Name = "btnBrowse";
        this.btnBrowse.Size = new System.Drawing.Size(72, 23);
        this.btnBrowse.TabIndex = 5;
        this.btnBrowse.Text = "浏览...";
        this.btnBrowse.UseVisualStyleBackColor = true;
        this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
        // 
        // lblKey
        // 
        this.lblKey.AutoSize = true;
        this.lblKey.Location = new System.Drawing.Point(12, 160);
        this.lblKey.Name = "lblKey";
        this.lblKey.Size = new System.Drawing.Size(80, 17);
        this.lblKey.TabIndex = 6;
        this.lblKey.Text = "密钥(可选)";
        // 
        // txtKey
        // 
        this.txtKey.Location = new System.Drawing.Point(100, 157);
        this.txtKey.Name = "txtKey";
        this.txtKey.Size = new System.Drawing.Size(320, 23);
        this.txtKey.TabIndex = 7;
        // 
        // lblDigest
        // 
        this.lblDigest.AutoSize = true;
        this.lblDigest.Location = new System.Drawing.Point(440, 160);
        this.lblDigest.Name = "lblDigest";
        this.lblDigest.Size = new System.Drawing.Size(92, 17);
        this.lblDigest.TabIndex = 8;
        this.lblDigest.Text = "输出字节长度";
        // 
        // numDigest
        // 
        this.numDigest.Location = new System.Drawing.Point(540, 158);
        this.numDigest.Minimum = 1;
        this.numDigest.Maximum = 64;
        this.numDigest.Name = "numDigest";
        this.numDigest.Size = new System.Drawing.Size(92, 23);
        this.numDigest.TabIndex = 9;
        this.numDigest.Value = 64;
        // 
        // lblOutputFmt
        // 
        this.lblOutputFmt.AutoSize = true;
        this.lblOutputFmt.Location = new System.Drawing.Point(12, 195);
        this.lblOutputFmt.Name = "lblOutputFmt";
        this.lblOutputFmt.Size = new System.Drawing.Size(68, 17);
        this.lblOutputFmt.TabIndex = 10;
        this.lblOutputFmt.Text = "输出格式";
        // 
        // cmbOutputFmt
        // 
        this.cmbOutputFmt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbOutputFmt.Items.AddRange(new object[] {
            "Hex",
            "Base64"});
        this.cmbOutputFmt.Location = new System.Drawing.Point(90, 192);
        this.cmbOutputFmt.Name = "cmbOutputFmt";
        this.cmbOutputFmt.Size = new System.Drawing.Size(120, 25);
        this.cmbOutputFmt.TabIndex = 11;
        this.cmbOutputFmt.SelectedIndex = 0;
        // 
        // chkUppercase
        // 
        this.chkUppercase.AutoSize = true;
        this.chkUppercase.Location = new System.Drawing.Point(230, 195);
        this.chkUppercase.Name = "chkUppercase";
        this.chkUppercase.Size = new System.Drawing.Size(82, 21);
        this.chkUppercase.TabIndex = 12;
        this.chkUppercase.Text = "HEX大写";
        this.chkUppercase.Checked = true;
        this.chkUppercase.UseVisualStyleBackColor = true;
        // 
        // lblAlgo
        // 
        this.lblAlgo.AutoSize = true;
        this.lblAlgo.Location = new System.Drawing.Point(330, 195);
        this.lblAlgo.Name = "lblAlgo";
        this.lblAlgo.Size = new System.Drawing.Size(32, 17);
        this.lblAlgo.TabIndex = 12;
        this.lblAlgo.Text = "算法";
        // 
        // cmbAlgo
        // 
        this.cmbAlgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbAlgo.Items.AddRange(new object[] {
            "BLAKE2b",
            "MD5",
            "SHA-1",
            "SHA-256",
            "SHA-512"});
        this.cmbAlgo.Location = new System.Drawing.Point(370, 192);
        this.cmbAlgo.Name = "cmbAlgo";
        this.cmbAlgo.Size = new System.Drawing.Size(140, 25);
        this.cmbAlgo.TabIndex = 13;
        this.cmbAlgo.SelectedIndex = 0;
        this.cmbAlgo.SelectedIndexChanged += new System.EventHandler(this.cmbAlgo_SelectedIndexChanged);
        // 
        // btnCompute
        // 
        this.btnCompute.Location = new System.Drawing.Point(12, 230);
        this.btnCompute.Name = "btnCompute";
        this.btnCompute.Size = new System.Drawing.Size(120, 30);
        this.btnCompute.TabIndex = 14;
        this.btnCompute.Text = "计算";
        this.btnCompute.UseVisualStyleBackColor = true;
        this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
        // 
        // txtOutput
        // 
        this.txtOutput.Location = new System.Drawing.Point(12, 270);
        this.txtOutput.Multiline = true;
        this.txtOutput.ReadOnly = true;
        this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtOutput.Name = "txtOutput";
        this.txtOutput.Size = new System.Drawing.Size(620, 100);
        this.txtOutput.TabIndex = 15;
        // 
        // btnCopy
        // 
        this.btnCopy.Location = new System.Drawing.Point(540, 230);
        this.btnCopy.Name = "btnCopy";
        this.btnCopy.Size = new System.Drawing.Size(92, 30);
        this.btnCopy.TabIndex = 16;
        this.btnCopy.Text = "复制";
        this.btnCopy.UseVisualStyleBackColor = true;
        this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
        // 
        // lblCreation
        // 
        this.lblCreation.AutoSize = true;
        this.lblCreation.Location = new System.Drawing.Point(12, 380);
        this.lblCreation.Name = "lblCreation";
        this.lblCreation.Size = new System.Drawing.Size(32, 17);
        this.lblCreation.TabIndex = 17;
        this.lblCreation.Text = "创建";
        // 
        // dtCreation
        // 
        this.dtCreation.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        this.dtCreation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtCreation.Location = new System.Drawing.Point(60, 377);
        this.dtCreation.Name = "dtCreation";
        this.dtCreation.Size = new System.Drawing.Size(220, 23);
        this.dtCreation.TabIndex = 18;
        // 
        // lblWrite
        // 
        this.lblWrite.AutoSize = true;
        this.lblWrite.Location = new System.Drawing.Point(300, 380);
        this.lblWrite.Name = "lblWrite";
        this.lblWrite.Size = new System.Drawing.Size(32, 17);
        this.lblWrite.TabIndex = 19;
        this.lblWrite.Text = "修改";
        // 
        // dtWrite
        // 
        this.dtWrite.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        this.dtWrite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtWrite.Location = new System.Drawing.Point(340, 377);
        this.dtWrite.Name = "dtWrite";
        this.dtWrite.Size = new System.Drawing.Size(220, 23);
        this.dtWrite.TabIndex = 20;
        // 
        // lblAccess
        // 
        this.lblAccess.AutoSize = true;
        this.lblAccess.Location = new System.Drawing.Point(12, 415);
        this.lblAccess.Name = "lblAccess";
        this.lblAccess.Size = new System.Drawing.Size(32, 17);
        this.lblAccess.TabIndex = 21;
        this.lblAccess.Text = "访问";
        // 
        // dtAccess
        // 
        this.dtAccess.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        this.dtAccess.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtAccess.Location = new System.Drawing.Point(60, 412);
        this.dtAccess.Name = "dtAccess";
        this.dtAccess.Size = new System.Drawing.Size(220, 23);
        this.dtAccess.TabIndex = 22;
        // 
        // btnReadTimes
        // 
        this.btnReadTimes.Location = new System.Drawing.Point(300, 410);
        this.btnReadTimes.Name = "btnReadTimes";
        this.btnReadTimes.Size = new System.Drawing.Size(120, 27);
        this.btnReadTimes.TabIndex = 23;
        this.btnReadTimes.Text = "读取文件时间";
        this.btnReadTimes.UseVisualStyleBackColor = true;
        this.btnReadTimes.Click += new System.EventHandler(this.btnReadTimes_Click);
        // 
        // btnApplyTimes
        // 
        this.btnApplyTimes.Location = new System.Drawing.Point(440, 410);
        this.btnApplyTimes.Name = "btnApplyTimes";
        this.btnApplyTimes.Size = new System.Drawing.Size(120, 27);
        this.btnApplyTimes.TabIndex = 24;
        this.btnApplyTimes.Text = "应用文件时间";
        this.btnApplyTimes.UseVisualStyleBackColor = true;
        this.btnApplyTimes.Click += new System.EventHandler(this.btnApplyTimes_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(650, 450);
        this.Controls.Add(this.cmbAlgo);
        this.Controls.Add(this.lblAlgo);
        this.Controls.Add(this.btnCopy);
        this.Controls.Add(this.txtOutput);
        this.Controls.Add(this.btnCompute);
        this.Controls.Add(this.btnApplyTimes);
        this.Controls.Add(this.btnReadTimes);
        this.Controls.Add(this.dtAccess);
        this.Controls.Add(this.lblAccess);
        this.Controls.Add(this.dtWrite);
        this.Controls.Add(this.lblWrite);
        this.Controls.Add(this.dtCreation);
        this.Controls.Add(this.lblCreation);
        this.Controls.Add(this.chkUppercase);
        this.Controls.Add(this.cmbOutputFmt);
        this.Controls.Add(this.lblOutputFmt);
        this.Controls.Add(this.numDigest);
        this.Controls.Add(this.lblDigest);
        this.Controls.Add(this.txtKey);
        this.Controls.Add(this.lblKey);
        this.Controls.Add(this.btnBrowse);
        this.Controls.Add(this.txtFile);
        this.Controls.Add(this.txtInput);
        this.Controls.Add(this.rbFile);
        this.Controls.Add(this.rbText);
        this.Controls.Add(this.lblInputSource);
        this.Name = "Form1";
        this.Text = "BLAKE2b 小工具";
        this.AllowDrop = true;
        this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
        this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
        ((System.ComponentModel.ISupportInitialize)(this.numDigest)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    private System.Windows.Forms.Label lblInputSource;
    private System.Windows.Forms.RadioButton rbText;
    private System.Windows.Forms.RadioButton rbFile;
    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.TextBox txtFile;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.Label lblKey;
    private System.Windows.Forms.TextBox txtKey;
    private System.Windows.Forms.Label lblDigest;
    private System.Windows.Forms.NumericUpDown numDigest;
    private System.Windows.Forms.Label lblOutputFmt;
    private System.Windows.Forms.ComboBox cmbOutputFmt;
    private System.Windows.Forms.CheckBox chkUppercase;
    private System.Windows.Forms.Label lblAlgo;
    private System.Windows.Forms.ComboBox cmbAlgo;
    private System.Windows.Forms.Button btnCompute;
    private System.Windows.Forms.TextBox txtOutput;
    private System.Windows.Forms.Button btnCopy;
    private System.Windows.Forms.Label lblCreation;
    private System.Windows.Forms.DateTimePicker dtCreation;
    private System.Windows.Forms.Label lblWrite;
    private System.Windows.Forms.DateTimePicker dtWrite;
    private System.Windows.Forms.Label lblAccess;
    private System.Windows.Forms.DateTimePicker dtAccess;
    private System.Windows.Forms.Button btnReadTimes;
    private System.Windows.Forms.Button btnApplyTimes;
}
