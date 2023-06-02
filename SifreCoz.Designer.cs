namespace Steganografi
{
    partial class SifreCoz
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.indexY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.indexX = new System.Windows.Forms.TextBox();
            this.privateCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "Gözat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(365, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 22);
            this.textBox2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "String ifadenin getireleceği resim dosyasının konumu:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(365, 162);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(351, 186);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gizlenmiş metin:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(603, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "Şifre Çöz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Y:";
            // 
            // indexY
            // 
            this.indexY.Location = new System.Drawing.Point(459, 109);
            this.indexY.Name = "indexY";
            this.indexY.ReadOnly = true;
            this.indexY.Size = new System.Drawing.Size(45, 22);
            this.indexY.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "X:";
            // 
            // indexX
            // 
            this.indexX.Location = new System.Drawing.Point(379, 109);
            this.indexX.Name = "indexX";
            this.indexX.ReadOnly = true;
            this.indexX.Size = new System.Drawing.Size(45, 22);
            this.indexX.TabIndex = 23;
            // 
            // privateCheck
            // 
            this.privateCheck.AutoSize = true;
            this.privateCheck.Location = new System.Drawing.Point(134, 111);
            this.privateCheck.Name = "privateCheck";
            this.privateCheck.Size = new System.Drawing.Size(219, 20);
            this.privateCheck.TabIndex = 22;
            this.privateCheck.Text = "Şifreleme için private key kullan ";
            this.privateCheck.UseVisualStyleBackColor = true;
            this.privateCheck.CheckedChanged += new System.EventHandler(this.privateCheck_CheckedChanged);
            // 
            // SifreCoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 394);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.indexY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.indexX);
            this.Controls.Add(this.privateCheck);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "SifreCoz";
            this.Text = "SifreCoz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SifreCoz_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SifreCoz_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox indexY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox indexX;
        private System.Windows.Forms.CheckBox privateCheck;
    }
}