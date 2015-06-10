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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loadArtists = new System.Windows.Forms.Button();
            this.loadAlbums = new System.Windows.Forms.Button();
            this.loadAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.volumeLevel = new System.Windows.Forms.Label();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.playerTrackName = new System.Windows.Forms.Label();
            this.playerStopButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playerPlaytime = new System.Windows.Forms.Label();
            this.playerDuration = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerPauseButton = new System.Windows.Forms.Button();
            this.playTrackBar = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.columnsComboBox = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.chooseDirectoryGroup.SuspendLayout();
            this.parseStatusPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFolderButton
            // 
            this.openFolderButton.Location = new System.Drawing.Point(152, 45);
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
            this.subdirectCheckBox.Checked = true;
            this.subdirectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.subdirectCheckBox.Location = new System.Drawing.Point(27, 73);
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
            this.chooseDirectoryGroup.Location = new System.Drawing.Point(5, 12);
            this.chooseDirectoryGroup.Name = "chooseDirectoryGroup";
            this.chooseDirectoryGroup.Size = new System.Drawing.Size(260, 232);
            this.chooseDirectoryGroup.TabIndex = 2;
            this.chooseDirectoryGroup.TabStop = false;
            this.chooseDirectoryGroup.Text = "Сканування";
            // 
            // showProcessCheckBox
            // 
            this.showProcessCheckBox.AutoSize = true;
            this.showProcessCheckBox.Checked = true;
            this.showProcessCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showProcessCheckBox.Location = new System.Drawing.Point(27, 100);
            this.showProcessCheckBox.Name = "showProcessCheckBox";
            this.showProcessCheckBox.Size = new System.Drawing.Size(158, 21);
            this.showProcessCheckBox.TabIndex = 12;
            this.showProcessCheckBox.Text = "Показувати процес";
            this.showProcessCheckBox.UseVisualStyleBackColor = true;
            // 
            // parseButton
            // 
            this.parseButton.Location = new System.Drawing.Point(74, 127);
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
            this.parseStatusPanel.Location = new System.Drawing.Point(22, 156);
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
            this.openFolderPathBox.Location = new System.Drawing.Point(27, 45);
            this.openFolderPathBox.Name = "openFolderPathBox";
            this.openFolderPathBox.Size = new System.Drawing.Size(119, 22);
            this.openFolderPathBox.TabIndex = 7;
            // 
            // selectFolderLabel
            // 
            this.selectFolderLabel.AutoSize = true;
            this.selectFolderLabel.Location = new System.Drawing.Point(24, 25);
            this.selectFolderLabel.Name = "selectFolderLabel";
            this.selectFolderLabel.Size = new System.Drawing.Size(119, 17);
            this.selectFolderLabel.TabIndex = 3;
            this.selectFolderLabel.Text = "Оберіть каталог:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 24);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 556);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(969, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressLabel
            // 
            this.toolStripProgressLabel.Name = "toolStripProgressLabel";
            this.toolStripProgressLabel.Size = new System.Drawing.Size(954, 17);
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
            this.outPutText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.outPutText.Location = new System.Drawing.Point(5, 250);
            this.outPutText.Multiline = true;
            this.outPutText.Name = "outPutText";
            this.outPutText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outPutText.Size = new System.Drawing.Size(260, 303);
            this.outPutText.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 176);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(300, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(686, 377);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.MouseEnter += new System.EventHandler(this.dataGridView1_MouseEnter);
            // 
            // loadArtists
            // 
            this.loadArtists.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadArtists.Location = new System.Drawing.Point(480, 11);
            this.loadArtists.Name = "loadArtists";
            this.loadArtists.Size = new System.Drawing.Size(97, 23);
            this.loadArtists.TabIndex = 14;
            this.loadArtists.Text = "Виконавці";
            this.loadArtists.UseVisualStyleBackColor = true;
            this.loadArtists.Click += new System.EventHandler(this.loadArtists_Click);
            // 
            // loadAlbums
            // 
            this.loadAlbums.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadAlbums.Location = new System.Drawing.Point(583, 11);
            this.loadAlbums.Name = "loadAlbums";
            this.loadAlbums.Size = new System.Drawing.Size(97, 23);
            this.loadAlbums.TabIndex = 15;
            this.loadAlbums.Text = "Альбоми";
            this.loadAlbums.UseVisualStyleBackColor = true;
            this.loadAlbums.Click += new System.EventHandler(this.loadAlbums_Click);
            // 
            // loadAll
            // 
            this.loadAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadAll.Location = new System.Drawing.Point(377, 11);
            this.loadAll.Name = "loadAll";
            this.loadAll.Size = new System.Drawing.Size(97, 23);
            this.loadAll.TabIndex = 17;
            this.loadAll.Text = "Фонотека";
            this.loadAll.UseVisualStyleBackColor = true;
            this.loadAll.Click += new System.EventHandler(this.loadAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox2);
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
            this.groupBox1.Location = new System.Drawing.Point(271, 12);
            this.groupBox1.MinimumSize = new System.Drawing.Size(300, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 121);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = global::MusicDataBase.Properties.Resources.volume;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(576, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // volumeLevel
            // 
            this.volumeLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeLevel.AutoSize = true;
            this.volumeLevel.Location = new System.Drawing.Point(605, 25);
            this.volumeLevel.Name = "volumeLevel";
            this.volumeLevel.Size = new System.Drawing.Size(44, 17);
            this.volumeLevel.TabIndex = 10;
            this.volumeLevel.Text = "100%";
            this.volumeLevel.Visible = false;
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeTrackBar.AutoSize = false;
            this.volumeTrackBar.Location = new System.Drawing.Point(599, 12);
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
            // playerTrackName
            // 
            this.playerTrackName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerTrackName.AutoSize = true;
            this.playerTrackName.BackColor = System.Drawing.Color.Transparent;
            this.playerTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerTrackName.Location = new System.Drawing.Point(296, 12);
            this.playerTrackName.Name = "playerTrackName";
            this.playerTrackName.Size = new System.Drawing.Size(0, 17);
            this.playerTrackName.TabIndex = 8;
            // 
            // playerStopButton
            // 
            this.playerStopButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerStopButton.Location = new System.Drawing.Point(397, 88);
            this.playerStopButton.Name = "playerStopButton";
            this.playerStopButton.Size = new System.Drawing.Size(75, 23);
            this.playerStopButton.TabIndex = 7;
            this.playerStopButton.Text = "Stop";
            this.playerStopButton.UseVisualStyleBackColor = true;
            this.playerStopButton.Click += new System.EventHandler(this.playerStopButton_Click);
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
            // playerPlaytime
            // 
            this.playerPlaytime.AutoSize = true;
            this.playerPlaytime.Location = new System.Drawing.Point(135, 45);
            this.playerPlaytime.Name = "playerPlaytime";
            this.playerPlaytime.Size = new System.Drawing.Size(56, 17);
            this.playerPlaytime.TabIndex = 5;
            this.playerPlaytime.Text = "0:00:00";
            // 
            // playerDuration
            // 
            this.playerDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerDuration.AutoSize = true;
            this.playerDuration.Location = new System.Drawing.Point(605, 45);
            this.playerDuration.Name = "playerDuration";
            this.playerDuration.Size = new System.Drawing.Size(56, 17);
            this.playerDuration.TabIndex = 4;
            this.playerDuration.Text = "0:00:00";
            // 
            // playerLabel
            // 
            this.playerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(364, 45);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(0, 17);
            this.playerLabel.TabIndex = 3;
            // 
            // playerPauseButton
            // 
            this.playerPauseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerPauseButton.Location = new System.Drawing.Point(316, 88);
            this.playerPauseButton.Name = "playerPauseButton";
            this.playerPauseButton.Size = new System.Drawing.Size(75, 23);
            this.playerPauseButton.TabIndex = 2;
            this.playerPauseButton.Text = "Play";
            this.playerPauseButton.UseVisualStyleBackColor = true;
            this.playerPauseButton.Click += new System.EventHandler(this.playerPauseButton_Click);
            // 
            // playTrackBar
            // 
            this.playTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playTrackBar.Location = new System.Drawing.Point(126, 60);
            this.playTrackBar.Name = "playTrackBar";
            this.playTrackBar.Size = new System.Drawing.Size(543, 56);
            this.playTrackBar.TabIndex = 0;
            this.playTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.playTrackBar.Scroll += new System.EventHandler(this.playTrackBar_Scroll);
            this.playTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playTrackBar_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.columnsComboBox);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.searchBox);
            this.groupBox2.Controls.Add(this.loadAll);
            this.groupBox2.Controls.Add(this.loadArtists);
            this.groupBox2.Controls.Add(this.loadAlbums);
            this.groupBox2.Location = new System.Drawing.Point(271, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 37);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // columnsComboBox
            // 
            this.columnsComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.columnsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnsComboBox.FormattingEnabled = true;
            this.columnsComboBox.Location = new System.Drawing.Point(157, 10);
            this.columnsComboBox.Name = "columnsComboBox";
            this.columnsComboBox.Size = new System.Drawing.Size(111, 24);
            this.columnsComboBox.TabIndex = 20;
            this.columnsComboBox.SelectedIndexChanged += new System.EventHandler(this.columnsComboBox_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.Location = new System.Drawing.Point(7, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.searchBox.Location = new System.Drawing.Point(51, 11);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 22);
            this.searchBox.TabIndex = 18;
            this.searchBox.Text = "пошук";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 578);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.outPutText);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chooseDirectoryGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фонотека";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.chooseDirectoryGroup.ResumeLayout(false);
            this.chooseDirectoryGroup.PerformLayout();
            this.parseStatusPanel.ResumeLayout(false);
            this.parseStatusPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button loadArtists;
        private System.Windows.Forms.Button loadAlbums;
        private System.Windows.Forms.Button loadAll;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox columnsComboBox;
    }
}

