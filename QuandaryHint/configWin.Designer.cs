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
            this.fontAdjuster = new System.Windows.Forms.NumericUpDown();
            this.fontAdjustLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.configKB = new System.Windows.Forms.Label();
            this.psychButton = new System.Windows.Forms.Button();
            this.audioSetterBox = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.volumeSlider = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.minAdjust = new System.Windows.Forms.NumericUpDown();
            this.secAdjust = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fontAdjuster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAdjust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secAdjust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // fontAdjuster
            // 
            this.fontAdjuster.Location = new System.Drawing.Point(589, 109);
            this.fontAdjuster.Name = "fontAdjuster";
            this.fontAdjuster.Size = new System.Drawing.Size(120, 31);
            this.fontAdjuster.TabIndex = 0;
            this.fontAdjuster.ValueChanged += new System.EventHandler(this.fontAdjuster_ValueChanged);
            // 
            // fontAdjustLabel
            // 
            this.fontAdjustLabel.AutoSize = true;
            this.fontAdjustLabel.Location = new System.Drawing.Point(584, 81);
            this.fontAdjustLabel.Name = "fontAdjustLabel";
            this.fontAdjustLabel.Size = new System.Drawing.Size(159, 25);
            this.fontAdjustLabel.TabIndex = 1;
            this.fontAdjustLabel.Text = "Adjust font size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keyboard Shortcuts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ctrl + B Toggle hint border";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ctrl + R Remove current hint";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Shift + Enter Silent hint push";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ctrl + W Reset Game";
            // 
            // configKB
            // 
            this.configKB.AutoSize = true;
            this.configKB.Font = new System.Drawing.Font("Ailerons", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configKB.Location = new System.Drawing.Point(330, 9);
            this.configKB.Name = "configKB";
            this.configKB.Size = new System.Drawing.Size(124, 25);
            this.configKB.TabIndex = 7;
            this.configKB.Text = "Test Edit";
            // 
            // psychButton
            // 
            this.psychButton.Location = new System.Drawing.Point(468, 192);
            this.psychButton.Name = "psychButton";
            this.psychButton.Size = new System.Drawing.Size(157, 62);
            this.psychButton.TabIndex = 8;
            this.psychButton.Text = "toggle psych";
            this.psychButton.UseVisualStyleBackColor = true;
            this.psychButton.Click += new System.EventHandler(this.psychButton_Click);
            // 
            // audioSetterBox
            // 
            this.audioSetterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audioSetterBox.FormattingEnabled = true;
            this.audioSetterBox.Location = new System.Drawing.Point(731, 221);
            this.audioSetterBox.Name = "audioSetterBox";
            this.audioSetterBox.Size = new System.Drawing.Size(242, 33);
            this.audioSetterBox.TabIndex = 9;
            this.audioSetterBox.SelectedIndexChanged += new System.EventHandler(this.audioSetterBox_SelectedIndexChanged);
            this.audioSetterBox.Click += new System.EventHandler(this.audioSetterBox_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(368, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 29);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Capture Input";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // volumeSlider
            // 
            this.volumeSlider.Location = new System.Drawing.Point(-2, 221);
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(173, 90);
            this.volumeSlider.TabIndex = 11;
            this.volumeSlider.Value = 10;
            this.volumeSlider.ValueChanged += new System.EventHandler(this.volumeSlider_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(589, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // minAdjust
            // 
            this.minAdjust.Location = new System.Drawing.Point(758, 108);
            this.minAdjust.Name = "minAdjust";
            this.minAdjust.Size = new System.Drawing.Size(56, 31);
            this.minAdjust.TabIndex = 13;
            // 
            // secAdjust
            // 
            this.secAdjust.Location = new System.Drawing.Point(820, 107);
            this.secAdjust.Name = "secAdjust";
            this.secAdjust.Size = new System.Drawing.Size(72, 31);
            this.secAdjust.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(753, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Minutes | Seconds";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add time";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-7, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Boop";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Video Sound";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(193, 221);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown2.TabIndex = 20;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // configWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 266);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.secAdjust);
            this.Controls.Add(this.minAdjust);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.audioSetterBox);
            this.Controls.Add(this.psychButton);
            this.Controls.Add(this.configKB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fontAdjustLabel);
            this.Controls.Add(this.fontAdjuster);
            this.Name = "configWin";
            this.Text = "configWin";
            ((System.ComponentModel.ISupportInitialize)(this.fontAdjuster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAdjust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secAdjust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown fontAdjuster;
        private System.Windows.Forms.Label fontAdjustLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button psychButton;
        public System.Windows.Forms.Label configKB;
        private System.Windows.Forms.ComboBox audioSetterBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar volumeSlider;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown minAdjust;
        private System.Windows.Forms.NumericUpDown secAdjust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}