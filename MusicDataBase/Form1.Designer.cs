namespace MusicDataBase
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFolderButton = new System.Windows.Forms.Button();
            this.subdirectCheckBox = new System.Windows.Forms.CheckBox();
            this.chooseDirectoryGroup = new System.Windows.Forms.GroupBox();
            this.showProcessCheckBox = new System.Windows.Forms.CheckBox();
            this.parseButton = new System.Windows.Forms.Button();
            this.parseStatusPanel = new System.Windows.Forms.Panel();
            this.stopParsingButton = new System.Windows.Forms.Button();
            this.parsingProgressBar = new System.Windows.Forms.ProgressBar();
            this.parsingStatusLabel = new System.Windows.Forms.Label();
            this.openFolderPathBox = new System.Windows.Forms.TextBox();
            this.selectFolderLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.outPutText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playerPlaytime = new System.Windows.Forms.Label();
            this.playerDuration = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerPauseButton = new System.Windows.Forms.Button();
            this.playTrackBar = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playerStopButton = new System.Windows.Forms.Button();
            this.playerTrackName = new System.Windows.Forms.Label();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.volumeLevel = new System.Windows.Forms.Label();
            this.chooseDirectoryGroup.SuspendLayout();
            this.parseStatusPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // openFolderButton
            // 
            this.openFolderButton.Location = new System.Drawing.Point(131, 45);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(75, 23);
            this.openFolderButton.TabIndex = 0;
            this.openFolderButton.Text = "Обрати";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_click);
            // 
            // subdirectCheckBox
            // 
            this.subdirectCheckBox.AutoSize = true;
            this.subdirectCheckBox.Location = new System.Drawing.Point(6, 73);
            this.subdirectCheckBox.Name = "subdirectCheckBox";
            this.subdirectCheckBox.Size = new System.Drawing.Size(177, 21);
            this.subdirectCheckBox.TabIndex = 1;
            this.subdirectCheckBox.Text = "Включати підкаталоги";
            this.subdirectCheckBox.UseVisualStyleBackColor = true;
            // 
            // chooseDirectoryGroup
            // 
            this.chooseDirectoryGroup.Controls.Add(this.showProcessCheckBox);
            this.chooseDirectoryGroup.Controls.Add(this.parseButton);
            this.chooseDirectoryGroup.Controls.Add(this.parseStatusPanel);
            this.chooseDirectoryGroup.Controls.Add(this.openFolderPathBox);
            this.chooseDirectoryGroup.Controls.Add(this.subdirectCheckBox);
            this.chooseDirectoryGroup.Controls.Add(this.openFolderButton);
            this.chooseDirectoryGroup.Controls.Add(this.selectFolderLabel);
            this.chooseDirectoryGroup.Location = new System.Drawing.Point(12, 12);
            this.chooseDirectoryGroup.Name = "chooseDirectoryGroup";
            this.chooseDirectoryGroup.Size = new System.Drawing.Size(214, 232);
            this.chooseDirectoryGroup.TabIndex = 2;
            this.chooseDirectoryGroup.TabStop = false;
            this.chooseDirectoryGroup.Text = "Сканування";
            // 
            // showProcessCheckBox
            // 
            this.showProcessCheckBox.AutoSize = true;
            this.showProcessCheckBox.Location = new System.Drawing.Point(6, 100);
            this.showProcessCheckBox.Name = "showProcessCheckBox";
            this.showProcessCheckBox.Size = new System.Drawing.Size(158, 21);
            this.showProcessCheckBox.TabIndex = 12;
            this.showProcessCheckBox.Text = "Показувати процес";
            this.showProcessCheckBox.UseVisualStyleBackColor = true;
            // 
            // parseButton
            // 
            this.parseButton.Location = new System.Drawing.Point(63, 127);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(86, 23);
            this.parseButton.TabIndex = 8;
            this.parseButton.Text = "Сканувати";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.parseButton_click);
            // 
            // parseStatusPanel
            // 
            this.parseStatusPanel.Controls.Add(this.stopParsingButton);
            this.parseStatusPanel.Controls.Add(this.parsingProgressBar);
            this.parseStatusPanel.Controls.Add(this.parsingStatusLabel);
            this.parseStatusPanel.Location = new System.Drawing.Point(6, 156);
            this.parseStatusPanel.Name = "parseStatusPanel";
            this.parseStatusPanel.Size = new System.Drawing.Size(208, 58);
            this.parseStatusPanel.TabIndex = 8;
            // 
            // stopParsingButton
            // 
            this.stopParsingButton.Location = new System.Drawing.Point(130, 28);
            this.stopParsingButton.Name = "stopParsingButton";
            this.stopParsingButton.Size = new System.Drawing.Size(75, 23);
            this.stopParsingButton.TabIndex = 9;
            this.stopParsingButton.Text = "Стоп";
            this.stopParsingButton.UseVisualStyleBackColor = true;
            this.stopParsingButton.Click += new System.EventHandler(this.stopParsingButton_Click);
            // 
            // parsingProgressBar
            // 
            this.parsingProgressBar.Location = new System.Drawing.Point(4, 28);
            this.parsingProgressBar.Name = "parsingProgressBar";
            this.parsingProgressBar.Size = new System.Drawing.Size(120, 23);
            this.parsingProgressBar.TabIndex = 10;
            // 
            // parsingStatusLabel
            // 
            this.parsingStatusLabel.AutoSize = true;
            this.parsingStatusLabel.Location = new System.Drawing.Point(4, 5);
            this.parsingStatusLabel.Name = "parsingStatusLabel";
            this.parsingStatusLabel.Size = new System.Drawing.Size(61, 17);
            this.parsingStatusLabel.TabIndex = 11;
            this.parsingStatusLabel.Text = "Статус: ";
            // 
            // openFolderPathBox
            // 
            this.openFolderPathBox.Location = new System.Drawing.Point(6, 45);
            this.openFolderPathBox.Name = "openFolderPathBox";
            this.openFolderPathBox.Size = new System.Drawing.Size(119, 22);
            this.openFolderPathBox.TabIndex = 7;
            // 
            // selectFolderLabel
            // 
            this.selectFolderLabel.AutoSize = true;
            this.selectFolderLabel.Location = new System.Drawing.Point(3, 25);
            this.selectFolderLabel.Name = "selectFolderLabel";
            this.selectFolderLabel.Size = new System.Drawing.Size(119, 17);
            this.selectFolderLabel.TabIndex = 3;
            this.selectFolderLabel.Text = "Оберіть каталог:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressLabel,
            this.toolStripProgressCountLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(927, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressLabel
            // 
            this.toolStripProgressLabel.Name = "toolStripProgressLabel";
            this.toolStripProgressLabel.Size = new System.Drawing.Size(912, 17);
            this.toolStripProgressLabel.Spring = true;
            this.toolStripProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripProgressCountLabel
            // 
            this.toolStripProgressCountLabel.Name = "toolStripProgressCountLabel";
            this.toolStripProgressCountLabel.Size = new System.Drawing.Size(0, 17);
            this.toolStripProgressCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClosed += new System.EventHandler(this.notifyIcon1_BalloonTipClosed);
            // 
            // outPutText
            // 
            this.outPutText.Location = new System.Drawing.Point(232, 12);
            this.outPutText.Multiline = true;
            this.outPutText.Name = "outPutText";
            this.outPutText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outPutText.Size = new System.Drawing.Size(313, 343);
            this.outPutText.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tracks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(43, 290);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(551, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(364, 216);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.MouseEnter += new System.EventHandler(this.dataGridView1_MouseEnter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Artists";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Albums";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.volumeLevel);
            this.groupBox1.Controls.Add(this.volumeTrackBar);
            this.groupBox1.Controls.Add(this.playerTrackName);
            this.groupBox1.Controls.Add(this.playerStopButton);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.playerPlaytime);
            this.groupBox1.Controls.Add(this.playerDuration);
            this.groupBox1.Controls.Add(this.playerLabel);
            this.groupBox1.Controls.Add(this.playerPauseButton);
            this.groupBox1.Controls.Add(this.playTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(551, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 121);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // playerPlaytime
            // 
            this.playerPlaytime.AutoSize = true;
            this.playerPlaytime.Location = new System.Drawing.Point(135, 45);
            this.playerPlaytime.Name = "playerPlaytime";
            this.playerPlaytime.Size = new System.Drawing.Size(36, 17);
            this.playerPlaytime.TabIndex = 5;
            this.playerPlaytime.Text = "0:00";
            // 
            // playerDuration
            // 
            this.playerDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerDuration.AutoSize = true;
            this.playerDuration.Location = new System.Drawing.Point(298, 45);
            this.playerDuration.Name = "playerDuration";
            this.playerDuration.Size = new System.Drawing.Size(36, 17);
            this.playerDuration.TabIndex = 4;
            this.playerDuration.Text = "0:00";
            // 
            // playerLabel
            // 
            this.playerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(203, 45);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(46, 17);
            this.playerLabel.TabIndex = 3;
            this.playerLabel.Text = "label3";
            // 
            // playerPauseButton
            // 
            this.playerPauseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerPauseButton.Location = new System.Drawing.Point(155, 93);
            this.playerPauseButton.Name = "playerPauseButton";
            this.playerPauseButton.Size = new System.Drawing.Size(75, 23);
            this.playerPauseButton.TabIndex = 2;
            this.playerPauseButton.Text = "play";
            this.playerPauseButton.UseVisualStyleBackColor = true;
            this.playerPauseButton.Click += new System.EventHandler(this.playerPauseButton_Click);
            // 
            // playTrackBar
            // 
            this.playTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playTrackBar.Location = new System.Drawing.Point(126, 65);
            this.playTrackBar.Name = "playTrackBar";
            this.playTrackBar.Size = new System.Drawing.Size(221, 56);
            this.playTrackBar.TabIndex = 0;
            this.playTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.playTrackBar.Scroll += new System.EventHandler(this.playTrackBar_Scroll);
            this.playTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playTrackBar_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicDataBase.Properties.Resources.DefaultPicture;
            this.pictureBox1.InitialImage = global::MusicDataBase.Properties.Resources.DefaultPicture;
            this.pictureBox1.Location = new System.Drawing.Point(7, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // playerStopButton
            // 
            this.playerStopButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerStopButton.Location = new System.Drawing.Point(236, 93);
            this.playerStopButton.Name = "playerStopButton";
            this.playerStopButton.Size = new System.Drawing.Size(75, 23);
            this.playerStopButton.TabIndex = 7;
            this.playerStopButton.Text = "stop";
            this.playerStopButton.UseVisualStyleBackColor = true;
            this.playerStopButton.Click += new System.EventHandler(this.playerStopButton_Click);
            // 
            // playerTrackName
            // 
            this.playerTrackName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerTrackName.AutoSize = true;
            this.playerTrackName.BackColor = System.Drawing.Color.Transparent;
            this.playerTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerTrackName.Location = new System.Drawing.Point(135, 12);
            this.playerTrackName.Name = "playerTrackName";
            this.playerTrackName.Size = new System.Drawing.Size(52, 17);
            this.playerTrackName.TabIndex = 8;
            this.playerTrackName.Text = "label3";
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeTrackBar.AutoSize = false;
            this.volumeTrackBar.Location = new System.Drawing.Point(274, 12);
            this.volumeTrackBar.Maximum = 100;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.volumeTrackBar.Size = new System.Drawing.Size(85, 22);
            this.volumeTrackBar.TabIndex = 9;
            this.volumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeTrackBar.Value = 70;
            this.volumeTrackBar.Scroll += new System.EventHandler(this.volumeTrackBar_Scroll);
            this.volumeTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.volumeTrackBar_MouseDown);
            this.volumeTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.volumeTrackBar_MouseUp);
            // 
            // volumeLevel
            // 
            this.volumeLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeLevel.AutoSize = true;
            this.volumeLevel.Location = new System.Drawing.Point(233, 12);
            this.volumeLevel.Name = "volumeLevel";
            this.volumeLevel.Size = new System.Drawing.Size(44, 17);
            this.volumeLevel.TabIndex = 10;
            this.volumeLevel.Text = "100%";
            this.volumeLevel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outPutText);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chooseDirectoryGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.chooseDirectoryGroup.ResumeLayout(false);
            this.chooseDirectoryGroup.PerformLayout();
            this.parseStatusPanel.ResumeLayout(false);
            this.parseStatusPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFolderButton;
        private System.Windows.Forms.CheckBox subdirectCheckBox;
        private System.Windows.Forms.GroupBox chooseDirectoryGroup;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label selectFolderLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox openFolderPathBox;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.Panel parseStatusPanel;
        private System.Windows.Forms.Button stopParsingButton;
        private System.Windows.Forms.ProgressBar parsingProgressBar;
        private System.Windows.Forms.Label parsingStatusLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripProgressLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripProgressCountLabel;
        private System.Windows.Forms.CheckBox showProcessCheckBox;
        private System.Windows.Forms.TextBox outPutText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Button playerPauseButton;
        private System.Windows.Forms.TrackBar playTrackBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label playerPlaytime;
        private System.Windows.Forms.Label playerDuration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button playerStopButton;
        private System.Windows.Forms.Label playerTrackName;
        private System.Windows.Forms.TrackBar volumeTrackBar;
        private System.Windows.Forms.Label volumeLevel;
    }
}

