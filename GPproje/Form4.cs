using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPproje
{
    public partial class Form4 : Form
    {
        
        public string GelenFilmAdi { get; set; }
        public string GelenAfisPath { get; set; }
        public string GelenFragmanLink { get; set; }
        public string GelenFilmKonu { get; set; }
        public int GelenSeriID { get; set; }
        public int GelenSiraNo { get; set; }

        
        private float yaricapDegisimi = 0;
        

        public Form4()
        {
            InitializeComponent();
            
            this.DoubleBuffered = true;
        }

        /
        private void Form4_Load_1(object sender, EventArgs e)
        {
            filmText.Text = "";
            filmKonuText.Text = "";
            linkLabel1.Text = "";

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            if (!string.IsNullOrEmpty(GelenFilmAdi))
            {
                filmText.Text = GelenFilmAdi;
                filmKonuText.Text = GelenFilmKonu;
                linkLabel1.Text = GelenFragmanLink;
            }

           
            timer1.Interval = 30;
            timer1.Enabled = true;

            timer2.Interval = 20;
            timer2.Enabled = true;

            
            pbSol1.Height = this.Height;
            pbSol2.Height = this.Height;
            pbSag1.Height = this.Height;
            pbSag2.Height = this.Height;

            pbSol1.Top = 0;
            pbSol2.Top = -pbSol1.Height;
            pbSag1.Top = 0;
            pbSag2.Top = -pbSag1.Height;

           
           
        }

     
        private void Form4_Paint(object sender, PaintEventArgs e)
        {

        }

     
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            int akisHizi = 4;

            pbSol1.Top += akisHizi;
            pbSol2.Top += akisHizi;
            pbSag1.Top += akisHizi;
            pbSag2.Top += akisHizi;

            
            if (pbSol1.Top >= this.Height) { pbSol1.Top = pbSol2.Top - pbSol1.Height; }
            if (pbSol2.Top >= this.Height) { pbSol2.Top = pbSol1.Top - pbSol2.Height; }
            if (pbSag1.Top >= this.Height) { pbSag1.Top = pbSag2.Top - pbSag1.Height; }
            if (pbSag2.Top >= this.Height) { pbSag2.Top = pbSag1.Top - pbSag2.Height; }
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

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sinemaSesOynatici != null)
            {
                sinemaSesOynatici.Stop();
            }
        }

        private void filmKonuText_Click(object sender, EventArgs e) { }
        private void pictureBoxAfis_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form5 form5_Gecis = new Form5();

            
            form5_Gecis.Show();
            this.Close();

        }
    }
}