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
            this.chooseDirectoryGroup.SuspendLayout();
            this.parseStatusPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(557, 24);
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
            this.statusStrip1.Size = new System.Drawing.Size(557, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressLabel
            // 
            this.toolStripProgressLabel.Name = "toolStripProgressLabel";
            this.toolStripProgressLabel.Size = new System.Drawing.Size(542, 17);
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
            this.button1.Location = new System.Drawing.Point(75, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "insert";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 380);
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
    }
}

