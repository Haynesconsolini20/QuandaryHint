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
            this.hintPusher = new System.Windows.Forms.Button();
            this.hintEntry = new System.Windows.Forms.TextBox();
            this.hintToggler = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.audioToggle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hintCounter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.showHintWin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.adjustBtn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.easyStartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hintCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // hintPusher
            // 
            this.hintPusher.Location = new System.Drawing.Point(131, 29);
            this.hintPusher.Name = "hintPusher";
            this.hintPusher.Size = new System.Drawing.Size(129, 66);
            this.hintPusher.TabIndex = 0;
            this.hintPusher.Text = "Push Hint";
            this.hintPusher.UseVisualStyleBackColor = true;
            this.hintPusher.Click += new System.EventHandler(this.button1_Click);
            // 
            // hintEntry
            // 
            this.hintEntry.Location = new System.Drawing.Point(264, 163);
            this.hintEntry.Multiline = true;
            this.hintEntry.Name = "hintEntry";
            this.hintEntry.Size = new System.Drawing.Size(436, 171);
            this.hintEntry.TabIndex = 1;
            // 
            // hintToggler
            // 
            this.hintToggler.Location = new System.Drawing.Point(536, 29);
            this.hintToggler.Name = "hintToggler";
            this.hintToggler.Size = new System.Drawing.Size(129, 66);
            this.hintToggler.TabIndex = 2;
            this.hintToggler.Text = "Hint border";
            this.hintToggler.UseVisualStyleBackColor = true;
            this.hintToggler.Click += new System.EventHandler(this.hintToggler_Click);
            // 
            // configButton
            // 
            this.configButton.Location = new System.Drawing.Point(266, 29);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(129, 66);
            this.configButton.TabIndex = 3;
            this.configButton.Text = "Edit Config";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // audioToggle
            // 
            this.audioToggle.AutoSize = true;
            this.audioToggle.Location = new System.Drawing.Point(30, 341);
            this.audioToggle.Name = "audioToggle";
            this.audioToggle.Size = new System.Drawing.Size(171, 29);
            this.audioToggle.TabIndex = 4;
            this.audioToggle.Text = "Toggle Audio";
            this.audioToggle.UseVisualStyleBackColor = true;
            this.audioToggle.CheckStateChanged += new System.EventHandler(this.audioToggle_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "This can be useful for consecutive hints with a \"walkthrough\" group";
            // 
            // hintCounter
            // 
            this.hintCounter.Location = new System.Drawing.Point(706, 305);
            this.hintCounter.Name = "hintCounter";
            this.hintCounter.Size = new System.Drawing.Size(64, 31);
            this.hintCounter.TabIndex = 6;
            this.hintCounter.ValueChanged += new System.EventHandler(this.hintCounter_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hint Counter";
            // 
            // showHintWin
            // 
            this.showHintWin.Location = new System.Drawing.Point(401, 29);
            this.showHintWin.Name = "showHintWin";
            this.showHintWin.Size = new System.Drawing.Size(129, 66);
            this.showHintWin.TabIndex = 8;
            this.showHintWin.Text = "Open Hintwin";
            this.showHintWin.UseVisualStyleBackColor = true;
            this.showHintWin.Click += new System.EventHandler(this.showHintWin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(894, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 72);
            this.button1.TabIndex = 9;
            this.button1.Text = "open video";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(892, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 75);
            this.button2.TabIndex = 10;
            this.button2.Text = "Video border";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(892, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 75);
            this.button3.TabIndex = 12;
            this.button3.Text = "Start Video";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 87);
            this.button4.TabIndex = 13;
            this.button4.Text = "Align hints";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 51);
            this.button5.TabIndex = 14;
            this.button5.Text = "Play/Pause";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // adjustBtn
            // 
            this.adjustBtn.Location = new System.Drawing.Point(892, 161);
            this.adjustBtn.Name = "adjustBtn";
            this.adjustBtn.Size = new System.Drawing.Size(128, 72);
            this.adjustBtn.TabIndex = 15;
            this.adjustBtn.Text = "Adjust video";
            this.adjustBtn.UseVisualStyleBackColor = true;
            this.adjustBtn.Click += new System.EventHandler(this.adjustBtn_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(168, 113);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 44);
            this.button6.TabIndex = 16;
            this.button6.Text = "boop";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 227);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(138, 72);
            this.button7.TabIndex = 17;
            this.button7.Text = "Escape!";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // easyStartBtn
            // 
            this.easyStartBtn.Location = new System.Drawing.Point(706, 51);
            this.easyStartBtn.Name = "easyStartBtn";
            this.easyStartBtn.Size = new System.Drawing.Size(132, 65);
            this.easyStartBtn.TabIndex = 18;
            this.easyStartBtn.Text = "Baby button";
            this.easyStartBtn.UseVisualStyleBackColor = true;
            this.easyStartBtn.Click += new System.EventHandler(this.easyStartBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1032, 407);
            this.Controls.Add(this.easyStartBtn);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.adjustBtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showHintWin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hintCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.audioToggle);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.hintToggler);
            this.Controls.Add(this.hintEntry);
            this.Controls.Add(this.hintPusher);
            this.KeyPreview = true;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.hintCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hintPusher;
        private System.Windows.Forms.TextBox hintEntry;
        private System.Windows.Forms.Button hintToggler;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.CheckBox audioToggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown hintCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showHintWin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button adjustBtn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button easyStartBtn;
    }
}

