using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPproje
{
    public partial class Form4 : Form
    {
        // Form3'ten gönderilen verileri tutacak dışa açık (public) değişkenler
        public string GelenFilmAdi { get; set; }
        public string GelenAfisPath { get; set; }
        public string GelenFragmanLink { get; set; }
        public string GelenFilmKonu { get; set; }
        public int GelenSeriID { get; set; }
        public int GelenSiraNo { get; set; }

        public Form4()
        {
            InitializeComponent();
        }

        // Form4 ekrana açılırken çalışacak olan kısım
        private void Form4_Load_1(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            // Form3'ten başarıyla bir film adı geldiyse şablonu güncelliyoruz
            if (!string.IsNullOrEmpty(GelenFilmAdi))
            {
                // BAŞLARINDAKİ // İŞARETLERİNİ TAMAMEN KALDIRDIK:
                filmText.Text = GelenFilmAdi;
                filmKonuText.Text = GelenFilmKonu;
                linkLabel1.Text = GelenFragmanLink;

                // Afiş yükleme algoritması
                if (!string.IsNullOrEmpty(GelenAfisPath))
                {
                    if (GelenAfisPath.StartsWith("http://") || GelenAfisPath.StartsWith("https://"))
                    {
                        pictureBox1.ImageLocation = GelenAfisPath;
                    }
                    else
                    {
                        string tamYol = System.IO.Path.Combine(Application.StartupPath, GelenAfisPath);
                        if (System.IO.File.Exists(tamYol))
                        {
                            pictureBox1.ImageLocation = tamYol;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = GelenAfisPath;
                        }
                    }
                }

                // Afişin şık durması için:
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void filmKonuText_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(GelenFragmanLink) && GelenFragmanLink != "https://www.youtube.com")
            {
                try
                {
                   
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = GelenFragmanLink,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fragman linki açılırken bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}

        
        

        
    