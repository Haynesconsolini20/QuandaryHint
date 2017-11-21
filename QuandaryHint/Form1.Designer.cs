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
            this.button4 = new System.Windows.Forms.Button();
            this.PlayPauseBtn = new System.Windows.Forms.Button();
            this.HintSoundBtn = new System.Windows.Forms.Button();
            this.EscapeBtn = new System.Windows.Forms.Button();
            this.easyStartBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hintCounter)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // StartVideoBtn
            // 
            this.StartVideoBtn.Location = new System.Drawing.Point(439, 148);
            this.StartVideoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StartVideoBtn.Name = "StartVideoBtn";
            this.StartVideoBtn.Size = new System.Drawing.Size(64, 39);
            this.StartVideoBtn.TabIndex = 12;
            this.StartVideoBtn.Text = "Start Video";
            this.StartVideoBtn.UseVisualStyleBackColor = true;
            this.StartVideoBtn.Click += new System.EventHandler(this.StartVideoBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 45);
            this.button4.TabIndex = 13;
            this.button4.Text = "Align hints";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.EscapeBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // easyStartBtn
            // 
            this.easyStartBtn.Location = new System.Drawing.Point(439, 110);
            this.easyStartBtn.Margin = new System.Windows.Forms.Padding(2);
            this.easyStartBtn.Name = "easyStartBtn";
            this.easyStartBtn.Size = new System.Drawing.Size(64, 34);
            this.easyStartBtn.TabIndex = 18;
            this.easyStartBtn.Text = "Baby button";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(516, 212);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.easyStartBtn);
            this.Controls.Add(this.EscapeBtn);
            this.Controls.Add(this.HintSoundBtn);
            this.Controls.Add(this.PlayPauseBtn);
            this.Controls.Add(this.button4);
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
            ((System.ComponentModel.ISupportInitialize)(this.hintCounter)).EndInit();
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button PlayPauseBtn;
        private System.Windows.Forms.Button HintSoundBtn;
        private System.Windows.Forms.Button EscapeBtn;
        private System.Windows.Forms.Button easyStartBtn;
        private System.Windows.Forms.Button ResetBtn;
    }
}

