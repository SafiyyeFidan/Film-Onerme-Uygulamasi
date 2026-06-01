using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;



namespace GPproje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Properties.Settings1.Default.BeniHatirla == true)
            {
                // Eğer daha önce işaretlendiyse kutuları doldur ve kutucuğu seçili yap
                girisİsimtextbox.Text = Properties.Settings1.Default.KullaniciAdi;
                girisSifretextbox.Text = Properties.Settings1.Default.Sifre;
                checkBox1.Checked = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private float yaricapDegisimi = 0;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;


            yaricapDegisimi += 0.05f;

            float dynamicEffect = (float)Math.Sin(yaricapDegisimi) * 30;

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {

                float width = this.ClientRectangle.Width * 1.5f + dynamicEffect;
                float height = this.ClientRectangle.Height * 1.5f + dynamicEffect;
                float x = (this.ClientRectangle.Width - width) / 2;
                float y = (this.ClientRectangle.Height - height) / 2;

                path.AddEllipse(x, y, width, height);

                using (System.Drawing.Drawing2D.PathGradientBrush daireselFirca = new System.Drawing.Drawing2D.PathGradientBrush(path))
                {

                    daireselFirca.CenterColor = Color.FromArgb(200, 0, 0);


                    daireselFirca.SurroundColors = new Color[] { Color.Black };


                    daireselFirca.CenterPoint = new PointF(this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2);


                    e.Graphics.FillRectangle(daireselFirca, this.ClientRectangle);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }





        private void giristextbox_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Kutucuk işaretliyse bilgileri bilgisayarın hafızasına yaz
                Properties.Settings1.Default.KullaniciAdi = girisİsimtextbox.Text;
                Properties.Settings1.Default.Sifre = girisSifretextbox.Text;
                Properties.Settings1.Default.BeniHatirla = true;
                Properties.Settings1.Default.Save(); // Ayarları kalıcı olarak kaydet
            }
            else
            {
                // Kutucuk işaretli değilse hafızadaki eski bilgileri temizle
                Properties.Settings1.Default.KullaniciAdi = "";
                Properties.Settings1.Default.Sifre = "";
                Properties.Settings1.Default.BeniHatirla = false;
                Properties.Settings1.Default.Save();
            }




            using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0NO23VL\SQLEXPRESS;Initial Catalog=logingp;Integrated Security=True;TrustServerCertificate=True;"))

            
            {
                baglanti.Open();
                string sorgu = "SELECT COUNT(*) FROM dbo.Kullanicilar WHERE KullaniciAdi=@kadi AND Sifre=@sifre";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kadi", girisİsimtextbox.Text);
                    komut.Parameters.AddWithValue("@sifre", girisSifretextbox.Text);

                    int sonuc = (int)komut.ExecuteScalar();

                    // 1. DURUM: EĞER BİLGİLER DOĞRUYSA (Kullanıcı bulunduysa)
                    if (sonuc > 0)
                    {
                        
                        // SADECE VE SADECE BURASI ÇALIŞACAK
                        Form3 yeniForm = new Form3();
                        yeniForm.Show();
                        this.Hide(); // Mevcut giriş sayfasını gizler
                    }
                    // 2. DURUM: EĞER BİLGİLER YANLIŞSA
                    else
                    {
                        // YENİ SAYFAYI AÇMAYACAK, SADECE BU MESAJI VERECEK
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı! Lütfen tekrar deneyiniz.");
                    }
                }
            }
        }

        private void girisİsimtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitForm kyt = new KayitForm();
            kyt.ShowDialog();
        }
    }
}

