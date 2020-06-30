using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*

    Bu yazılımın kodları u/batu-_-batu ya aittir.
    Lütfen bu programı değiştirerek veya değiştirmeyerek tekrar yayınlamayın ve üzerinden prim yapmayın
    İyi kullanımlar

*/
namespace kuguş_digiligi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[] unluler = new char[8] { 'a', 'e', 'u', 'ü', 'ı', 'i', 'o', 'ö' };

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = girilen.Text;
            foreach (char i in girilen.Text)
            {
                metin += i;
                foreach (char unlu in unluler)
                {
                    if (i == unlu)
                    {
                        metin += txtKus.Text + i;
                    }

                }
            }
            metin = metin.Substring(girilen.Text.Length, metin.Length - girilen.Text.Length);
            çıktı.Text = metin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin = girilen.Text;
            if (string.IsNullOrWhiteSpace(metin)) MessageBox.Show("Boş Yazı!", "Geçersiz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string total = "";
                string[] ayrilacak = metin.Split(new[] { txtKus.Text }, StringSplitOptions.None);
                foreach (string sa in ayrilacak)
                {
                    if (!string.IsNullOrWhiteSpace(sa))
                    {
                        total += sa.Substring(0, sa.Length - 1);
                    }
                }
                total += metin.Substring(metin.Length - 1, 1);

                if (total == metin)
                    MessageBox.Show("Bu Metin Kuş Dilinde Yazılmamış veya Yanlış Ayıraç Seçmişsiniz!", "u/batu-_-batu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                çıktı.Text = total;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
         DialogResult sa = fontDialog1.ShowDialog();
            if(sa == DialogResult.OK)
            {
                foreach(Control kontrol in Controls)
                {
                    if (kontrol is TextBox || kontrol is RichTextBox || kontrol is Label || kontrol is Button || kontrol is CheckBox)
                        kontrol.Font = fontDialog1.Font;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(çıktı.Text))
                MessageBox.Show("Boş Bir Yazıyı Kopyalamak Biraz Saçma Gibi Sanki?", "u/batu-_-batu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                Clipboard.SetText(çıktı.Text);

                Random rnd = new Random();
                label4.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                //MessageBox.Show("Başarıyla Kopyalandı!", "u/batu-_-batu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        string sonKopyalanan;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string kopya = Clipboard.GetText();

                if (kopya == "<= Temizle" || kopya == "Kopyala")
                    Clipboard.SetText(sonKopyalanan);

                if(sonKopyalanan != kopya)
                {
                    girilen.Text = kopya;

                    sonKopyalanan = kopya;
                }
            }
            catch
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBox1.Checked;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            girilen.Text = "";

            Random rnd = new Random();
            label5.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.reddit.com/r/burdurland/");
        }
    }
}
