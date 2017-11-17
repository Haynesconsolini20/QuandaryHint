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
            ((System.ComponentModel.ISupportInitialize)(this.fontAdjuster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeSlider)).BeginInit();
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
            this.audioSetterBox.Location = new System.Drawing.Point(731, 160);
            this.audioSetterBox.Name = "audioSetterBox";
            this.audioSetterBox.Size = new System.Drawing.Size(242, 33);
            this.audioSetterBox.TabIndex = 9;
            this.audioSetterBox.SelectedIndexChanged += new System.EventHandler(this.audioSetterBox_SelectedIndexChanged);
            this.audioSetterBox.Click += new System.EventHandler(this.audioSetterBox_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(368, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(215, 29);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Keyboard Paused";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // volumeSlider
            // 
            this.volumeSlider.Location = new System.Drawing.Point(61, 208);
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(215, 90);
            this.volumeSlider.TabIndex = 11;
            this.volumeSlider.Value = 10;
            this.volumeSlider.ValueChanged += new System.EventHandler(this.volumeSlider_ValueChanged);
            // 
            // configWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 266);
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
    }
}