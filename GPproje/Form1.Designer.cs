namespace GPproje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            baslikLabel = new Label();
            btnGiris = new Button();
            sloganLabel = new Label();
            pictureBox2 = new PictureBox();
            lblBilgi = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // baslikLabel
            // 
            baslikLabel.BackColor = Color.Transparent;
            baslikLabel.Font = new Font("Goudy Old Style", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            baslikLabel.Location = new Point(201, 59);
            baslikLabel.Name = "baslikLabel";
            baslikLabel.Size = new Size(456, 222);
            baslikLabel.TabIndex = 0;
            baslikLabel.Text = "MOODLY";
            baslikLabel.TextAlign = ContentAlignment.MiddleCenter;
            baslikLabel.Click += label1_Click;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Transparent;
            btnGiris.FlatAppearance.BorderColor = Color.White;
            btnGiris.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Location = new Point(360, 311);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(136, 38);
            btnGiris.TabIndex = 1;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // sloganLabel
            // 
            sloganLabel.BackColor = Color.Transparent;
            sloganLabel.Font = new Font("Mistral", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            sloganLabel.Location = new Point(285, 245);
            sloganLabel.Name = "sloganLabel";
            sloganLabel.Size = new Size(343, 36);
            sloganLabel.TabIndex = 5;
            sloganLabel.Text = "\"Ruhuna en uygun hikayeyi keşfet.\"";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(805, 488);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.BackColor = Color.Transparent;
            lblBilgi.Font = new Font("Garamond", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBilgi.ForeColor = SystemColors.ButtonHighlight;
            lblBilgi.Location = new Point(717, 458);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(147, 17);
            lblBilgi.TabIndex = 4;
            lblBilgi.Text = "Ayarlar / Hakkımızda";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(742, 488);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 546);
            Controls.Add(pictureBox1);
            Controls.Add(lblBilgi);
            Controls.Add(sloganLabel);
            Controls.Add(pictureBox2);
            Controls.Add(btnGiris);
            Controls.Add(baslikLabel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MOODLY";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label baslikLabel;
        private Button btnGiris;
        private Label sloganLabel;
        private PictureBox pictureBox2;
        private Label lblBilgi;
        private PictureBox pictureBox1;
    }
}
