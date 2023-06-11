namespace Steganografi
{
    partial class Sifrele
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ciktiDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.girdiDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ciktiPBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.girdiPBox = new System.Windows.Forms.PictureBox();
            this.girdiBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.indexY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.indexX = new System.Windows.Forms.TextBox();
            this.privateCheck = new System.Windows.Forms.CheckBox();
            this.forceSt = new System.Windows.Forms.CheckBox();
            this.shiftCheck = new System.Windows.Forms.CheckBox();
            this.ciktiPath = new System.Windows.Forms.TextBox();
            this.girdiPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metinTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBarCalis = new System.Windows.Forms.ProgressBar();
            this.calistirBut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ciktiPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girdiPBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Çıktı resim";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Girdi resim";
            this.label5.Visible = false;
            // 
            // ciktiPBox
            // 
            this.ciktiPBox.Location = new System.Drawing.Point(18, 331);
            this.ciktiPBox.Name = "ciktiPBox";
            this.ciktiPBox.Size = new System.Drawing.Size(363, 246);
            this.ciktiPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ciktiPBox.TabIndex = 45;
            this.ciktiPBox.TabStop = false;
            this.ciktiPBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Metin uzunluğuna ve imajın çözünürlüğüne bağlı olarak işlem uzun sürebilir...";
            this.label4.Visible = false;
            // 
            // girdiPBox
            // 
            this.girdiPBox.Location = new System.Drawing.Point(18, 42);
            this.girdiPBox.Name = "girdiPBox";
            this.girdiPBox.Size = new System.Drawing.Size(363, 246);
            this.girdiPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.girdiPBox.TabIndex = 43;
            this.girdiPBox.TabStop = false;
            this.girdiPBox.Visible = false;
            // 
            // girdiBut
            // 
            this.girdiBut.Location = new System.Drawing.Point(540, 152);
            this.girdiBut.Name = "girdiBut";
            this.girdiBut.Size = new System.Drawing.Size(75, 34);
            this.girdiBut.TabIndex = 42;
            this.girdiBut.Text = "Gözat";
            this.girdiBut.UseVisualStyleBackColor = true;
            this.girdiBut.Click += new System.EventHandler(this.girdiBut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.indexY);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.indexX);
            this.groupBox1.Controls.Add(this.privateCheck);
            this.groupBox1.Controls.Add(this.forceSt);
            this.groupBox1.Controls.Add(this.shiftCheck);
            this.groupBox1.Location = new System.Drawing.Point(157, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 157);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçenekler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Y:";
            // 
            // indexY
            // 
            this.indexY.Location = new System.Drawing.Point(332, 72);
            this.indexY.Name = "indexY";
            this.indexY.ReadOnly = true;
            this.indexY.Size = new System.Drawing.Size(45, 20);
            this.indexY.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "X:";
            // 
            // indexX
            // 
            this.indexX.Location = new System.Drawing.Point(252, 72);
            this.indexX.Name = "indexX";
            this.indexX.ReadOnly = true;
            this.indexX.Size = new System.Drawing.Size(45, 20);
            this.indexX.TabIndex = 18;
            // 
            // privateCheck
            // 
            this.privateCheck.AutoSize = true;
            this.privateCheck.Location = new System.Drawing.Point(7, 74);
            this.privateCheck.Name = "privateCheck";
            this.privateCheck.Size = new System.Drawing.Size(177, 17);
            this.privateCheck.TabIndex = 2;
            this.privateCheck.Text = "Şifreleme için private key kullan ";
            this.privateCheck.UseVisualStyleBackColor = true;
            // 
            // forceSt
            // 
            this.forceSt.AutoSize = true;
            this.forceSt.Location = new System.Drawing.Point(7, 48);
            this.forceSt.Name = "forceSt";
            this.forceSt.Size = new System.Drawing.Size(183, 17);
            this.forceSt.TabIndex = 1;
            this.forceSt.Text = "Metin boyutu fazla ise zorla şifrele";
            this.forceSt.UseVisualStyleBackColor = true;
            // 
            // shiftCheck
            // 
            this.shiftCheck.AutoSize = true;
            this.shiftCheck.Location = new System.Drawing.Point(7, 22);
            this.shiftCheck.Name = "shiftCheck";
            this.shiftCheck.Size = new System.Drawing.Size(202, 17);
            this.shiftCheck.TabIndex = 0;
            this.shiftCheck.Text = "İşlemden önce metni şifrele (Sezar ile)";
            this.shiftCheck.UseVisualStyleBackColor = true;
            // 
            // ciktiPath
            // 
            this.ciktiPath.Location = new System.Drawing.Point(264, 202);
            this.ciktiPath.Name = "ciktiPath";
            this.ciktiPath.ReadOnly = true;
            this.ciktiPath.Size = new System.Drawing.Size(270, 20);
            this.ciktiPath.TabIndex = 40;
            // 
            // girdiPath
            // 
            this.girdiPath.Location = new System.Drawing.Point(264, 158);
            this.girdiPath.Name = "girdiPath";
            this.girdiPath.Size = new System.Drawing.Size(270, 20);
            this.girdiPath.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Çıktı konumu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "String ifadenin işleneceği resim dosyasının konumu:";
            // 
            // metinTBox
            // 
            this.metinTBox.Location = new System.Drawing.Point(264, 45);
            this.metinTBox.Multiline = true;
            this.metinTBox.Name = "metinTBox";
            this.metinTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metinTBox.Size = new System.Drawing.Size(351, 85);
            this.metinTBox.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "İşlenecek metin ifadesi:";
            // 
            // pBarCalis
            // 
            this.pBarCalis.Location = new System.Drawing.Point(157, 459);
            this.pBarCalis.Name = "pBarCalis";
            this.pBarCalis.Size = new System.Drawing.Size(279, 33);
            this.pBarCalis.TabIndex = 34;
            // 
            // calistirBut
            // 
            this.calistirBut.Location = new System.Drawing.Point(463, 459);
            this.calistirBut.Name = "calistirBut";
            this.calistirBut.Size = new System.Drawing.Size(91, 33);
            this.calistirBut.TabIndex = 33;
            this.calistirBut.Text = "İşle";
            this.calistirBut.UseVisualStyleBackColor = true;
            this.calistirBut.Click += new System.EventHandler(this.calistirBut_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.calistirBut);
            this.panel1.Controls.Add(this.pBarCalis);
            this.panel1.Controls.Add(this.metinTBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.girdiBut);
            this.panel1.Controls.Add(this.girdiPath);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.ciktiPath);
            this.panel1.Location = new System.Drawing.Point(42, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 594);
            this.panel1.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.girdiPBox);
            this.panel2.Controls.Add(this.ciktiPBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(728, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 594);
            this.panel2.TabIndex = 22;
            this.panel2.Visible = false;
            // 
            // Sifrele
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1189, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Sifrele";
            this.Text = "Şifrele";
            ((System.ComponentModel.ISupportInitialize)(this.ciktiPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girdiPBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog ciktiDialog;
        private System.Windows.Forms.FolderBrowserDialog girdiDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ciktiPBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox girdiPBox;
        private System.Windows.Forms.Button girdiBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox indexY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox indexX;
        private System.Windows.Forms.CheckBox privateCheck;
        private System.Windows.Forms.CheckBox forceSt;
        private System.Windows.Forms.CheckBox shiftCheck;
        private System.Windows.Forms.TextBox ciktiPath;
        private System.Windows.Forms.TextBox girdiPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox metinTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pBarCalis;
        private System.Windows.Forms.Button calistirBut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

