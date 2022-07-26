namespace CTScanFileUtilityUI
{
    partial class MainWindow
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
            this.label4 = new System.Windows.Forms.Label();
            this.sampleIdTextBox = new System.Windows.Forms.TextBox();
            this.projectIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentSampleTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.checkFileNameButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.introTextLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.currentFolderTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.selectDirectoryButton = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sample ID";
            // 
            // sampleIdTextBox
            // 
            this.sampleIdTextBox.Location = new System.Drawing.Point(163, 183);
            this.sampleIdTextBox.Name = "sampleIdTextBox";
            this.sampleIdTextBox.Size = new System.Drawing.Size(273, 22);
            this.sampleIdTextBox.TabIndex = 8;
            // 
            // projectIdTextBox
            // 
            this.projectIdTextBox.Location = new System.Drawing.Point(163, 146);
            this.projectIdTextBox.Name = "projectIdTextBox";
            this.projectIdTextBox.Size = new System.Drawing.Size(273, 22);
            this.projectIdTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sample No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Project ID";
            // 
            // currentSampleTextBox
            // 
            this.currentSampleTextBox.Location = new System.Drawing.Point(163, 219);
            this.currentSampleTextBox.Name = "currentSampleTextBox";
            this.currentSampleTextBox.Size = new System.Drawing.Size(273, 22);
            this.currentSampleTextBox.TabIndex = 10;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(163, 111);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(273, 22);
            this.userNameTextBox.TabIndex = 4;
            // 
            // checkFileNameButton
            // 
            this.checkFileNameButton.Location = new System.Drawing.Point(192, 263);
            this.checkFileNameButton.Name = "checkFileNameButton";
            this.checkFileNameButton.Size = new System.Drawing.Size(132, 35);
            this.checkFileNameButton.TabIndex = 11;
            this.checkFileNameButton.Text = "Check File Name";
            this.checkFileNameButton.UseVisualStyleBackColor = true;
            this.checkFileNameButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // introTextLabel
            // 
            this.introTextLabel.AutoSize = true;
            this.introTextLabel.Location = new System.Drawing.Point(140, 312);
            this.introTextLabel.Name = "introTextLabel";
            this.introTextLabel.Size = new System.Drawing.Size(249, 17);
            this.introTextLabel.TabIndex = 12;
            this.introTextLabel.Text = "Will create file with the following name:";
            this.introTextLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Folder";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLabel.Location = new System.Drawing.Point(107, 346);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(66, 24);
            this.fileNameLabel.TabIndex = 13;
            this.fileNameLabel.Text = "label6";
            this.fileNameLabel.Visible = false;
            // 
            // currentFolderTextBox
            // 
            this.currentFolderTextBox.Location = new System.Drawing.Point(163, 80);
            this.currentFolderTextBox.Name = "currentFolderTextBox";
            this.currentFolderTextBox.Size = new System.Drawing.Size(273, 22);
            this.currentFolderTextBox.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(192, 405);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(139, 63);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Visible = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // selectDirectoryButton
            // 
            this.selectDirectoryButton.Location = new System.Drawing.Point(174, 13);
            this.selectDirectoryButton.Name = "selectDirectoryButton";
            this.selectDirectoryButton.Size = new System.Drawing.Size(150, 41);
            this.selectDirectoryButton.TabIndex = 0;
            this.selectDirectoryButton.Text = "Select Directory";
            this.selectDirectoryButton.UseVisualStyleBackColor = true;
            this.selectDirectoryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.selectDirectoryButton);
            this.settingsPanel.Controls.Add(this.startButton);
            this.settingsPanel.Controls.Add(this.currentFolderTextBox);
            this.settingsPanel.Controls.Add(this.fileNameLabel);
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Controls.Add(this.introTextLabel);
            this.settingsPanel.Controls.Add(this.label2);
            this.settingsPanel.Controls.Add(this.checkFileNameButton);
            this.settingsPanel.Controls.Add(this.userNameTextBox);
            this.settingsPanel.Controls.Add(this.currentSampleTextBox);
            this.settingsPanel.Controls.Add(this.label3);
            this.settingsPanel.Controls.Add(this.label5);
            this.settingsPanel.Controls.Add(this.projectIdTextBox);
            this.settingsPanel.Controls.Add(this.sampleIdTextBox);
            this.settingsPanel.Controls.Add(this.label4);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(518, 510);
            this.settingsPanel.TabIndex = 15;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 510);
            this.Controls.Add(this.settingsPanel);
            this.Name = "MainWindow";
            this.Text = "CT Scan File Utility";
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sampleIdTextBox;
        private System.Windows.Forms.TextBox projectIdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currentSampleTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button checkFileNameButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label introTextLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox currentFolderTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button selectDirectoryButton;
        private System.Windows.Forms.Panel settingsPanel;
    }
}

