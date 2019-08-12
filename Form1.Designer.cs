namespace current_caculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtVoltage = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtR4 = new System.Windows.Forms.TextBox();
            this.txtR3 = new System.Windows.Forms.TextBox();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(257, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "caculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtVoltage
            // 
            this.txtVoltage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtVoltage.Location = new System.Drawing.Point(666, 391);
            this.txtVoltage.Name = "txtVoltage";
            this.txtVoltage.Size = new System.Drawing.Size(100, 28);
            this.txtVoltage.TabIndex = 2;
            this.txtVoltage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtVoltage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoltage_KeyPress);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(257, 341);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(132, 22);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Circuit One";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(528, 341);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 22);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Circuit Two";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtR4
            // 
            this.txtR4.Location = new System.Drawing.Point(433, 440);
            this.txtR4.Name = "txtR4";
            this.txtR4.Size = new System.Drawing.Size(100, 28);
            this.txtR4.TabIndex = 5;
            this.txtR4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtR4_KeyPress);
            // 
            // txtR3
            // 
            this.txtR3.Location = new System.Drawing.Point(236, 440);
            this.txtR3.Name = "txtR3";
            this.txtR3.Size = new System.Drawing.Size(100, 28);
            this.txtR3.TabIndex = 6;
            this.txtR3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtR3_KeyPress);
            // 
            // txtR2
            // 
            this.txtR2.Location = new System.Drawing.Point(433, 391);
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(100, 28);
            this.txtR2.TabIndex = 7;
            this.txtR2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtR2_KeyPress);
            // 
            // txtR1
            // 
            this.txtR1.Location = new System.Drawing.Point(236, 391);
            this.txtR1.Name = "txtR1";
            this.txtR1.Size = new System.Drawing.Size(100, 28);
            this.txtR1.TabIndex = 8;
            this.txtR1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtR1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "voltage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "R1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "R2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "R3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "R4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(186, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(772, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ω";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(539, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ω";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ω";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(539, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ω";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(293, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 659);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtR1);
            this.Controls.Add(this.txtR2);
            this.Controls.Add(this.txtR3);
            this.Controls.Add(this.txtR4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtVoltage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtVoltage;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtR4;
        private System.Windows.Forms.TextBox txtR3;
        private System.Windows.Forms.TextBox txtR2;
        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

