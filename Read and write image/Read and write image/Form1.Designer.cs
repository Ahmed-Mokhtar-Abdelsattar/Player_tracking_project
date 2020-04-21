namespace Read_and_write_image
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chkBx_Correction = new System.Windows.Forms.CheckBox();
            this.chkBx_Player01 = new System.Windows.Forms.CheckBox();
            this.chkBx_Player02 = new System.Windows.Forms.CheckBox();
            this.btn_correct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_Player03 = new System.Windows.Forms.RadioButton();
            this.rad_Player02 = new System.Windows.Forms.RadioButton();
            this.rad_Player01 = new System.Windows.Forms.RadioButton();
            this.chkBx_Player03 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1031, 582);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1249, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1129, 661);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1249, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(12, 588);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox3_mouseClick);
            // 
            // chkBx_Correction
            // 
            this.chkBx_Correction.AutoSize = true;
            this.chkBx_Correction.Location = new System.Drawing.Point(1206, 446);
            this.chkBx_Correction.Name = "chkBx_Correction";
            this.chkBx_Correction.Size = new System.Drawing.Size(74, 17);
            this.chkBx_Correction.TabIndex = 5;
            this.chkBx_Correction.Text = "Correction";
            this.chkBx_Correction.UseVisualStyleBackColor = true;
            // 
            // chkBx_Player01
            // 
            this.chkBx_Player01.AutoSize = true;
            this.chkBx_Player01.Location = new System.Drawing.Point(1037, 446);
            this.chkBx_Player01.Name = "chkBx_Player01";
            this.chkBx_Player01.Size = new System.Drawing.Size(70, 17);
            this.chkBx_Player01.TabIndex = 6;
            this.chkBx_Player01.Text = "Player 01";
            this.chkBx_Player01.UseVisualStyleBackColor = true;
            // 
            // chkBx_Player02
            // 
            this.chkBx_Player02.AutoSize = true;
            this.chkBx_Player02.Location = new System.Drawing.Point(1037, 470);
            this.chkBx_Player02.Name = "chkBx_Player02";
            this.chkBx_Player02.Size = new System.Drawing.Size(70, 17);
            this.chkBx_Player02.TabIndex = 7;
            this.chkBx_Player02.Text = "Player 02";
            this.chkBx_Player02.UseVisualStyleBackColor = true;
            // 
            // btn_correct
            // 
            this.btn_correct.Location = new System.Drawing.Point(1206, 470);
            this.btn_correct.Name = "btn_correct";
            this.btn_correct.Size = new System.Drawing.Size(75, 23);
            this.btn_correct.TabIndex = 8;
            this.btn_correct.Text = "Correct";
            this.btn_correct.UseVisualStyleBackColor = true;
            this.btn_correct.Click += new System.EventHandler(this.btn_correct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_Player03);
            this.groupBox1.Controls.Add(this.rad_Player02);
            this.groupBox1.Controls.Add(this.rad_Player01);
            this.groupBox1.Location = new System.Drawing.Point(1037, 532);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rad_Player03
            // 
            this.rad_Player03.AutoSize = true;
            this.rad_Player03.Location = new System.Drawing.Point(6, 67);
            this.rad_Player03.Name = "rad_Player03";
            this.rad_Player03.Size = new System.Drawing.Size(69, 17);
            this.rad_Player03.TabIndex = 2;
            this.rad_Player03.TabStop = true;
            this.rad_Player03.Text = "Player 03";
            this.rad_Player03.UseVisualStyleBackColor = true;
            // 
            // rad_Player02
            // 
            this.rad_Player02.AutoSize = true;
            this.rad_Player02.Location = new System.Drawing.Point(7, 44);
            this.rad_Player02.Name = "rad_Player02";
            this.rad_Player02.Size = new System.Drawing.Size(69, 17);
            this.rad_Player02.TabIndex = 1;
            this.rad_Player02.TabStop = true;
            this.rad_Player02.Text = "Player 02";
            this.rad_Player02.UseVisualStyleBackColor = true;
            // 
            // rad_Player01
            // 
            this.rad_Player01.AutoSize = true;
            this.rad_Player01.Location = new System.Drawing.Point(7, 20);
            this.rad_Player01.Name = "rad_Player01";
            this.rad_Player01.Size = new System.Drawing.Size(69, 17);
            this.rad_Player01.TabIndex = 0;
            this.rad_Player01.TabStop = true;
            this.rad_Player01.Text = "Player 01";
            this.rad_Player01.UseVisualStyleBackColor = true;
            // 
            // chkBx_Player03
            // 
            this.chkBx_Player03.AutoSize = true;
            this.chkBx_Player03.Location = new System.Drawing.Point(1037, 494);
            this.chkBx_Player03.Name = "chkBx_Player03";
            this.chkBx_Player03.Size = new System.Drawing.Size(70, 17);
            this.chkBx_Player03.TabIndex = 10;
            this.chkBx_Player03.Text = "Player 03";
            this.chkBx_Player03.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 693);
            this.Controls.Add(this.chkBx_Player03);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_correct);
            this.Controls.Add(this.chkBx_Player02);
            this.Controls.Add(this.chkBx_Player01);
            this.Controls.Add(this.chkBx_Correction);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Read and write image";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox chkBx_Correction;
        private System.Windows.Forms.CheckBox chkBx_Player01;
        private System.Windows.Forms.CheckBox chkBx_Player02;
        private System.Windows.Forms.Button btn_correct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_Player02;
        private System.Windows.Forms.RadioButton rad_Player01;
        private System.Windows.Forms.RadioButton rad_Player03;
        private System.Windows.Forms.CheckBox chkBx_Player03;
    }
}

