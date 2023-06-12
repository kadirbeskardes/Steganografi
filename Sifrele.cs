using System;
using System.Drawing;
using System.Linq;
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
        private void girdiBut_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Resim seç";
                    dlg.Filter = "Image Files(*.PNG)|*.PNG;";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        bmp = new Bitmap(dlg.FileName);//Seçilen PNG dosyası Bitmap nesnesine getirildi.
                        girdiPath.Text = dlg.FileName;//Dosyanın dosya yolu girdiPath isimli textbox'a yazıldı.
                        girdiPBox.ImageLocation = dlg.FileName;//girdiPBox isimli PictureBox'a resim yerleştirildi.
                        label5.Visible = true;
                        girdiPBox.Visible = true;
                        panel2.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata meydana geldi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void calistirBut_Click(object sender, EventArgs e)
        {

        }
        private void Sifrele_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Sifrele_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void privateCheck_CheckedChanged(object sender, EventArgs e)
        {
            indexX.ReadOnly = !privateCheck.Checked;
            indexY.ReadOnly = !privateCheck.Checked;
        }

        private void calistirBut_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(metinTBox.Text))//Bir metin girilmediyse
                {
                    MessageBox.Show("Bir metin girişi yapmadınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (bmp == null)// Resim dosyası seçilmediyse
                {
                    MessageBox.Show("Henüz bir resim dosya seçmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string text = metinTBox.Text;// Text isimli değişkene metini giriyoruz.
                                             // metin boyutu imaj dosyasının sorunsuz bir şekilde şifreleyeceği
                                             // boyutu aşma ihtimaline karşı 'Metin boyutu fazla ise zorla şifrele'
                                             // seçeneği seçiliyse force değişkeni ile işlem yapacağız.
                bool force = false;


                if (forceSt.Checked)//'Metin boyutu fazla ise zorla şifrele' seçeneği seçiliyse
                {
                    MessageBox
                        .Show("Girilen metin uzunluğu bu resim dosyasının sorunsuz bir şekilde alabileceği boyutu " +
                        "aşıyorsa zorla şifreleme yapılacak. Bu normal işlemden, 5-10 saniye daha uzun sürebilir. " +
                        "Bu işlem sonucunda veri kaybı ihtimali daha düşük olabilir. Yine de oluşacak veri kaybında" +
                        " sorumluluk kabul etmiyoruz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    force = true;
                }
                int indisX = 0, indisY = 0;//İlk pixel kordinatları.,

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

                Random rnd = new Random();

                byte shiftX = 4;// (byte)rnd.Next(6, 8);// Kordinatlar X ekseninde ne kadar kayacak
                byte shiftY = 3;// (byte)rnd.Next(6, 8);// Kordinatlar Y ekseninde ne kadar kayacak


                //Eğer ki metin boyutu imaja ters shift yapmadan şifrelenemeyecek kadar yüksekse bu işlemler yapılacak.
                if (4 * (text.Length + shiftX) + indisX > bmp.Width || 4 * (text.Length + shiftY) + indisY > bmp.Height)
                {
                    DialogResult dr = MessageBox
                        .Show("Girilen metin uzunluğu bu resim dosyasının sorunsuz bir şekilde " +
                        "alabileceği boyutu aşıyor. Metini, resim dosyasına gizlemeye devam edebilirsiniz. Fakat oluşacak" +
                        " veri kaybında sorumluluk kabul etmiyoruz. 'Metin boyutu fazla ise zorla şifrele' seçeneğini " +
                        "seçtiyseniz 'OK' butonuna tıklayıp devam edebilirsiniz. "
                        , "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr != DialogResult.OK)
                    {
                        MessageBox.Show("Devam edilmedi.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                label4.Visible = true;
                pBarCalis.Visible = true;
                pBarCalis.Value = 5;
                label4.Refresh();

                // (0,0,0) veya (1,1,1) RGB değerlerine sahip pixeller algoritma için sıkıntı çıakrdığı için hepsi (2,2,2) yapıldı.
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

                if (shiftCheck.Checked)// Sezar şifreleme kullanılacaksa random shift değeri seçildi(Opsiyonel)
                {
                    shift = (byte)rnd.Next(15);
                }

                Color pixel;

                // Eğer kordinatlar Y veya X ekseninde sona ulaştıysa ters kaydırma için kullanılacak bool değişkenleri.
                bool tersX = false, tersY = false;
                pBarCalis.Value = 15;

                //R değeri olarak sezar şifrelemede kullanılan kaydırma değişkenini,
                //G değeri olarak X eksenindeki kaydırma değişkenini,
                //B değeri olarak Y eksenindeki kaydırma değişkenini
                //ayarlıyoruz.
                bmp.SetPixel(indisX, indisY, Color.FromArgb(shift, shiftX, shiftY));

                indisX += shiftX; // X kordinatını kaydırıyoruz
                indisY += shiftY; // Y kordinatını kaydırıyoruz1

                for (int i = 0; i < text.Length; i++)// Metun uzunluğu kadar dönüyoruz.
                {
                    // O harfin sayısal değerini elde ediyoruz. Opsiyonel olarak Sezar şifreleme kullandıysak Shift değeri de ekleniyor.
                    uint h = (uint)((uint)text[i] + shift);

                    int sh = 1;// Kulanılan mask
                    for (int k = 0; k < 3; k++)//6 Pixel'de işlem yapacağız
                    {
                        for (int m = 0; m < 2; m++)
                        {
                            pixel = bmp.GetPixel(indisX + k, indisY + m);// Seçili pixel'e indis ekleyerek ilerletiyoruz
                            uint r = pixel.R;//Pixel'deki r değerini aldık

                            if ((h & sh) != 0)// LSB'den MSB'Ye doğru tüm değerleri kontrol ediyoruz
                            {
                                r = r | 0x00000001;// Değer 1 ise R'nin LSB'yi 1 yapıyoruz.
                            }
                            else
                            {
                                r = r & 0xfffffffa;// Değer 0 ise R'nin LSB'yi 0 yapıyoruz.
                            }

                            sh <<= 1; // Mask'i sola shift ediyoruz
                            uint g = pixel.G;//Aynı işlemleri G için yapıyoruz

                            if ((h & sh) != 0)
                            {
                                g = g | 0x00000001;
                            }
                            else
                            {
                                g = g & 0xfffffffa;
                            }

                            sh <<= 1;
                            uint b = pixel.B;//Aynı işlemleri B için yapıyoruz

                            if ((h & sh) != 0)
                            {
                                b = b | 0x00000001;
                            }
                            else
                            {
                                b = b & 0xfffffffa;
                            }

                            sh <<= 1;
                            //Değiştirilmiş veriler ile yeni bir pixel oluşturup, önceden aldığımız pixel'in yerine yerleştiriyoruz.
                            bmp.SetPixel(indisX + k, indisY + m, Color.FromArgb((int)r, (int)g, (int)b));
                        }

                    }

                    pBarCalis.Value = 50;

                    if (force)// Eğer zorlama seçeneği aktifse
                    {
                        if (!tersX)// X ekseninde sona gelmedik ve + yöne mi gidiyoruz?
                        {
                            indisX = indisX + shiftX;//x ekseninde kordinatı kaydır
                            if (indisX + shiftX > bmp.Width)// X ekseninde sona geldik mi
                            {
                                tersX = true;//- yöne git
                                indisX = indisX - shiftX;//X ekseninde kordinatı - yönde kaydır
                            }
                        }
                        else// X ekseninde sona geldik ve - yöne mi gidiyoruz?
                        {
                            indisX = indisX - shiftX;//X ekseninde kordinatı ters yönde kaydır
                            if (indisX - shiftX < 0)// X ekseninde başa geldik mi
                            {
                                tersX = false;//+ yönüne git
                                indisX = indisX + shiftX;//+ yönünde ilerle
                            }
                        }

                        if (!tersY)// X ekseninde sona gelmedik ve + yöne mi gidiyoruz?
                        {
                            indisY = indisY + shiftY;//x ekseninde kordinatı kaydır
                            if (indisY + shiftY > bmp.Height)// X ekseninde sona geldik mi
                            {
                                tersY = true;//- yöne git
                                indisY = indisY - shiftY;//X ekseninde kordinatı - yönde kaydır
                            }
                        }
                        else// Y ekseninde sona geldik ve - yöne mi gidiyoruz?
                        {
                            indisY = indisY - shiftY;//Y ekseninde kordinatı ters yönde kaydır

                            if (indisY - shiftY < 0)// Y ekseninde başa geldik mi
                            {
                                tersY = false;//+ yönüne git
                                indisY = indisY + shiftY;//Y ekseninde kordinatı - yönde kaydır
                            }
                        }
                    }
                    else// Eğer zorlama seçeneği aktif değilse
                    {
                        indisY = indisY + shiftY;
                        indisX = indisX + shiftX;
                    }
                }

                bmp.SetPixel(indisX, indisY, Color.FromArgb(0, 0, 0)); //Son pixel'i (0,0,0) yap

                pBarCalis.Value = 90;
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Image Files (*.png) | *.png";//Kayıt için PNG filtre
                saveFile.InitialDirectory = @"C:\Users\kadir\OneDrive\Desktop";// Varsayılan olarak seçilen kayıt yeri

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    ciktiPath.Text = saveFile.FileName.ToString();
                    ciktiPBox.ImageLocation = ciktiPath.Text;
                    bmp.Save(ciktiPath.Text);
                    label6.Visible = true;
                    ciktiPBox.Visible = true;
                }

                #region Disable & Clear
                bmp.Dispose();// Bitmap kaynağını serbest bırakıyoruz

                metinTBox.ReadOnly = true;
                ciktiPath.ReadOnly = true;
                girdiPath.ReadOnly = true;

                //Tüm checkbox'ları unchecked hale getiriyoruz
                foreach (CheckBox checkBox in groupBox1.Controls.OfType<CheckBox>())
                {
                    checkBox.Checked = false;
                    checkBox.Enabled = false;
                }
                calistirBut.Enabled = false;

                label4.Visible = false;
                #endregion
                pBarCalis.Value = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata meydana geldi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
