namespace TobiiFormApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.label_beta = new System.Windows.Forms.Label();
            this.label_mincutoff = new System.Windows.Forms.Label();
            this.label_alpha = new System.Windows.Forms.Label();
            this.textBox_beta = new System.Windows.Forms.TextBox();
            this.textBox_mincutoff = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_alpha = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_enter);
            this.groupBox1.Controls.Add(this.label_beta);
            this.groupBox1.Controls.Add(this.label_mincutoff);
            this.groupBox1.Controls.Add(this.label_alpha);
            this.groupBox1.Controls.Add(this.textBox_beta);
            this.groupBox1.Controls.Add(this.textBox_mincutoff);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_alpha);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(17, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gaze Smooth Filter";
            // 
            // button_enter
            // 
            this.button_enter.Location = new System.Drawing.Point(222, 78);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(75, 23);
            this.button_enter.TabIndex = 13;
            this.button_enter.Text = "Enter";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_beta
            // 
            this.label_beta.AutoSize = true;
            this.label_beta.Location = new System.Drawing.Point(169, 133);
            this.label_beta.Name = "label_beta";
            this.label_beta.Size = new System.Drawing.Size(27, 12);
            this.label_beta.TabIndex = 12;
            this.label_beta.Text = "0.03";
            // 
            // label_mincutoff
            // 
            this.label_mincutoff.AutoSize = true;
            this.label_mincutoff.Location = new System.Drawing.Point(169, 106);
            this.label_mincutoff.Name = "label_mincutoff";
            this.label_mincutoff.Size = new System.Drawing.Size(33, 12);
            this.label_mincutoff.TabIndex = 11;
            this.label_mincutoff.Text = "0.007";
            // 
            // label_alpha
            // 
            this.label_alpha.AutoSize = true;
            this.label_alpha.Location = new System.Drawing.Point(169, 54);
            this.label_alpha.Name = "label_alpha";
            this.label_alpha.Size = new System.Drawing.Size(21, 12);
            this.label_alpha.TabIndex = 10;
            this.label_alpha.Text = "0.3";
            // 
            // textBox_beta
            // 
            this.textBox_beta.Location = new System.Drawing.Point(86, 130);
            this.textBox_beta.Name = "textBox_beta";
            this.textBox_beta.Size = new System.Drawing.Size(77, 21);
            this.textBox_beta.TabIndex = 9;
            this.textBox_beta.Text = "0.03";
            // 
            // textBox_mincutoff
            // 
            this.textBox_mincutoff.Location = new System.Drawing.Point(86, 103);
            this.textBox_mincutoff.Name = "textBox_mincutoff";
            this.textBox_mincutoff.Size = new System.Drawing.Size(77, 21);
            this.textBox_mincutoff.TabIndex = 8;
            this.textBox_mincutoff.Text = "0.007";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "beta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "min_cutoff:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "alpha:";
            // 
            // textBox_alpha
            // 
            this.textBox_alpha.Location = new System.Drawing.Point(86, 51);
            this.textBox_alpha.Name = "textBox_alpha";
            this.textBox_alpha.Size = new System.Drawing.Size(77, 21);
            this.textBox_alpha.TabIndex = 4;
            this.textBox_alpha.Text = "0.3";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 78);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(66, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "1 EURO";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 209);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Unfiltered";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 176);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(124, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Weighted Average";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Alpha";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gaze Point X: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gaze Point Y: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Toggle gaze mouse control";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Unix Millisecond:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 422);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tobii filter_verSID";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton radioButton4;
        public System.Windows.Forms.RadioButton radioButton3;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBox_alpha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBox_beta;
        public System.Windows.Forms.TextBox textBox_mincutoff;
        public System.Windows.Forms.Label label_beta;
        public System.Windows.Forms.Label label_mincutoff;
        public System.Windows.Forms.Label label_alpha;
        public System.Windows.Forms.Button button_enter;
    }
}

