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
            this.calistirBut = new System.Windows.Forms.Button();
            this.pBarCalis = new System.Windows.Forms.ProgressBar();
            this.girdiDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.metinTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.girdiPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.forceSt = new System.Windows.Forms.CheckBox();
            this.shiftCheck = new System.Windows.Forms.CheckBox();
            this.girdiBut = new System.Windows.Forms.Button();
            this.ciktiDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.girdiPBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ciktiPath = new System.Windows.Forms.TextBox();
            this.ciktiPBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.privateCheck = new System.Windows.Forms.CheckBox();
            this.indexX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.indexY = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.girdiPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciktiPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // calistirBut
            // 
            this.calistirBut.Location = new System.Drawing.Point(613, 458);
            this.calistirBut.Name = "calistirBut";
            this.calistirBut.Size = new System.Drawing.Size(91, 39);
            this.calistirBut.TabIndex = 0;
            this.calistirBut.Text = "İşle";
            this.calistirBut.UseVisualStyleBackColor = true;
            this.calistirBut.Click += new System.EventHandler(this.calistirBut_Click);
            // 
            // pBarCalis
            // 
            this.pBarCalis.Location = new System.Drawing.Point(180, 458);
            this.pBarCalis.Name = "pBarCalis";
            this.pBarCalis.Size = new System.Drawing.Size(322, 39);
            this.pBarCalis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "İşlenecek metin ifadesi:";
            // 
            // metinTBox
            // 
            this.metinTBox.Location = new System.Drawing.Point(353, 73);
            this.metinTBox.Multiline = true;
            this.metinTBox.Name = "metinTBox";
            this.metinTBox.Size = new System.Drawing.Size(351, 85);
            this.metinTBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "String ifadenin işleneceği resim dosyasının konumu:";
            // 
            // girdiPath
            // 
            this.girdiPath.Location = new System.Drawing.Point(353, 180);
            this.girdiPath.Name = "girdiPath";
            this.girdiPath.Size = new System.Drawing.Size(270, 22);
            this.girdiPath.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.indexY);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.indexX);
            this.groupBox1.Controls.Add(this.privateCheck);
            this.groupBox1.Controls.Add(this.forceSt);
            this.groupBox1.Controls.Add(this.shiftCheck);
            this.groupBox1.Location = new System.Drawing.Point(246, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 157);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçenekler";
            // 
            // forceSt
            // 
            this.forceSt.AutoSize = true;
            this.forceSt.Location = new System.Drawing.Point(7, 48);
            this.forceSt.Name = "forceSt";
            this.forceSt.Size = new System.Drawing.Size(227, 20);
            this.forceSt.TabIndex = 1;
            this.forceSt.Text = "Metin boyutu fazla ise zorla şifrele";
            this.forceSt.UseVisualStyleBackColor = true;
            // 
            // shiftCheck
            // 
            this.shiftCheck.AutoSize = true;
            this.shiftCheck.Location = new System.Drawing.Point(7, 22);
            this.shiftCheck.Name = "shiftCheck";
            this.shiftCheck.Size = new System.Drawing.Size(254, 20);
            this.shiftCheck.TabIndex = 0;
            this.shiftCheck.Text = "İşlemden önce metni şifrele (Sezar ile)";
            this.shiftCheck.UseVisualStyleBackColor = true;
            // 
            // girdiBut
            // 
            this.girdiBut.Location = new System.Drawing.Point(629, 180);
            this.girdiBut.Name = "girdiBut";
            this.girdiBut.Size = new System.Drawing.Size(75, 22);
            this.girdiBut.TabIndex = 10;
            this.girdiBut.Text = "Gözat";
            this.girdiBut.UseVisualStyleBackColor = true;
            this.girdiBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // girdiPBox
            // 
            this.girdiPBox.Location = new System.Drawing.Point(735, 73);
            this.girdiPBox.Name = "girdiPBox";
            this.girdiPBox.Size = new System.Drawing.Size(363, 246);
            this.girdiPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.girdiPBox.TabIndex = 12;
            this.girdiPBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(452, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Metin uzunluğuna ve imajın çözünürlüğüne bağlı olarak işlem uzun sürebilir...";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Çıktı konumu:";
            // 
            // ciktiPath
            // 
            this.ciktiPath.Location = new System.Drawing.Point(353, 220);
            this.ciktiPath.Name = "ciktiPath";
            this.ciktiPath.ReadOnly = true;
            this.ciktiPath.Size = new System.Drawing.Size(270, 22);
            this.ciktiPath.TabIndex = 8;
            // 
            // ciktiPBox
            // 
            this.ciktiPBox.Location = new System.Drawing.Point(1153, 73);
            this.ciktiPBox.Name = "ciktiPBox";
            this.ciktiPBox.Size = new System.Drawing.Size(363, 246);
            this.ciktiPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ciktiPBox.TabIndex = 15;
            this.ciktiPBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(885, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Girdi resim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1308, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Çıktı resim";
            // 
            // privateCheck
            // 
            this.privateCheck.AutoSize = true;
            this.privateCheck.Location = new System.Drawing.Point(7, 74);
            this.privateCheck.Name = "privateCheck";
            this.privateCheck.Size = new System.Drawing.Size(219, 20);
            this.privateCheck.TabIndex = 2;
            this.privateCheck.Text = "Şifreleme için private key kullan ";
            this.privateCheck.UseVisualStyleBackColor = true;
            this.privateCheck.CheckedChanged += new System.EventHandler(this.privateCheck_CheckedChanged);
            // 
            // indexX
            // 
            this.indexX.Location = new System.Drawing.Point(252, 72);
            this.indexX.Name = "indexX";
            this.indexX.ReadOnly = true;
            this.indexX.Size = new System.Drawing.Size(45, 22);
            this.indexX.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Y:";
            // 
            // indexY
            // 
            this.indexY.Location = new System.Drawing.Point(332, 72);
            this.indexY.Name = "indexY";
            this.indexY.ReadOnly = true;
            this.indexY.Size = new System.Drawing.Size(45, 22);
            this.indexY.TabIndex = 20;
            // 
            // Sifrele
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1549, 579);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ciktiPBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.girdiPBox);
            this.Controls.Add(this.girdiBut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ciktiPath);
            this.Controls.Add(this.girdiPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metinTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBarCalis);
            this.Controls.Add(this.calistirBut);
            this.Name = "Sifrele";
            this.Text = "Şifrele";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.girdiPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciktiPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calistirBut;
        private System.Windows.Forms.ProgressBar pBarCalis;
        private System.Windows.Forms.FolderBrowserDialog girdiDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox metinTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox girdiPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button girdiBut;
        private System.Windows.Forms.FolderBrowserDialog ciktiDialog;
        private System.Windows.Forms.PictureBox girdiPBox;
        private System.Windows.Forms.CheckBox shiftCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ciktiPath;
        private System.Windows.Forms.PictureBox ciktiPBox;
        private System.Windows.Forms.CheckBox forceSt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox privateCheck;
        private System.Windows.Forms.TextBox indexX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox indexY;
        private System.Windows.Forms.Label label7;
    }
}

