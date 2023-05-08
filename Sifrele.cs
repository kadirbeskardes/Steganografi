using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steganografi
{
    public partial class Sifrele : Form
    {
        public Sifrele()
        {
            InitializeComponent();
        }
        static string girdi = string.Empty;
        static string cikti = string.Empty;
        static Bitmap bmp;
        static Image img;
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Resim seç";
                dlg.Filter = "Image Files(*.PNG)|*.PNG;|All files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    bmp = new Bitmap(dlg.FileName);
                    girdiPath.Text = dlg.FileName;
                    girdiPBox.ImageLocation = dlg.FileName;
                }
            }
        }
        private void calistirBut_Click(object sender, EventArgs e)
        {
            string text = metinTBox.Text;
            bool force = false;

            if (forceSt.Checked)
            {
                MessageBox.Show("Girilen metin uzunluğu bu resim dosyasının sorunsuz bir şekilde alabileceği boyutu aşıyorsa" +
                    " zorla şifreleme yapılacak. Bu normal işlemden, 5-10 saniye daha uzun sürebilir. " +
                    "Bu işlem sonucunda veri kaybı ihtimali daha düşük olabilir. Yine de oluşacak veri kaybında" +
                    " sorumluluk kabul etmiyoruz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                force=true;
            }

            if (4 * (text.Length + 3) > bmp.Width || 4 * (text.Length + 3) > bmp.Height)
            {
                DialogResult dr=MessageBox.Show("Girilen metin uzunluğu bu resim dosyasının sorunsuz bir şekilde alabileceği boyutu " +
                    "aşıyor. Metini, resim dosyasına gizlemeye devam edebilirsiniz. Fakat oluşacak veri kaybında sorumluluk " +
                    "kabul etmiyoruz. 'Metin boyutu fazla ise zorla şifrele' seçeneğini seçtiyseniz 'OK' butonuna tıklayıp " +
                    "devam edebilirsiniz. ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr!=DialogResult.OK)
                {
                    MessageBox.Show("Devam edilmedi.", "Sonuç",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            label4.Visible = true;
            pBarCalis.Visible = true;
            pBarCalis.Value = 5;
            label4.Refresh();
            
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    var pixel1 = bmp.GetPixel(i, j);
                    if (pixel1 == Color.FromArgb(0, 0, 0) || pixel1 == Color.FromArgb(1, 1, 1))
                    {
                        bmp.SetPixel(i, j, Color.FromArgb(2, 2, 2));
                    }
                }
            }
            
            byte shift = 0;
            Random rnd = new Random();
            
            if (shiftCheck.Checked)
            {
                shift = (byte)rnd.Next(15);
                //StringBuilder sb = new StringBuilder();
                //for (int i = 0; i < text.Length; i++)
                //{
                //    sb.Append((char)((int)(text[i]) + shift));
                //}
                //text = sb.ToString();
            }
            
            if (string.IsNullOrEmpty(metinTBox.Text) || bmp == null)
            {
                MessageBox.Show("Henüz bir dosya seçmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            Color pixel;
            int indisX = 0, indisY = 0;
            byte shiftX = 8;// (byte)rnd.Next(3);
            byte shiftY = 8;//(byte)rnd.Next(3);
            bool tersX = false, tersY = false;
            
            pBarCalis.Value = 15;
            
            bmp.SetPixel(indisX, indisY, Color.FromArgb(shift, shiftX, shiftY));
            
            indisX += shiftX;
            indisY += shiftY;
            
            for (int i = 0; i < text.Length; i++)
            {
                uint h = (uint)text[i];
                int indis = 0;
                int sh = 1;
                for (int k = 0; k < 6; k++)
                {
                    pixel = bmp.GetPixel(indisX + indis, indisY + indis);
                    uint r = pixel.R;
                    
                    if ((h & sh) != 0)
                    {
                        r = r | 0x00000001;
                    }
                    else
                    {
                        r = r & 0xfffffffa;
                    }

                    sh <<= 1;
                    uint g = pixel.G;
                    
                    if ((h & sh) != 0)
                    {
                        g = g | 0x00000001;
                    }
                    else
                    {
                        g = g & 0xfffffffa;
                    }
                    
                    sh <<= 1;
                    uint b = pixel.B;
                    
                    if ((h & sh) != 0)
                    {
                        b = b | 0x00000001;
                    }
                    else
                    {
                        b = b & 0xfffffffa;
                    }
                    
                    sh <<= 1;
                    bmp.SetPixel(indis + indisX, indis + indisY, Color.FromArgb((int)r, (int)g, (int)b));
                    indis++;
                }

                pBarCalis.Value = 50;

                if (force)
                {
                    if (!tersX)
                    {
                        indisX = indisX + shiftX;
                        if (indisX + shiftX > bmp.Width)
                        {
                            tersX = true;
                            indisX = indisX - shiftX;
                        }
                    }
                    else
                    {
                        indisX = indisX - shiftX;
                        if (indisX - shiftX < 0)
                        {
                            tersX = false;
                            indisX = indisX + shiftX;
                        }
                    }

                    if (!tersY)
                    {
                        indisY = indisY + shiftY;
                        if (indisY + shiftY > bmp.Height)
                        {
                            tersY = true;
                            indisY = indisY - shiftY;
                        }
                    }
                    else
                    {
                        indisY = indisY - shiftY;
                        if (indisY - shiftY < 0)
                        {
                            tersY = false;
                            indisY = indisY + shiftY;
                        }
                    }
                }
                else
                {
                    indisY = indisY + shiftY;
                    indisX = indisX + shiftX;
                }

            }

            bmp.SetPixel(indisX, indisY, Color.FromArgb(0, 0, 0));

            pBarCalis.Value = 90;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files (*.png) | *.png";
            saveFile.InitialDirectory = @"C:\Users\kadir\OneDrive\Desktop";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                ciktiPath.Text = saveFile.FileName.ToString();
                ciktiPBox.ImageLocation = ciktiPath.Text;
                bmp.Save(ciktiPath.Text);
            }
            bmp.Dispose();
            label4.Visible = false;
            pBarCalis.Value = 100;
        }
        private void Sifrele_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Sifrele_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
