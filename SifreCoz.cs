using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Steganografi
{
    public partial class SifreCoz : Form
    {
        public SifreCoz()
        {
            InitializeComponent();
        }
        static Bitmap bmp;
        static Image img;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Resim seç";
                    dlg.Filter = "Image Files(*.png) | *.png;";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        bmp = new Bitmap(dlg.FileName);
                        textBox2.Text = dlg.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata meydana geldi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                int indisX = 0, indisY = 0;
                if (bmp == null)// Resim dosyası seçilmediyse
                {
                    MessageBox.Show("Henüz bir resim dosya seçmediniz.", "Hata"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (privateCheck.Checked)//Özel anahtar girecek misin
                {
                    if (string.IsNullOrEmpty(indexX.Text) || string.IsNullOrEmpty(indexY.Text))//Özel anahtar kısmına veri girildi mi
                    {
                        MessageBox.Show("Private key kullanma seçeneğini işaretlediniz. Lütfen özel anahtarınızı giriniz."
                            , "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        //Başlangıç değerlerini özel anahtarlardan gelen verilere eşleştirmeyi dene
                        if (!(int.TryParse(indexX.Text, out indisX) || int.TryParse(indexY.Text, out indisY)))
                        {//Olmazsa hata 
                            MessageBox.Show("Lütfen geçerli bir özel anahtar kullanın."
                            , "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                bool tersX = false, tersY = false;

                StringBuilder sb = new StringBuilder();
                indisX = 0;
                indisY = 0;

                Color pixel = bmp.GetPixel(indisX, indisY);

                //sezar şifrelemede kullanılan kaydırma değişkenini  R,
                //X eksenindeki kaydırma değişkenini  G,
                //Y eksenindeki kaydırma değişkenini  B 
                //ayarlıyoruz.
                byte shift = pixel.R;
                byte shiftX = pixel.G;
                byte shiftY = pixel.B;


                indisX += shiftX; indisY += shiftY;



                do
                {
                    uint m = 1;//Maske tutucumuz
                    uint h = 0;//Char için kullanacağımız byte değeri
                    uint r, g, b;
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 2; k++)
                        {
                            pixel = bmp.GetPixel(j + indisX, k + indisY);
                            r = (uint)pixel.R;
                            if ((r & 1) != 0)// R değerinin LSB'si 1 ise
                            {
                                h = (uint)(h | m);//M maskesini kullanarak h değerini değiştir.
                            }
                            m <<= 1;
                            g = (uint)pixel.G;
                            if ((g & 1) != 0)//G değerinin LSB'si 1 ise
                            {
                                h = (uint)(h | m);//M maskesini kullanarak h değerini değiştir.
                            }
                            m <<= 1;
                            b = (uint)pixel.B;
                            if ((b & 1) != 0)//B değerinin LSB'si 1 ise
                            {
                                h = (uint)(h | m);//M maskesini kullanarak h değerini değiştir.
                            }
                            m <<= 1;//Mask'i sola shift ediyoruz. 1 değeri sürekli sola doğru kayıyor.
                                    //Bu sayede h değerinde değişiklik yapılcak bit sürekli değişiyor.
                        }

                    }
                    //Oluşturduğumuz h değerinden sezar ötleem değerini çıkarıyoruz.
                    //String tutucumuza elde ettiğimiz byte değerinee eşdeğer gelen char'ı ekliyoruz
                    sb.Append((char)(h - shift));

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
                } while (bmp.GetPixel(indisX, indisY) != Color.FromArgb(0, 0, 0));
                string text = sb.ToString();
                textBox1.Text = text;
                bmp.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata meydana geldi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SifreCoz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void SifreCoz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void privateCheck_CheckedChanged(object sender, EventArgs e)
        {
            indexX.ReadOnly = !privateCheck.Checked;
            indexY.ReadOnly = !privateCheck.Checked;
        }
    }
}
