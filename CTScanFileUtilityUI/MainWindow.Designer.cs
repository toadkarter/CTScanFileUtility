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
            this.button1 = new System.Windows.Forms.Button();
            this.currentFolderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.projectIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sampleIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentSampleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.introTextLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // currentFolderTextBox
            // 
            this.currentFolderTextBox.Location = new System.Drawing.Point(139, 87);
            this.currentFolderTextBox.Name = "currentFolderTextBox";
            this.currentFolderTextBox.Size = new System.Drawing.Size(273, 22);
            this.currentFolderTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(139, 118);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(273, 22);
            this.userNameTextBox.TabIndex = 4;
            // 
            // projectIdTextBox
            // 
            this.projectIdTextBox.Location = new System.Drawing.Point(139, 153);
            this.projectIdTextBox.Name = "projectIdTextBox";
            this.projectIdTextBox.Size = new System.Drawing.Size(273, 22);
            this.projectIdTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Project ID";
            // 
            // sampleIdTextBox
            // 
            this.sampleIdTextBox.Location = new System.Drawing.Point(139, 190);
            this.sampleIdTextBox.Name = "sampleIdTextBox";
            this.sampleIdTextBox.Size = new System.Drawing.Size(273, 22);
            this.sampleIdTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sample ID";
            // 
            // currentSampleTextBox
            // 
            this.currentSampleTextBox.Location = new System.Drawing.Point(139, 226);
            this.currentSampleTextBox.Name = "currentSampleTextBox";
            this.currentSampleTextBox.Size = new System.Drawing.Size(273, 22);
            this.currentSampleTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sample No.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Check File Name";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // introTextLabel
            // 
            this.introTextLabel.AutoSize = true;
            this.introTextLabel.Location = new System.Drawing.Point(116, 319);
            this.introTextLabel.Name = "introTextLabel";
            this.introTextLabel.Size = new System.Drawing.Size(249, 17);
            this.introTextLabel.TabIndex = 12;
            this.introTextLabel.Text = "Will create file with the following name:";
            this.introTextLabel.Visible = false;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLabel.Location = new System.Drawing.Point(83, 353);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(66, 24);
            this.fileNameLabel.TabIndex = 13;
            this.fileNameLabel.Text = "label6";
            this.fileNameLabel.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 464);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.introTextLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.currentSampleTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sampleIdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.projectIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentFolderTextBox);
            this.Controls.Add(this.button1);
            this.Name = "MainWindow";
            this.Text = "CT Scan File Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox currentFolderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox projectIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sampleIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currentSampleTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label introTextLabel;
        private System.Windows.Forms.Label fileNameLabel;
    }
}

