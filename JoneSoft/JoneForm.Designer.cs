namespace JoneSoft  
{
    partial class JoneForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoneForm));
            this.JoneTabControl = new System.Windows.Forms.TabControl();
            this.SerialTabPage = new System.Windows.Forms.TabPage();
            this.serialStatusStrip = new System.Windows.Forms.StatusStrip();
            this.portStatusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.receiveSetGroupBox = new System.Windows.Forms.GroupBox();
            this.receiveHexCheckBox = new System.Windows.Forms.CheckBox();
            this.clearReceiveButton = new System.Windows.Forms.Button();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.viewDataButton = new System.Windows.Forms.Button();
            this.sendSetGroupBox = new System.Windows.Forms.GroupBox();
            this.sendHexCheckBox = new System.Windows.Forms.CheckBox();
            this.multiSendButton = new System.Windows.Forms.Button();
            this.clearSendButton = new System.Windows.Forms.Button();
            this.sendDataButton = new System.Windows.Forms.Button();
            this.sendGroupBox = new System.Windows.Forms.GroupBox();
            this.sendRichTextBox = new System.Windows.Forms.RichTextBox();
            this.portGroupBox = new System.Windows.Forms.GroupBox();
            this.statusPortLabel = new System.Windows.Forms.Label();
            this.stopBitLabel = new System.Windows.Forms.Label();
            this.stopBitComboBox = new System.Windows.Forms.ComboBox();
            this.parityBitLabel = new System.Windows.Forms.Label();
            this.parityBitComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitLabel = new System.Windows.Forms.Label();
            this.dataBitComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.receiveGroupBox = new System.Windows.Forms.GroupBox();
            this.receiveRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.portPictureBox = new System.Windows.Forms.PictureBox();
            this.JoneTabControl.SuspendLayout();
            this.SerialTabPage.SuspendLayout();
            this.serialStatusStrip.SuspendLayout();
            this.receiveSetGroupBox.SuspendLayout();
            this.sendSetGroupBox.SuspendLayout();
            this.sendGroupBox.SuspendLayout();
            this.portGroupBox.SuspendLayout();
            this.receiveGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // JoneTabControl
            // 
            this.JoneTabControl.Controls.Add(this.SerialTabPage);
            this.JoneTabControl.Controls.Add(this.tabPage2);
            this.JoneTabControl.Controls.Add(this.tabPage3);
            this.JoneTabControl.Location = new System.Drawing.Point(12, 12);
            this.JoneTabControl.Name = "JoneTabControl";
            this.JoneTabControl.SelectedIndex = 0;
            this.JoneTabControl.Size = new System.Drawing.Size(1405, 860);
            this.JoneTabControl.TabIndex = 0;
            // 
            // SerialTabPage
            // 
            this.SerialTabPage.BackColor = System.Drawing.Color.White;
            this.SerialTabPage.Controls.Add(this.serialStatusStrip);
            this.SerialTabPage.Controls.Add(this.receiveSetGroupBox);
            this.SerialTabPage.Controls.Add(this.sendSetGroupBox);
            this.SerialTabPage.Controls.Add(this.sendGroupBox);
            this.SerialTabPage.Controls.Add(this.portGroupBox);
            this.SerialTabPage.Controls.Add(this.receiveGroupBox);
            this.SerialTabPage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SerialTabPage.ForeColor = System.Drawing.Color.Black;
            this.SerialTabPage.Location = new System.Drawing.Point(8, 39);
            this.SerialTabPage.Name = "SerialTabPage";
            this.SerialTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SerialTabPage.Size = new System.Drawing.Size(1389, 813);
            this.SerialTabPage.TabIndex = 0;
            this.SerialTabPage.Text = "串口通信";
            // 
            // serialStatusStrip
            // 
            this.serialStatusStrip.BackColor = System.Drawing.Color.Transparent;
            this.serialStatusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.serialStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portStatusToolStripStatusLabel});
            this.serialStatusStrip.Location = new System.Drawing.Point(3, 781);
            this.serialStatusStrip.Name = "serialStatusStrip";
            this.serialStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.serialStatusStrip.Size = new System.Drawing.Size(1383, 29);
            this.serialStatusStrip.TabIndex = 10;
            // 
            // portStatusToolStripStatusLabel
            // 
            this.portStatusToolStripStatusLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.portStatusToolStripStatusLabel.Name = "portStatusToolStripStatusLabel";
            this.portStatusToolStripStatusLabel.Size = new System.Drawing.Size(178, 24);
            this.portStatusToolStripStatusLabel.Text = "串口状态：关闭";
            // 
            // receiveSetGroupBox
            // 
            this.receiveSetGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receiveSetGroupBox.Controls.Add(this.receiveHexCheckBox);
            this.receiveSetGroupBox.Controls.Add(this.clearReceiveButton);
            this.receiveSetGroupBox.Controls.Add(this.saveDataButton);
            this.receiveSetGroupBox.Controls.Add(this.viewDataButton);
            this.receiveSetGroupBox.Location = new System.Drawing.Point(310, 572);
            this.receiveSetGroupBox.Name = "receiveSetGroupBox";
            this.receiveSetGroupBox.Size = new System.Drawing.Size(292, 175);
            this.receiveSetGroupBox.TabIndex = 11;
            this.receiveSetGroupBox.TabStop = false;
            this.receiveSetGroupBox.Text = "接收设置";
            // 
            // receiveHexCheckBox
            // 
            this.receiveHexCheckBox.AutoSize = true;
            this.receiveHexCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.receiveHexCheckBox.Location = new System.Drawing.Point(8, 43);
            this.receiveHexCheckBox.Name = "receiveHexCheckBox";
            this.receiveHexCheckBox.Size = new System.Drawing.Size(122, 28);
            this.receiveHexCheckBox.TabIndex = 5;
            this.receiveHexCheckBox.Text = "HEX显示";
            this.receiveHexCheckBox.UseVisualStyleBackColor = true;
            // 
            // clearReceiveButton
            // 
            this.clearReceiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearReceiveButton.Location = new System.Drawing.Point(6, 113);
            this.clearReceiveButton.Name = "clearReceiveButton";
            this.clearReceiveButton.Size = new System.Drawing.Size(128, 40);
            this.clearReceiveButton.TabIndex = 4;
            this.clearReceiveButton.Text = "清接收区";
            this.clearReceiveButton.UseVisualStyleBackColor = true;
            this.clearReceiveButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearReceiveButton_MouseClick);
            // 
            // saveDataButton
            // 
            this.saveDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveDataButton.Location = new System.Drawing.Point(158, 35);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(128, 40);
            this.saveDataButton.TabIndex = 3;
            this.saveDataButton.Text = "保存数据";
            this.saveDataButton.UseVisualStyleBackColor = true;
            // 
            // viewDataButton
            // 
            this.viewDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewDataButton.Location = new System.Drawing.Point(157, 113);
            this.viewDataButton.Name = "viewDataButton";
            this.viewDataButton.Size = new System.Drawing.Size(128, 40);
            this.viewDataButton.TabIndex = 0;
            this.viewDataButton.Text = "查看数据";
            this.viewDataButton.UseVisualStyleBackColor = true;
            // 
            // sendSetGroupBox
            // 
            this.sendSetGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sendSetGroupBox.Controls.Add(this.sendHexCheckBox);
            this.sendSetGroupBox.Controls.Add(this.multiSendButton);
            this.sendSetGroupBox.Controls.Add(this.clearSendButton);
            this.sendSetGroupBox.Controls.Add(this.sendDataButton);
            this.sendSetGroupBox.Location = new System.Drawing.Point(6, 572);
            this.sendSetGroupBox.Name = "sendSetGroupBox";
            this.sendSetGroupBox.Size = new System.Drawing.Size(296, 175);
            this.sendSetGroupBox.TabIndex = 8;
            this.sendSetGroupBox.TabStop = false;
            this.sendSetGroupBox.Text = "发送设置";
            // 
            // sendHexCheckBox
            // 
            this.sendHexCheckBox.AutoSize = true;
            this.sendHexCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendHexCheckBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendHexCheckBox.Location = new System.Drawing.Point(5, 43);
            this.sendHexCheckBox.Name = "sendHexCheckBox";
            this.sendHexCheckBox.Size = new System.Drawing.Size(122, 28);
            this.sendHexCheckBox.TabIndex = 6;
            this.sendHexCheckBox.Text = "HEX发送";
            this.sendHexCheckBox.UseVisualStyleBackColor = true;
            // 
            // multiSendButton
            // 
            this.multiSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiSendButton.Location = new System.Drawing.Point(150, 113);
            this.multiSendButton.Name = "multiSendButton";
            this.multiSendButton.Size = new System.Drawing.Size(128, 40);
            this.multiSendButton.TabIndex = 3;
            this.multiSendButton.Text = "多项发送";
            this.multiSendButton.UseVisualStyleBackColor = true;
            this.multiSendButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MultiSendButton_MouseClick);
            // 
            // clearSendButton
            // 
            this.clearSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearSendButton.Location = new System.Drawing.Point(5, 113);
            this.clearSendButton.Name = "clearSendButton";
            this.clearSendButton.Size = new System.Drawing.Size(128, 40);
            this.clearSendButton.TabIndex = 2;
            this.clearSendButton.Text = "清发送区";
            this.clearSendButton.UseVisualStyleBackColor = true;
            this.clearSendButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearSendButton_MouseClick);
            // 
            // sendDataButton
            // 
            this.sendDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendDataButton.Location = new System.Drawing.Point(150, 35);
            this.sendDataButton.Name = "sendDataButton";
            this.sendDataButton.Size = new System.Drawing.Size(128, 40);
            this.sendDataButton.TabIndex = 1;
            this.sendDataButton.Text = "发送数据";
            this.sendDataButton.UseVisualStyleBackColor = true;
            this.sendDataButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SendDataButton_MouseClick);
            // 
            // sendGroupBox
            // 
            this.sendGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sendGroupBox.Controls.Add(this.sendRichTextBox);
            this.sendGroupBox.Location = new System.Drawing.Point(8, 271);
            this.sendGroupBox.Name = "sendGroupBox";
            this.sendGroupBox.Size = new System.Drawing.Size(593, 291);
            this.sendGroupBox.TabIndex = 7;
            this.sendGroupBox.TabStop = false;
            this.sendGroupBox.Text = "数据发送区";
            // 
            // sendRichTextBox
            // 
            this.sendRichTextBox.Location = new System.Drawing.Point(15, 34);
            this.sendRichTextBox.Name = "sendRichTextBox";
            this.sendRichTextBox.Size = new System.Drawing.Size(561, 240);
            this.sendRichTextBox.TabIndex = 0;
            this.sendRichTextBox.Text = "";
            // 
            // portGroupBox
            // 
            this.portGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.portGroupBox.Controls.Add(this.statusPortLabel);
            this.portGroupBox.Controls.Add(this.portPictureBox);
            this.portGroupBox.Controls.Add(this.stopBitLabel);
            this.portGroupBox.Controls.Add(this.stopBitComboBox);
            this.portGroupBox.Controls.Add(this.parityBitLabel);
            this.portGroupBox.Controls.Add(this.parityBitComboBox);
            this.portGroupBox.Controls.Add(this.dataBitLabel);
            this.portGroupBox.Controls.Add(this.dataBitComboBox);
            this.portGroupBox.Controls.Add(this.baudRateLabel);
            this.portGroupBox.Controls.Add(this.baudRateComboBox);
            this.portGroupBox.Controls.Add(this.portLabel);
            this.portGroupBox.Controls.Add(this.portComboBox);
            this.portGroupBox.ForeColor = System.Drawing.Color.Black;
            this.portGroupBox.Location = new System.Drawing.Point(7, 6);
            this.portGroupBox.Name = "portGroupBox";
            this.portGroupBox.Size = new System.Drawing.Size(594, 262);
            this.portGroupBox.TabIndex = 6;
            this.portGroupBox.TabStop = false;
            this.portGroupBox.Text = "串口设置";
            // 
            // statusPortLabel
            // 
            this.statusPortLabel.AutoSize = true;
            this.statusPortLabel.Location = new System.Drawing.Point(324, 54);
            this.statusPortLabel.Name = "statusPortLabel";
            this.statusPortLabel.Size = new System.Drawing.Size(106, 24);
            this.statusPortLabel.TabIndex = 12;
            this.statusPortLabel.Text = "开启串口";
            // 
            // stopBitLabel
            // 
            this.stopBitLabel.AutoSize = true;
            this.stopBitLabel.Location = new System.Drawing.Point(324, 130);
            this.stopBitLabel.Name = "stopBitLabel";
            this.stopBitLabel.Size = new System.Drawing.Size(82, 24);
            this.stopBitLabel.TabIndex = 9;
            this.stopBitLabel.Text = "停止位";
            // 
            // stopBitComboBox
            // 
            this.stopBitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopBitComboBox.FormattingEnabled = true;
            this.stopBitComboBox.Items.AddRange(new object[] {
            "1位",
            "2位"});
            this.stopBitComboBox.Location = new System.Drawing.Point(448, 132);
            this.stopBitComboBox.Name = "stopBitComboBox";
            this.stopBitComboBox.Size = new System.Drawing.Size(131, 32);
            this.stopBitComboBox.TabIndex = 8;
            this.stopBitComboBox.Tag = "";
            // 
            // parityBitLabel
            // 
            this.parityBitLabel.AutoSize = true;
            this.parityBitLabel.Location = new System.Drawing.Point(324, 206);
            this.parityBitLabel.Name = "parityBitLabel";
            this.parityBitLabel.Size = new System.Drawing.Size(82, 24);
            this.parityBitLabel.TabIndex = 7;
            this.parityBitLabel.Text = "校验位";
            // 
            // parityBitComboBox
            // 
            this.parityBitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityBitComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parityBitComboBox.FormattingEnabled = true;
            this.parityBitComboBox.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.parityBitComboBox.Location = new System.Drawing.Point(448, 206);
            this.parityBitComboBox.Name = "parityBitComboBox";
            this.parityBitComboBox.Size = new System.Drawing.Size(131, 32);
            this.parityBitComboBox.TabIndex = 6;
            // 
            // dataBitLabel
            // 
            this.dataBitLabel.AutoSize = true;
            this.dataBitLabel.Location = new System.Drawing.Point(13, 198);
            this.dataBitLabel.Name = "dataBitLabel";
            this.dataBitLabel.Size = new System.Drawing.Size(82, 24);
            this.dataBitLabel.TabIndex = 5;
            this.dataBitLabel.Text = "数据位";
            // 
            // dataBitComboBox
            // 
            this.dataBitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataBitComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dataBitComboBox.FormattingEnabled = true;
            this.dataBitComboBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.dataBitComboBox.Location = new System.Drawing.Point(135, 198);
            this.dataBitComboBox.Name = "dataBitComboBox";
            this.dataBitComboBox.Size = new System.Drawing.Size(131, 32);
            this.dataBitComboBox.TabIndex = 4;
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(13, 122);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(82, 24);
            this.baudRateLabel.TabIndex = 3;
            this.baudRateLabel.Text = "波特率";
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.baudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.baudRateComboBox.Location = new System.Drawing.Point(135, 122);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(131, 32);
            this.baudRateComboBox.TabIndex = 2;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(13, 46);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(82, 24);
            this.portLabel.TabIndex = 1;
            this.portLabel.Text = "端口号";
            // 
            // portComboBox
            // 
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(135, 46);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(131, 32);
            this.portComboBox.TabIndex = 0;
            this.portComboBox.DropDown += new System.EventHandler(this.PortComboBox_DropDown);
            // 
            // receiveGroupBox
            // 
            this.receiveGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receiveGroupBox.Controls.Add(this.receiveRichTextBox);
            this.receiveGroupBox.Location = new System.Drawing.Point(617, 6);
            this.receiveGroupBox.Name = "receiveGroupBox";
            this.receiveGroupBox.Size = new System.Drawing.Size(763, 741);
            this.receiveGroupBox.TabIndex = 9;
            this.receiveGroupBox.TabStop = false;
            this.receiveGroupBox.Text = "数据接收区";
            // 
            // receiveRichTextBox
            // 
            this.receiveRichTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receiveRichTextBox.Location = new System.Drawing.Point(16, 32);
            this.receiveRichTextBox.Name = "receiveRichTextBox";
            this.receiveRichTextBox.Size = new System.Drawing.Size(732, 689);
            this.receiveRichTextBox.TabIndex = 0;
            this.receiveRichTextBox.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1389, 813);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1389, 813);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // portPictureBox
            // 
            this.portPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.portPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.portPictureBox.ErrorImage = null;
            this.portPictureBox.Image = global::JoneSoft.Properties.Resources.port_off;
            this.portPictureBox.InitialImage = global::JoneSoft.Properties.Resources.port_on;
            this.portPictureBox.Location = new System.Drawing.Point(459, 39);
            this.portPictureBox.Name = "portPictureBox";
            this.portPictureBox.Size = new System.Drawing.Size(109, 51);
            this.portPictureBox.TabIndex = 11;
            this.portPictureBox.TabStop = false;
            this.portPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PortPictureBox_MouseClick);
            // 
            // JoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1428, 883);
            this.Controls.Add(this.JoneTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JoneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jone SoftWare";
            this.JoneTabControl.ResumeLayout(false);
            this.SerialTabPage.ResumeLayout(false);
            this.SerialTabPage.PerformLayout();
            this.serialStatusStrip.ResumeLayout(false);
            this.serialStatusStrip.PerformLayout();
            this.receiveSetGroupBox.ResumeLayout(false);
            this.receiveSetGroupBox.PerformLayout();
            this.sendSetGroupBox.ResumeLayout(false);
            this.sendSetGroupBox.PerformLayout();
            this.sendGroupBox.ResumeLayout(false);
            this.portGroupBox.ResumeLayout(false);
            this.portGroupBox.PerformLayout();
            this.receiveGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.portPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl JoneTabControl;
        private System.Windows.Forms.StatusStrip serialStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel portStatusToolStripStatusLabel;
        private System.Windows.Forms.GroupBox receiveSetGroupBox;
        private System.Windows.Forms.CheckBox receiveHexCheckBox;
        private System.Windows.Forms.Button clearReceiveButton;
        private System.Windows.Forms.Button saveDataButton;
        private System.Windows.Forms.Button viewDataButton;
        private System.Windows.Forms.GroupBox sendSetGroupBox;
        private System.Windows.Forms.CheckBox sendHexCheckBox;
        private System.Windows.Forms.Button multiSendButton;
        private System.Windows.Forms.Button clearSendButton;
        private System.Windows.Forms.Button sendDataButton;
        private System.Windows.Forms.GroupBox sendGroupBox;
        private System.Windows.Forms.RichTextBox sendRichTextBox;
        private System.Windows.Forms.GroupBox portGroupBox;
        private System.Windows.Forms.Label statusPortLabel;
        private System.Windows.Forms.PictureBox portPictureBox;
        private System.Windows.Forms.Label stopBitLabel;
        private System.Windows.Forms.ComboBox stopBitComboBox;
        private System.Windows.Forms.Label parityBitLabel;
        private System.Windows.Forms.ComboBox parityBitComboBox;
        private System.Windows.Forms.Label dataBitLabel;
        private System.Windows.Forms.ComboBox dataBitComboBox;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.GroupBox receiveGroupBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox receiveRichTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage SerialTabPage;
    }
}

