namespace ÖğrenciNotSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            if (TxtSinav1.Text != "" && TxtSinav2.Text != "" && TxtSinav3.Text != "")
            {
                int s1, s2, s3, ort;
                string durum;
                s1 = Convert.ToInt16(TxtSinav1.Text);
                s2 = Convert.ToInt16(TxtSinav2.Text);
                s3 = Convert.ToInt16(TxtSinav3.Text);
                ort = (s1 + s2 + s3) / 3;
                if (s1 > 100 || s2 > 100 || s3 > 100)
                {
                    MessageBox.Show("Öğrencinin 100'ün üstünde bir not alması imkansız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    if (ort >= 50)
                    {
                        durum = "Geçti";
                    }

                    else
                    {
                        durum = "Kaldı";
                    }
                    TxtDurum.Text = durum;
                    TxtOrtalama.Text = ort.ToString();
                }
            }
            else
            {
                MessageBox.Show("Lütfen sınav notlarını giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int sayac = 0;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtDurum.Text != "" && TxtOrtalama.Text != "" && TxtAdSoyad.Text != "" && maskedTextBox1.Text != "" && comboBox1.SelectedIndex != -1)
            {
                string adsoyad, ders, numara;
                adsoyad = TxtAdSoyad.Text;
                ders = comboBox1.Text;
                numara = maskedTextBox1.Text;

                listBox1.Items.Add("Ad-Soyad: " + adsoyad + "   " + "Ders: " + ders + "   " + "No: " + numara + "   " +
                    "Ort: " + TxtOrtalama.Text + "   " + "Durum: " + TxtDurum.Text);
                sayac++;
                TxtOgrenciSayisi.Text = sayac.ToString();
            }
            else
            {
                if (TxtOrtalama.Text == "" && TxtDurum.Text == "" && TxtAdSoyad.Text != "" && maskedTextBox1.Text != "" && comboBox1.SelectedIndex != -1)
                {
                    MessageBox.Show("Lütfen öğrenciye ait not hesabını yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lütfen öğrenciye dahil bilgileri tam giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void BtnCizgi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("------------------------------------------------------------");
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdSoyad.Text = "";
            TxtOrtalama.Clear();
            TxtDurum.Text = "";
            TxtSinav1.Text = "";
            TxtSinav2.Text = "";
            TxtSinav3.Text = "";
            maskedTextBox1.Text = "";
            TxtAdSoyad.Focus();
            comboBox1.SelectedIndex = -1;

        }

        private void BtnListeTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            TxtOgrenciSayisi.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}