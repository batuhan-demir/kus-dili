using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        char[] unluler = new char[16] { 'a', 'e', 'u', 'ü', 'ı', 'i', 'o', 'ö', 'A', 'E', 'U', 'Ü', 'I', 'İ', 'O', 'Ö' };

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
                        if (char.IsUpper(i))
                            metin += txtKus.Text + i.ToString();
                        else
                            metin += txtKus.Text + i.ToString().ToLower();
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
            if (sa == DialogResult.OK)
            {
                foreach (Control kontrol in Controls)
                {
                    if (kontrol is TextBox || kontrol is RichTextBox || kontrol is Label || kontrol is Button || kontrol is CheckBox)
                        kontrol.Font = fontDialog1.Font;
                }

            }
        }

        void AyarlariCek()
        {
            foreach (Control kontrol in Controls)
            {
                if (kontrol is TextBox || kontrol is RichTextBox || kontrol is Label || kontrol is Button || kontrol is CheckBox)
                    kontrol.Font = Properties.Settings.Default.font;
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
                (sender as PictureBox).BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

                if (cbKopyalandi.Checked)
                    MessageBox.Show("Başarıyla Kopyalandı!", "u/batu-_-batu", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                if (sonKopyalanan != kopya)
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
            timer1.Enabled = cbKopyaMetin.Checked;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            girilen.Text = "";

            Random rnd = new Random();
            (sender as PictureBox).BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.reddit.com/r/burdurland/");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.Red;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.Transparent;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.Gray;
        }

        private void pbAyarlar_Click(object sender, EventArgs e)
        {
            panelAyarlar.Visible = !panelAyarlar.Visible;

            pbAyarKaydet.BackColor = pbGuncelleme.BackColor = Color.Transparent;

            panelAyarlar.Location = new Point(34, 39);

        }
        private void pbGuncelleme_Click(object sender, EventArgs e)
        {
            Guncelleme(true);
        }

        void Guncelleme(bool mesajGoster = true)
        {
            WebClient wb = new WebClient();
            try
            {
                string surum = wb.DownloadString("https://raw.githubusercontent.com/batuhan-demir/kus-dili/master/README.md").Split(':').Last();
                surum = surum.Substring(2, surum.Length - 3);

                if (surum != Application.ProductVersion)
                {
                    pbGuncelleme.BackColor = Color.Red;

                    DialogResult msj = MessageBox.Show(string.Format("{0} Sürümü Mevcut.\nİndirme Sayfasına Gitmek İster Misiniz?", surum), "Güncelleme var!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (msj == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(wb.DownloadString("https://raw.githubusercontent.com/batuhan-demir/kus-dili/master/Son%20Versiyon"));
                    }
                }
                else
                {
                    pbGuncelleme.BackColor = Color.Green;

                    if (mesajGoster)
                        MessageBox.Show("En Son Sürümü Kullanıyorsunuz :)", "u/batu-_-batu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                if (mesajGoster)
                    MessageBox.Show("İnternetini Bir Kontrol Et", "Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblAyarKapat(object sender, EventArgs e)
        {
            panelAyarlar.Visible = false;
        }

        private void pbAyarKaydet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.otomatikYapistir = cbKopyaMetin.Checked;
            Properties.Settings.Default.enterTusuOnaylar = cbEnterTusu.Checked;
            Properties.Settings.Default.font = fontDialog1.Font;
            Properties.Settings.Default.kopyalandiBildirisi = cbKopyalandi.Checked;
            Properties.Settings.Default.arkaplanRenk = colorDialog1.Color;

                  Properties.Settings.Default.Save();

            (sender as PictureBox).BackColor = Color.Green;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cbKopyaMetin.Checked = Properties.Settings.Default.otomatikYapistir;
            cbEnterTusu.Checked = Properties.Settings.Default.enterTusuOnaylar;
            cbKopyalandi.Checked = Properties.Settings.Default.kopyalandiBildirisi;
            fontDialog1.Font = Properties.Settings.Default.font;
            cbUpdateOto.Checked = Properties.Settings.Default.otoUpdate;

            btnArkaplanRengi.BackColor = BackColor = Properties.Settings.Default.arkaplanRenk;
            btnFont.Font = fontDialog1.Font;
            

            foreach (Control kontrol in Controls)
            {
                if (kontrol is TextBox || kontrol is RichTextBox || kontrol is Label || kontrol is Button || kontrol is CheckBox)
                    kontrol.Font = fontDialog1.Font;
            }
            if (cbUpdateOto.Checked)
                Guncelleme(false);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (panelAyarlar.Visible)
                panelAyarlar.Visible = false;
        }

        private void btnArkaplanRengi_Click(object sender, EventArgs e)
        {
            DialogResult ase = colorDialog1.ShowDialog();
            if (ase == DialogResult.OK)
            {
                btnArkaplanRengi.BackColor = BackColor = colorDialog1.Color;
            }
        }

        private void lblUpperCase_Click(object sender, EventArgs e)
        {
            çıktı.Text = çıktı.Text.ToUpper();
        }

        private void lblDownCase_Click(object sender, EventArgs e)
        {
            çıktı.Text = çıktı.Text.ToLower();
        }
    }
}
