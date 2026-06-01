using System.Drawing;

namespace GPproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            float baslikSize = this.Width / 25f;
            if (baslikSize < 24) baslikSize = 24;
            baslikLabel.Font = new Font("Segoe UI", baslikSize, FontStyle.Bold);
            baslikLabel.AutoSize = true;
            baslikLabel.Location = new Point(
                (this.ClientSize.Width - baslikLabel.Width) / 2,
                (int)(this.ClientSize.Height * 0.35)
            );



            sloganLabel.AutoSize = true;
            sloganLabel.Location = new Point(
                (this.ClientSize.Width - sloganLabel.Width) / 2,
                baslikLabel.Location.Y + baslikLabel.Height + 10
            );


            btnGiris.Width = 200;
            btnGiris.Height = 50;
            btnGiris.Location = new Point(
                (this.ClientSize.Width - btnGiris.Width) / 2,
                sloganLabel.Location.Y + sloganLabel.Height + 30
            );



            int sagKenarBosluk = 50;


            lblBilgi.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            lblBilgi.AutoSize = true;

            lblBilgi.Location = new Point(
                this.ClientSize.Width - lblBilgi.Width - sagKenarBosluk,
                this.ClientSize.Height - 100
            );


            pictureBox1.Size = new Size(32, 32);
            pictureBox2.Size = new Size(32, 32);


            pictureBox2.Location = new Point(
                this.ClientSize.Width - pictureBox2.Width - sagKenarBosluk,
                lblBilgi.Location.Y + lblBilgi.Height + 12
            );


            pictureBox1.Location = new Point(
                pictureBox2.Location.X - pictureBox1.Width - 15,
                pictureBox2.Location.Y
            );

        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Form2 yeniSayfa = new Form2();


            yeniSayfa.Show();


            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hakkýmýzdaki görüþlerinizi bize iletebilirsiniz.Bizi tercih ettiðiniz için teþekkür ederiz!", "Hakkýmýzda / Ýletiþim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
    

