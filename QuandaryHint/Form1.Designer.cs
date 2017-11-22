namespace QuandaryHint
{
    partial class Form1
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
            this.HintPusher = new System.Windows.Forms.Button();
            this.hintEntry = new System.Windows.Forms.TextBox();
            this.configButton = new System.Windows.Forms.Button();
            this.audioToggle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hintCounter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartVideoBtn = new System.Windows.Forms.Button();
            this.AlignHintsBtn = new System.Windows.Forms.Button();
            this.PlayPauseBtn = new System.Windows.Forms.Button();
            this.HintSoundBtn = new System.Windows.Forms.Button();
            this.EscapeBtn = new System.Windows.Forms.Button();
            this.easyStartBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.CaptureInputCheckBox = new System.Windows.Forms.CheckBox();
            this.TeamNameEntry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TeamSizeEntry = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hintCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamSizeEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // HintPusher
            // 
            this.HintPusher.Location = new System.Drawing.Point(169, 15);
            this.HintPusher.Margin = new System.Windows.Forms.Padding(2);
            this.HintPusher.Name = "HintPusher";
            this.HintPusher.Size = new System.Drawing.Size(60, 34);
            this.HintPusher.TabIndex = 0;
            this.HintPusher.Text = "Push Hint";
            this.HintPusher.UseVisualStyleBackColor = true;
            this.HintPusher.Click += new System.EventHandler(this.HintPusher_Click);
            // 
            // hintEntry
            // 
            this.hintEntry.Location = new System.Drawing.Point(132, 85);
            this.hintEntry.Margin = new System.Windows.Forms.Padding(2);
            this.hintEntry.Multiline = true;
            this.hintEntry.Name = "hintEntry";
            this.hintEntry.Size = new System.Drawing.Size(220, 91);
            this.hintEntry.TabIndex = 1;
            this.hintEntry.Click += new System.EventHandler(this.hintEntry_Click);
            // 
            // configButton
            // 
            this.configButton.Location = new System.Drawing.Point(101, 15);
            this.configButton.Margin = new System.Windows.Forms.Padding(2);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(64, 34);
            this.configButton.TabIndex = 3;
            this.configButton.Text = "Edit Config";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // audioToggle
            // 
            this.audioToggle.AutoSize = true;
            this.audioToggle.Location = new System.Drawing.Point(15, 177);
            this.audioToggle.Margin = new System.Windows.Forms.Padding(2);
            this.audioToggle.Name = "audioToggle";
            this.audioToggle.Size = new System.Drawing.Size(89, 17);
            this.audioToggle.TabIndex = 4;
            this.audioToggle.Text = "Toggle Audio";
            this.audioToggle.UseVisualStyleBackColor = true;
            this.audioToggle.CheckStateChanged += new System.EventHandler(this.audioToggle_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "This can be useful for consecutive hints with a \"walkthrough\" group";
            // 
            // hintCounter
            // 
            this.hintCounter.Location = new System.Drawing.Point(353, 159);
            this.hintCounter.Margin = new System.Windows.Forms.Padding(2);
            this.hintCounter.Name = "hintCounter";
            this.hintCounter.Size = new System.Drawing.Size(32, 20);
            this.hintCounter.TabIndex = 6;
            this.hintCounter.ValueChanged += new System.EventHandler(this.hintCounter_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hint Counter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "much longer label to see";
            // 
            // StartVideoBtn
            // 
            this.StartVideoBtn.Location = new System.Drawing.Point(441, 168);
            this.StartVideoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StartVideoBtn.Name = "StartVideoBtn";
            this.StartVideoBtn.Size = new System.Drawing.Size(64, 39);
            this.StartVideoBtn.TabIndex = 12;
            this.StartVideoBtn.Text = "Start Video";
            this.StartVideoBtn.UseVisualStyleBackColor = true;
            this.StartVideoBtn.Click += new System.EventHandler(this.StartVideoBtn_Click);
            // 
            // AlignHintsBtn
            // 
            this.AlignHintsBtn.Location = new System.Drawing.Point(6, 15);
            this.AlignHintsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AlignHintsBtn.Name = "AlignHintsBtn";
            this.AlignHintsBtn.Size = new System.Drawing.Size(78, 34);
            this.AlignHintsBtn.TabIndex = 13;
            this.AlignHintsBtn.Text = "Align hints";
            this.AlignHintsBtn.UseVisualStyleBackColor = true;
            this.AlignHintsBtn.Click += new System.EventHandler(this.AlignHintsBtn_Click);
            // 
            // PlayPauseBtn
            // 
            this.PlayPauseBtn.Location = new System.Drawing.Point(6, 81);
            this.PlayPauseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PlayPauseBtn.Name = "PlayPauseBtn";
            this.PlayPauseBtn.Size = new System.Drawing.Size(78, 27);
            this.PlayPauseBtn.TabIndex = 14;
            this.PlayPauseBtn.Text = "Play/Pause";
            this.PlayPauseBtn.UseVisualStyleBackColor = true;
            this.PlayPauseBtn.Click += new System.EventHandler(this.PlayPauseBtn_Click);
            // 
            // HintSoundBtn
            // 
            this.HintSoundBtn.Location = new System.Drawing.Point(309, 15);
            this.HintSoundBtn.Margin = new System.Windows.Forms.Padding(2);
            this.HintSoundBtn.Name = "HintSoundBtn";
            this.HintSoundBtn.Size = new System.Drawing.Size(66, 34);
            this.HintSoundBtn.TabIndex = 16;
            this.HintSoundBtn.Text = "boop";
            this.HintSoundBtn.UseVisualStyleBackColor = true;
            this.HintSoundBtn.Click += new System.EventHandler(this.HintSoundBtn_Click);
            // 
            // EscapeBtn
            // 
            this.EscapeBtn.Location = new System.Drawing.Point(6, 118);
            this.EscapeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EscapeBtn.Name = "EscapeBtn";
            this.EscapeBtn.Size = new System.Drawing.Size(78, 37);
            this.EscapeBtn.TabIndex = 17;
            this.EscapeBtn.Text = "Escape!";
            this.EscapeBtn.UseVisualStyleBackColor = true;
            this.EscapeBtn.Click += new System.EventHandler(this.EscapeBtn_Click);
            // 
            // easyStartBtn
            // 
            this.easyStartBtn.Location = new System.Drawing.Point(441, 130);
            this.easyStartBtn.Margin = new System.Windows.Forms.Padding(2);
            this.easyStartBtn.Name = "easyStartBtn";
            this.easyStartBtn.Size = new System.Drawing.Size(64, 34);
            this.easyStartBtn.TabIndex = 18;
            this.easyStartBtn.Text = "Initial Setup";
            this.easyStartBtn.UseVisualStyleBackColor = true;
            this.easyStartBtn.Click += new System.EventHandler(this.easyStartBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(234, 15);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(70, 34);
            this.ResetBtn.TabIndex = 19;
            this.ResetBtn.Text = "Reset Game";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // CaptureInputCheckBox
            // 
            this.CaptureInputCheckBox.AutoSize = true;
            this.CaptureInputCheckBox.Checked = true;
            this.CaptureInputCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CaptureInputCheckBox.Location = new System.Drawing.Point(413, 25);
            this.CaptureInputCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.CaptureInputCheckBox.Name = "CaptureInputCheckBox";
            this.CaptureInputCheckBox.Size = new System.Drawing.Size(90, 17);
            this.CaptureInputCheckBox.TabIndex = 20;
            this.CaptureInputCheckBox.Text = "Capture Input";
            this.CaptureInputCheckBox.UseVisualStyleBackColor = true;
            this.CaptureInputCheckBox.CheckedChanged += new System.EventHandler(this.CaptureInputCheckBox_CheckedChanged);
            // 
            // TeamNameEntry
            // 
            this.TeamNameEntry.Location = new System.Drawing.Point(413, 65);
            this.TeamNameEntry.Name = "TeamNameEntry";
            this.TeamNameEntry.Size = new System.Drawing.Size(100, 20);
            this.TeamNameEntry.TabIndex = 21;
            this.TeamNameEntry.Text = "blank";
            this.TeamNameEntry.Click += new System.EventHandler(this.TeamNameEntry_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Team Name";
            // 
            // TeamSizeEntry
            // 
            this.TeamSizeEntry.Location = new System.Drawing.Point(479, 86);
            this.TeamSizeEntry.Name = "TeamSizeEntry";
            this.TeamSizeEntry.Size = new System.Drawing.Size(34, 20);
            this.TeamSizeEntry.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Team size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(516, 212);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TeamSizeEntry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TeamNameEntry);
            this.Controls.Add(this.CaptureInputCheckBox);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.easyStartBtn);
            this.Controls.Add(this.EscapeBtn);
            this.Controls.Add(this.HintSoundBtn);
            this.Controls.Add(this.PlayPauseBtn);
            this.Controls.Add(this.AlignHintsBtn);
            this.Controls.Add(this.StartVideoBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hintCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.audioToggle);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.hintEntry);
            this.Controls.Add(this.HintPusher);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Control Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.hintCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamSizeEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HintPusher;
        private System.Windows.Forms.TextBox hintEntry;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.CheckBox audioToggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown hintCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartVideoBtn;
        private System.Windows.Forms.Button AlignHintsBtn;
        private System.Windows.Forms.Button PlayPauseBtn;
        private System.Windows.Forms.Button HintSoundBtn;
        private System.Windows.Forms.Button EscapeBtn;
        private System.Windows.Forms.Button easyStartBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.CheckBox CaptureInputCheckBox;
        private System.Windows.Forms.TextBox TeamNameEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TeamSizeEntry;
        private System.Windows.Forms.Label label5;
    }
}

