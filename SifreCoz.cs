using System;
using System.Drawing;
using System.IO;
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
        private void button2_Click(object sender, EventArgs e)
        {
            int indisX = 0, indisY = 0;
            bool tersX = false, tersY = false;
            
            StringBuilder sb = new StringBuilder();
            indisX = 0;
            indisY = 0;
            if (privateCheck.Checked)
            {
                indisX = Convert.ToInt32(indexX.Text);
                indisY = Convert.ToInt32(indexY.Text);
            }
            Color pixel = bmp.GetPixel(indisX, indisY);

            byte shift = pixel.R;
            byte shiftX = pixel.G;
            byte shiftY = pixel.B;
            
            indisX += shiftX; indisY += shiftY;

            

            do
            {
                uint m = 1;
                uint h = 0;
                int indis = 0;
                uint r,g,b;
                for (int j = 0; j < 8; j++)
                {
                    pixel = bmp.GetPixel(indis+indisX, indis+indisY);
                    r = (uint)pixel.R;
                    if ((r & 1) != 0)
                    {
                        h = (uint)(h | m);
                    }
                    m <<= 1;
                    g = (uint)pixel.G;
                    if ((g & 1) != 0)
                    {
                        h = (uint)(h | m);
                    }
                    m <<= 1;
                    b = (uint)pixel.B;
                    if ((b & 1) != 0)
                    {
                        h = (uint)(h | m);
                    }
                    m <<= 1;
                    indis++;
                }
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
