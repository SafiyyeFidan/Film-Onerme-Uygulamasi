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
using System.Data.SqlClient;

namespace GPproje
{
    public partial class Form3 : Form
    {
        private float yaricapDegisimi = 0;

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

            string connectionString = @"Server=.\SQLEXPRESS;Database=GPproje;Trusted_Connection=True;TrustServerCertificate=True;";
            string sorgu = "SELECT TOP 1 FilmAdi, AfisPath, FragmanLink, Konu FROM Filmler WHERE Mod = @pMod ORDER BY NEWID()";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@pMod", secilenMod);

                    try
                    {
                        baglanti.Open();
                        SqlDataReader oku = komut.ExecuteReader();

                        if (oku.Read())
                        {
                            Form4 f4 = new Form4();

                           
                            f4.GelenFilmAdi = oku["FilmAdi"].ToString();
                            f4.GelenAfisPath = oku["AfisPath"].ToString();
                            f4.GelenFragmanLink = oku["FragmanLink"].ToString();
                            f4.GelenFilmKonu = oku["Konu"].ToString();

                            f4.Show();
                            this.Hide(); 
                        }
                        else
                        {
                            MessageBox.Show("Bu moda uygun bir film bulunamadı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SQL Bağlantı Hatası: " + ex.Message);
                    }
                }
            }
        }
    } 
} 