namespace _10.degiskenler_proje
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
            this.lblMisir = new System.Windows.Forms.Label();
            this.lblSu = new System.Windows.Forms.Label();
            this.lblCay = new System.Windows.Forms.Label();
            this.lblBilet = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBilet = new System.Windows.Forms.TextBox();
            this.txtCay = new System.Windows.Forms.TextBox();
            this.txtSu = new System.Windows.Forms.TextBox();
            this.txtMisir = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblKasa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbiskuvi = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMisir
            // 
            this.lblMisir.AutoSize = true;
            this.lblMisir.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMisir.Location = new System.Drawing.Point(28, 49);
            this.lblMisir.Name = "lblMisir";
            this.lblMisir.Size = new System.Drawing.Size(54, 23);
            this.lblMisir.TabIndex = 0;
            this.lblMisir.Text = "Mısır:";
            // 
            // lblSu
            // 
            this.lblSu.AutoSize = true;
            this.lblSu.Location = new System.Drawing.Point(48, 88);
            this.lblSu.Name = "lblSu";
            this.lblSu.Size = new System.Drawing.Size(34, 23);
            this.lblSu.TabIndex = 1;
            this.lblSu.Text = "Su:";
            // 
            // lblCay
            // 
            this.lblCay.AutoSize = true;
            this.lblCay.Location = new System.Drawing.Point(39, 127);
            this.lblCay.Name = "lblCay";
            this.lblCay.Size = new System.Drawing.Size(43, 23);
            this.lblCay.TabIndex = 2;
            this.lblCay.Text = "Çay:";
            // 
            // lblBilet
            // 
            this.lblBilet.AutoSize = true;
            this.lblBilet.Location = new System.Drawing.Point(34, 166);
            this.lblBilet.Name = "lblBilet";
            this.lblBilet.Size = new System.Drawing.Size(48, 23);
            this.lblBilet.TabIndex = 3;
            this.lblBilet.Text = "Bilet:";
            this.lblBilet.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.txtbiskuvi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBilet);
            this.groupBox1.Controls.Add(this.txtCay);
            this.groupBox1.Controls.Add(this.txtSu);
            this.groupBox1.Controls.Add(this.lblBilet);
            this.groupBox1.Controls.Add(this.txtMisir);
            this.groupBox1.Controls.Add(this.lblCay);
            this.groupBox1.Controls.Add(this.lblMisir);
            this.groupBox1.Controls.Add(this.lblSu);
            this.groupBox1.Location = new System.Drawing.Point(27, 313);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(282, 249);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler Miktarı";
            // 
            // txtBilet
            // 
            this.txtBilet.Location = new System.Drawing.Point(88, 163);
            this.txtBilet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBilet.Name = "txtBilet";
            this.txtBilet.Size = new System.Drawing.Size(124, 31);
            this.txtBilet.TabIndex = 8;
            // 
            // txtCay
            // 
            this.txtCay.Location = new System.Drawing.Point(88, 124);
            this.txtCay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCay.Name = "txtCay";
            this.txtCay.Size = new System.Drawing.Size(124, 31);
            this.txtCay.TabIndex = 7;
            // 
            // txtSu
            // 
            this.txtSu.Location = new System.Drawing.Point(88, 85);
            this.txtSu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(124, 31);
            this.txtSu.TabIndex = 6;
            // 
            // txtMisir
            // 
            this.txtMisir.Location = new System.Drawing.Point(88, 46);
            this.txtMisir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMisir.Name = "txtMisir";
            this.txtMisir.Size = new System.Drawing.Size(124, 31);
            this.txtMisir.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(321, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 249);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiyat Tablosu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(94, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Bilet: 30 TL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(91, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Mısır: 20 TL";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(83, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bisküvi: 14 TL";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(96, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Çay: 8 TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(106, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Su: 5 TL";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(113, 69);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(65, 23);
            this.lblToplam.TabIndex = 9;
            this.lblToplam.Text = "Toplam";
            this.lblToplam.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.lblKasa);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lblToplam);
            this.groupBox3.Location = new System.Drawing.Point(617, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 249);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kasa";
            // 
            // lblKasa
            // 
            this.lblKasa.AutoSize = true;
            this.lblKasa.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasa.Location = new System.Drawing.Point(113, 146);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(100, 23);
            this.lblKasa.TabIndex = 15;
            this.lblKasa.Text = "Kasa:  00 TL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Khaki;
            this.label12.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(568, 85);
            this.label12.TabIndex = 15;
            this.label12.Text = "Sinema Büfe Satıs Paneli";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(633, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bisküvi:";
            // 
            // txtbiskuvi
            // 
            this.txtbiskuvi.Location = new System.Drawing.Point(88, 199);
            this.txtbiskuvi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbiskuvi.Name = "txtbiskuvi";
            this.txtbiskuvi.Size = new System.Drawing.Size(124, 31);
            this.txtbiskuvi.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Khaki;
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(-7, -1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(924, 172);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 48);
            this.button2.TabIndex = 16;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 577);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMisir;
        private System.Windows.Forms.Label lblSu;
        private System.Windows.Forms.Label lblCay;
        private System.Windows.Forms.Label lblBilet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMisir;
        private System.Windows.Forms.TextBox txtSu;
        private System.Windows.Forms.TextBox txtBilet;
        private System.Windows.Forms.TextBox txtCay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbiskuvi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

