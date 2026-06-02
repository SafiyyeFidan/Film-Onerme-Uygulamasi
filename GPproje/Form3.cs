using GPproje;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GPproje
{
    public partial class Form3 : Form
    

    {
        private float yaricapDegisimi = 0;
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=GPproje;Integrated Security=True;TrustServerCertificate=True");

        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

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

        private void label1_Click_1(object sender, EventArgs e)
        {
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            DialogResult sonuc = MessageBox.Show("Enerjin harika! Haydi gel bu enerjiyi korumak için sana olan önerimizi gösterelim.", "Mod Seçildi");
            if (sonuc == DialogResult.OK || sonuc == DialogResult.Yes)
            {
                FilmGetirVeAc("Neşeli");
                this.Hide();
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;

            DialogResult sonuc = MessageBox.Show("Bazen sadece durup soluklanmak gerekir. Hadi gel, bu sakinliği birlikte renklendirelim!", "Mod Seçildi");
            if (sonuc == DialogResult.OK || sonuc == DialogResult.Yes)
            {
                FilmGetirVeAc("Normal");
                this.Hide();
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            DialogResult sonuc = MessageBox.Show("Her gecenin bir sabahı olduğunu unutma! Ruhuna iyi gelecek, seni biraz olsun uzaklaştıracak bir hikayeye...", "Mod Seçildi");
            if (sonuc == DialogResult.OK || sonuc == DialogResult.Yes)
            {
                FilmGetirVeAc("Üzgün");
                this.Hide();
            }
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            DialogResult sonuc = MessageBox.Show("Fırtınalar dinmek içindir. Şimdi derin bir nefes al ve zihnini rahatlatacak önerimizle sakinleş.", "Mod Seçildi");
            if (sonuc == DialogResult.OK || sonuc == DialogResult.Yes)
            {
                FilmGetirVeAc("Kızgın");
                this.Hide();
            }
        }


        private void FilmGetirVeAc(string secilenMod)
        {
            string sorgu = @"
        SELECT TOP 1 * FROM Filmler AS f 
        WHERE Mod = @pMod 
          AND ID NOT IN (SELECT FilmId FROM Izlenenler)
          AND (
              f.SiraNo = 1 
              OR f.SiraNo IS NULL 
              OR EXISTS (
                  SELECT 1 FROM Izlenenler 
                  WHERE FilmId = (
                      SELECT TOP 1 ID FROM Filmler 
                      WHERE SeriID = f.SeriID AND SiraNo = f.SiraNo - 1
                  )
              )
          )
        ORDER BY NEWID()";

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@pMod", secilenMod);
                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    string secilenFilmId = oku["ID"].ToString();
                    string filmAdi = oku["FilmAdi"].ToString();
                    string afisPath = oku["AfisPath"].ToString();
                    string fragmanLink = oku["FragmanLink"].ToString();
                    string konu = oku["Konu"].ToString();

                    oku.Close(); 

                    string kayitSorgusu = "INSERT INTO Izlenenler (KullaniciId, FilmId) VALUES (1, @filmId)";
                    SqlCommand kayitKomutu = new SqlCommand(kayitSorgusu, baglanti);
                    kayitKomutu.Parameters.AddWithValue("@filmId", secilenFilmId);
                    kayitKomutu.ExecuteNonQuery();

                    Form4 f4 = new Form4();
                    f4.GelenFilmAdi = filmAdi;
                    f4.GelenAfisPath = afisPath;
                    f4.GelenFragmanLink = fragmanLink;
                    f4.GelenFilmKonu = konu;

                    f4.Show();
                    this.Hide();
                }
                else
                {
                    oku.Close();
                    MessageBox.Show("Seçilen modda izlenmemiş film kalmadı veya sorgu boş döndü!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
    }
}