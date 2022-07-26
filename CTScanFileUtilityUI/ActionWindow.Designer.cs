namespace CTScanFileUtilityUI
{
    partial class ActionWindow
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
            this.settingsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.actionFileLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logbookEntryLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nextSampleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(166, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(139, 46);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Back to Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current file is:";
            // 
            // actionFileLabel
            // 
            this.actionFileLabel.AutoSize = true;
            this.actionFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionFileLabel.Location = new System.Drawing.Point(12, 172);
            this.actionFileLabel.Name = "actionFileLabel";
            this.actionFileLabel.Size = new System.Drawing.Size(142, 24);
            this.actionFileLabel.TabIndex = 14;
            this.actionFileLabel.Text = "actionFileText";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Logbook entry should be:";
            // 
            // logbookEntryLabel
            // 
            this.logbookEntryLabel.AutoSize = true;
            this.logbookEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbookEntryLabel.Location = new System.Drawing.Point(12, 255);
            this.logbookEntryLabel.Name = "logbookEntryLabel";
            this.logbookEntryLabel.Size = new System.Drawing.Size(174, 24);
            this.logbookEntryLabel.TabIndex = 16;
            this.logbookEntryLabel.Text = "logbookEntryText";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name has been copied to clipboard";
            // 
            // nextSampleButton
            // 
            this.nextSampleButton.Location = new System.Drawing.Point(166, 341);
            this.nextSampleButton.Name = "nextSampleButton";
            this.nextSampleButton.Size = new System.Drawing.Size(159, 52);
            this.nextSampleButton.TabIndex = 18;
            this.nextSampleButton.Text = "Next Sample";
            this.nextSampleButton.UseVisualStyleBackColor = true;
            this.nextSampleButton.Click += new System.EventHandler(this.nextSampleButton_Click);
            // 
            // ActionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.nextSampleButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logbookEntryLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actionFileLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsButton);
            this.Name = "ActionWindow";
            this.Text = "Filename Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label actionFileLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label logbookEntryLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextSampleButton;
    }
}