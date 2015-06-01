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
            this.openFolderButton = new System.Windows.Forms.Button();
            this.subdirectCheckBox = new System.Windows.Forms.CheckBox();
            this.chooseDirectoryGroup = new System.Windows.Forms.GroupBox();
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
            this.outPutText = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStripProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.chooseDirectoryGroup.SuspendLayout();
            this.parseStatusPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.subdirectCheckBox.Size = new System.Drawing.Size(185, 21);
            this.subdirectCheckBox.TabIndex = 1;
            this.subdirectCheckBox.Text = "Включати підкаталоги?";
            this.subdirectCheckBox.UseVisualStyleBackColor = true;
            // 
            // chooseDirectoryGroup
            // 
            this.chooseDirectoryGroup.Controls.Add(this.parseButton);
            this.chooseDirectoryGroup.Controls.Add(this.parseStatusPanel);
            this.chooseDirectoryGroup.Controls.Add(this.openFolderPathBox);
            this.chooseDirectoryGroup.Controls.Add(this.subdirectCheckBox);
            this.chooseDirectoryGroup.Controls.Add(this.openFolderButton);
            this.chooseDirectoryGroup.Controls.Add(this.selectFolderLabel);
            this.chooseDirectoryGroup.Location = new System.Drawing.Point(12, 12);
            this.chooseDirectoryGroup.Name = "chooseDirectoryGroup";
            this.chooseDirectoryGroup.Size = new System.Drawing.Size(214, 198);
            this.chooseDirectoryGroup.TabIndex = 2;
            this.chooseDirectoryGroup.TabStop = false;
            this.chooseDirectoryGroup.Text = "Сканування";
            // 
            // parseButton
            // 
            this.parseButton.Location = new System.Drawing.Point(64, 100);
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
            this.parseStatusPanel.Location = new System.Drawing.Point(6, 129);
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
            this.parsingStatusLabel.Size = new System.Drawing.Size(46, 17);
            this.parsingStatusLabel.TabIndex = 11;
            this.parsingStatusLabel.Text = "label2";
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
            this.toolStripProgressLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(557, 25);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
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
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // toolStripProgressLabel
            // 
            this.toolStripProgressLabel.Name = "toolStripProgressLabel";
            this.toolStripProgressLabel.Size = new System.Drawing.Size(151, 20);
            this.toolStripProgressLabel.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 380);
            this.Controls.Add(this.outPutText);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chooseDirectoryGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.chooseDirectoryGroup.ResumeLayout(false);
            this.chooseDirectoryGroup.PerformLayout();
            this.parseStatusPanel.ResumeLayout(false);
            this.parseStatusPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox outPutText;
        private System.Windows.Forms.Panel parseStatusPanel;
        private System.Windows.Forms.Button stopParsingButton;
        private System.Windows.Forms.ProgressBar parsingProgressBar;
        private System.Windows.Forms.Label parsingStatusLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripProgressLabel;
    }
}

