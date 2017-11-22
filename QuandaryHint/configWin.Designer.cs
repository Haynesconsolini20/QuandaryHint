namespace QuandaryHint
{
    partial class configWin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.audioSetterBox = new System.Windows.Forms.ComboBox();
            this.minAdjust = new System.Windows.Forms.NumericUpDown();
            this.secAdjust = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.AddTimeBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.VideoSoundUpDown = new System.Windows.Forms.NumericUpDown();
            this.HintSoundUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.SubtractTimeBtn = new System.Windows.Forms.Button();
            this.ExcelWriteBtn = new System.Windows.Forms.Button();
            this.SNQBtn = new System.Windows.Forms.Button();
            this.FontAdjuster = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minAdjust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secAdjust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoSoundUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HintSoundUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontAdjuster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keyboard Shortcuts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ctrl + B Toggle hint border";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ctrl + R Remove current hint";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Shift + Enter Silent hint push";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ctrl + W Reset Game";
            // 
            // audioSetterBox
            // 
            this.audioSetterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audioSetterBox.FormattingEnabled = true;
            this.audioSetterBox.Location = new System.Drawing.Point(249, 106);
            this.audioSetterBox.Margin = new System.Windows.Forms.Padding(2);
            this.audioSetterBox.Name = "audioSetterBox";
            this.audioSetterBox.Size = new System.Drawing.Size(123, 21);
            this.audioSetterBox.TabIndex = 9;
            this.audioSetterBox.SelectedIndexChanged += new System.EventHandler(this.audioSetterBox_SelectedIndexChanged);
            this.audioSetterBox.Click += new System.EventHandler(this.audioSetterBox_Click);
            // 
            // minAdjust
            // 
            this.minAdjust.Location = new System.Drawing.Point(379, 30);
            this.minAdjust.Margin = new System.Windows.Forms.Padding(2);
            this.minAdjust.Name = "minAdjust";
            this.minAdjust.Size = new System.Drawing.Size(41, 20);
            this.minAdjust.TabIndex = 13;
            // 
            // secAdjust
            // 
            this.secAdjust.Location = new System.Drawing.Point(424, 30);
            this.secAdjust.Margin = new System.Windows.Forms.Padding(2);
            this.secAdjust.Name = "secAdjust";
            this.secAdjust.Size = new System.Drawing.Size(46, 20);
            this.secAdjust.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Minutes | Seconds";
            // 
            // AddTimeBtn
            // 
            this.AddTimeBtn.Location = new System.Drawing.Point(320, 54);
            this.AddTimeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddTimeBtn.Name = "AddTimeBtn";
            this.AddTimeBtn.Size = new System.Drawing.Size(83, 24);
            this.AddTimeBtn.TabIndex = 16;
            this.AddTimeBtn.Text = "Add time";
            this.AddTimeBtn.UseVisualStyleBackColor = true;
            this.AddTimeBtn.Click += new System.EventHandler(this.AddTimeBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Audio Sound";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Video Sound";
            // 
            // VideoSoundUpDown
            // 
            this.VideoSoundUpDown.Location = new System.Drawing.Point(181, 42);
            this.VideoSoundUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.VideoSoundUpDown.Name = "VideoSoundUpDown";
            this.VideoSoundUpDown.Size = new System.Drawing.Size(60, 20);
            this.VideoSoundUpDown.TabIndex = 20;
            this.VideoSoundUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.VideoSoundUpDown.ValueChanged += new System.EventHandler(this.VideoSoundUpDown_ValueChanged);
            // 
            // HintSoundUpDown
            // 
            this.HintSoundUpDown.Location = new System.Drawing.Point(181, 81);
            this.HintSoundUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.HintSoundUpDown.Name = "HintSoundUpDown";
            this.HintSoundUpDown.Size = new System.Drawing.Size(60, 20);
            this.HintSoundUpDown.TabIndex = 21;
            this.HintSoundUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.HintSoundUpDown.ValueChanged += new System.EventHandler(this.HintSoundUpDown_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Select Audio Output";
            // 
            // SubtractTimeBtn
            // 
            this.SubtractTimeBtn.Location = new System.Drawing.Point(408, 55);
            this.SubtractTimeBtn.Name = "SubtractTimeBtn";
            this.SubtractTimeBtn.Size = new System.Drawing.Size(84, 23);
            this.SubtractTimeBtn.TabIndex = 23;
            this.SubtractTimeBtn.Text = "Subtract Time";
            this.SubtractTimeBtn.UseVisualStyleBackColor = true;
            this.SubtractTimeBtn.Click += new System.EventHandler(this.SubtractTimeBtn_Click);
            // 
            // ExcelWriteBtn
            // 
            this.ExcelWriteBtn.Location = new System.Drawing.Point(12, 115);
            this.ExcelWriteBtn.Name = "ExcelWriteBtn";
            this.ExcelWriteBtn.Size = new System.Drawing.Size(124, 23);
            this.ExcelWriteBtn.TabIndex = 24;
            this.ExcelWriteBtn.Text = "Write to Excel";
            this.ExcelWriteBtn.UseVisualStyleBackColor = true;
            this.ExcelWriteBtn.Click += new System.EventHandler(this.ExcelWriteBtn_Click);
            // 
            // SNQBtn
            // 
            this.SNQBtn.Location = new System.Drawing.Point(395, 106);
            this.SNQBtn.Name = "SNQBtn";
            this.SNQBtn.Size = new System.Drawing.Size(75, 23);
            this.SNQBtn.TabIndex = 25;
            this.SNQBtn.Text = "SnQ";
            this.SNQBtn.UseVisualStyleBackColor = true;
            this.SNQBtn.Click += new System.EventHandler(this.SNQBtn_Click);
            // 
            // FontAdjuster
            // 
            this.FontAdjuster.Location = new System.Drawing.Point(282, 16);
            this.FontAdjuster.Margin = new System.Windows.Forms.Padding(2);
            this.FontAdjuster.Name = "FontAdjuster";
            this.FontAdjuster.Size = new System.Drawing.Size(41, 20);
            this.FontAdjuster.TabIndex = 26;
            this.FontAdjuster.ValueChanged += new System.EventHandler(this.FontAdjuster_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 1);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Font Size";
            // 
            // configWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 138);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FontAdjuster);
            this.Controls.Add(this.SNQBtn);
            this.Controls.Add(this.ExcelWriteBtn);
            this.Controls.Add(this.SubtractTimeBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HintSoundUpDown);
            this.Controls.Add(this.VideoSoundUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddTimeBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.secAdjust);
            this.Controls.Add(this.minAdjust);
            this.Controls.Add(this.audioSetterBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "configWin";
            this.Text = "configWin";
            ((System.ComponentModel.ISupportInitialize)(this.minAdjust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secAdjust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoSoundUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HintSoundUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontAdjuster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox audioSetterBox;
        private System.Windows.Forms.NumericUpDown minAdjust;
        private System.Windows.Forms.NumericUpDown secAdjust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddTimeBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown VideoSoundUpDown;
        private System.Windows.Forms.NumericUpDown HintSoundUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SubtractTimeBtn;
        private System.Windows.Forms.Button ExcelWriteBtn;
        private System.Windows.Forms.Button SNQBtn;
        private System.Windows.Forms.NumericUpDown FontAdjuster;
        private System.Windows.Forms.Label label10;
    }
}