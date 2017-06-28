namespace Color_Coder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtHexa = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRN = new System.Windows.Forms.Label();
            this.labelGN = new System.Windows.Forms.Label();
            this.labelBN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRG = new System.Windows.Forms.Label();
            this.labelGG = new System.Windows.Forms.Label();
            this.labelBG = new System.Windows.Forms.Label();
            this.numericUpDownR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownG = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.lblShow = new System.Windows.Forms.Label();
            this.lstCol = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHexa
            // 
            this.txtHexa.Location = new System.Drawing.Point(37, 62);
            this.txtHexa.MaxLength = 6;
            this.txtHexa.Name = "txtHexa";
            this.txtHexa.Size = new System.Drawing.Size(78, 20);
            this.txtHexa.TabIndex = 0;
            this.txtHexa.TextChanged += new System.EventHandler(this.txtHexa_TextChanged);
            // 
            // btnRun
            // 
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Jokerman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.Black;
            this.btnRun.Location = new System.Drawing.Point(53, 23);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(99, 25);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "RUN!!";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(261, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 193);
            this.panel1.TabIndex = 5;
            // 
            // labelRN
            // 
            this.labelRN.AutoSize = true;
            this.labelRN.BackColor = System.Drawing.Color.Transparent;
            this.labelRN.Location = new System.Drawing.Point(13, 97);
            this.labelRN.Name = "labelRN";
            this.labelRN.Size = new System.Drawing.Size(18, 13);
            this.labelRN.TabIndex = 3;
            this.labelRN.Text = "R:";
            // 
            // labelGN
            // 
            this.labelGN.AutoSize = true;
            this.labelGN.BackColor = System.Drawing.Color.Transparent;
            this.labelGN.Location = new System.Drawing.Point(13, 134);
            this.labelGN.Name = "labelGN";
            this.labelGN.Size = new System.Drawing.Size(18, 13);
            this.labelGN.TabIndex = 3;
            this.labelGN.Text = "G:";
            // 
            // labelBN
            // 
            this.labelBN.AutoSize = true;
            this.labelBN.BackColor = System.Drawing.Color.Transparent;
            this.labelBN.Location = new System.Drawing.Point(13, 167);
            this.labelBN.Name = "labelBN";
            this.labelBN.Size = new System.Drawing.Size(17, 13);
            this.labelBN.TabIndex = 3;
            this.labelBN.Text = "B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "#";
            // 
            // labelRG
            // 
            this.labelRG.AutoSize = true;
            this.labelRG.ForeColor = System.Drawing.Color.Red;
            this.labelRG.Location = new System.Drawing.Point(122, 97);
            this.labelRG.Name = "labelRG";
            this.labelRG.Size = new System.Drawing.Size(115, 13);
            this.labelRG.TabIndex = 6;
            this.labelRG.Text = "Must be Less than 255";
            this.labelRG.Visible = false;
            // 
            // labelGG
            // 
            this.labelGG.AutoSize = true;
            this.labelGG.ForeColor = System.Drawing.Color.Red;
            this.labelGG.Location = new System.Drawing.Point(122, 131);
            this.labelGG.Name = "labelGG";
            this.labelGG.Size = new System.Drawing.Size(115, 13);
            this.labelGG.TabIndex = 6;
            this.labelGG.Text = "Must be Less than 255";
            this.labelGG.Visible = false;
            // 
            // labelBG
            // 
            this.labelBG.AutoSize = true;
            this.labelBG.ForeColor = System.Drawing.Color.Red;
            this.labelBG.Location = new System.Drawing.Point(122, 167);
            this.labelBG.Name = "labelBG";
            this.labelBG.Size = new System.Drawing.Size(115, 13);
            this.labelBG.TabIndex = 6;
            this.labelBG.Text = "Must be Less than 255";
            this.labelBG.Visible = false;
            // 
            // numericUpDownR
            // 
            this.numericUpDownR.Location = new System.Drawing.Point(37, 95);
            this.numericUpDownR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownR.Name = "numericUpDownR";
            this.numericUpDownR.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownR.TabIndex = 7;
            this.numericUpDownR.ValueChanged += new System.EventHandler(this.numericUpDownR_ValueChange);
            // 
            // numericUpDownG
            // 
            this.numericUpDownG.Location = new System.Drawing.Point(37, 132);
            this.numericUpDownG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownG.Name = "numericUpDownG";
            this.numericUpDownG.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownG.TabIndex = 7;
            this.numericUpDownG.ValueChanged += new System.EventHandler(this.numericUpDownG_ValueChange);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(37, 165);
            this.numericUpDownB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownB.TabIndex = 7;
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.numericUpDownB_ValueChange);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.BackColor = System.Drawing.Color.Transparent;
            this.lblShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(258, 268);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(90, 15);
            this.lblShow.TabIndex = 8;
            this.lblShow.Text = "Show History";
            this.lblShow.Visible = false;
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // lstCol
            // 
            this.lstCol.BackColor = System.Drawing.Color.LightGray;
            this.lstCol.FormattingEnabled = true;
            this.lstCol.Location = new System.Drawing.Point(454, 62);
            this.lstCol.Name = "lstCol";
            this.lstCol.Size = new System.Drawing.Size(58, 186);
            this.lstCol.TabIndex = 9;
            this.lstCol.Visible = false;
            this.lstCol.SelectedIndexChanged += new System.EventHandler(this.lstCol_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRun);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 92);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Random Colors";
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Jokerman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(117, 61);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 25);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Jokerman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.Black;
            this.btnPrev.Location = new System.Drawing.Point(6, 61);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(99, 25);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "PREVIOUS";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Visible = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "C";
            this.label2.Click += new System.EventHandler(this.aboutMe);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Location = new System.Drawing.Point(118, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 44);
            this.label3.TabIndex = 11;
            this.label3.Text = "O";
            this.label3.Click += new System.EventHandler(this.aboutMe);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(41)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(154, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 44);
            this.label4.TabIndex = 11;
            this.label4.Text = "L";
            this.label4.Click += new System.EventHandler(this.aboutMe);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(198)))), ((int)(((byte)(57)))));
            this.label5.Location = new System.Drawing.Point(186, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 44);
            this.label5.TabIndex = 11;
            this.label5.Text = "O";
            this.label5.Click += new System.EventHandler(this.aboutMe);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.BurlyWood;
            this.label6.Location = new System.Drawing.Point(223, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 44);
            this.label6.TabIndex = 11;
            this.label6.Text = "R";
            this.label6.Click += new System.EventHandler(this.aboutMe);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(285, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 44);
            this.label7.TabIndex = 11;
            this.label7.Text = "C";
            this.label7.Click += new System.EventHandler(this.aboutMe);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(318, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 44);
            this.label8.TabIndex = 11;
            this.label8.Text = "O";
            this.label8.Click += new System.EventHandler(this.aboutMe);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MistyRose;
            this.label9.Location = new System.Drawing.Point(394, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 44);
            this.label9.TabIndex = 11;
            this.label9.Text = "E";
            this.label9.Click += new System.EventHandler(this.aboutMe);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Cambria", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(357, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 44);
            this.label10.TabIndex = 11;
            this.label10.Text = "D";
            this.label10.Click += new System.EventHandler(this.aboutMe);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.aboutMe);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(525, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstCol);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.numericUpDownG);
            this.Controls.Add(this.numericUpDownR);
            this.Controls.Add(this.labelBG);
            this.Controls.Add(this.labelGG);
            this.Controls.Add(this.labelRG);
            this.Controls.Add(this.labelBN);
            this.Controls.Add(this.labelGN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtHexa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(541, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(541, 350);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHexa;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRN;
        private System.Windows.Forms.Label labelGN;
        private System.Windows.Forms.Label labelBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRG;
        private System.Windows.Forms.Label labelGG;
        private System.Windows.Forms.Label labelBG;
        private System.Windows.Forms.NumericUpDown numericUpDownR;
        private System.Windows.Forms.NumericUpDown numericUpDownG;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.ListBox lstCol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

