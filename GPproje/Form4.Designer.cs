namespace GPproje
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            timer1 = new System.Windows.Forms.Timer(components);
            filmText = new Label();
            filmKonuText = new Label();
            label1 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            pbSol2 = new PictureBox();
            pbSol1 = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            pbSag1 = new PictureBox();
            pbSag2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbSol2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSol1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSag1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSag2).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // filmText
            // 
            filmText.AutoSize = true;
            filmText.BackColor = Color.Transparent;
            filmText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            filmText.Location = new Point(344, 86);
            filmText.Name = "filmText";
            filmText.Size = new Size(0, 28);
            filmText.TabIndex = 1;
            // 
            // filmKonuText
            // 
            filmKonuText.BackColor = Color.Transparent;
            filmKonuText.ForeColor = SystemColors.ButtonHighlight;
            filmKonuText.Location = new Point(238, 290);
            filmKonuText.Name = "filmKonuText";
            filmKonuText.Size = new Size(294, 161);
            filmKonuText.TabIndex = 2;
            filmKonuText.Click += filmKonuText_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(273, 36);
            label1.Name = "label1";
            label1.Size = new Size(259, 50);
            label1.TabIndex = 3;
            label1.Text = "Karşında Bugünün Filmi : ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(560, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Location = new Point(345, 162);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(119, 157);
            label2.Name = "label2";
            label2.Size = new Size(229, 25);
            label2.TabIndex = 6;
            label2.Text = "Fragmanı izlemek için tıkla:";
            label2.Click += label2_Click;
            // 
            // pbSol2
            // 
            pbSol2.Image = Properties.Resources._9992430418057233;
            pbSol2.Location = new Point(2, 225);
            pbSol2.Name = "pbSol2";
            pbSol2.Size = new Size(111, 226);
            pbSol2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSol2.TabIndex = 7;
            pbSol2.TabStop = false;
            pbSol2.Click += pictureBox1_Click;
            // 
            // pbSol1
            // 
            pbSol1.Image = Properties.Resources._9992430418057233;
            pbSol1.Location = new Point(2, 0);
            pbSol1.Name = "pbSol1";
            pbSol1.Size = new Size(111, 230);
            pbSol1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSol1.TabIndex = 8;
            pbSol1.TabStop = false;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 20;
            timer2.Tick += timer2_Tick_1;
            // 
            // pbSag1
            // 
            pbSag1.Image = Properties.Resources._9992430418057233;
            pbSag1.Location = new Point(675, 0);
            pbSag1.Name = "pbSag1";
            pbSag1.Size = new Size(125, 230);
            pbSag1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSag1.TabIndex = 9;
            pbSag1.TabStop = false;
            // 
            // pbSag2
            // 
            pbSag2.Image = Properties.Resources._9992430418057233;
            pbSag2.Location = new Point(675, 225);
            pbSag2.Name = "pbSag2";
            pbSag2.Size = new Size(125, 226);
            pbSag2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSag2.TabIndex = 10;
            pbSag2.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._8303580559589739;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pbSag2);
            Controls.Add(pbSag1);
            Controls.Add(pbSol1);
            Controls.Add(pbSol2);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(filmKonuText);
            Controls.Add(filmText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MOODLY";
            Load += Form4_Load_1;
            Paint += Form4_Paint;
            ((System.ComponentModel.ISupportInitialize)pbSol2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSol1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSag1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSag2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label filmText;
        private Label filmKonuText;
        private Label label1;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label2;
        private PictureBox pbSol2;
        private PictureBox pbSol1;
        private System.Windows.Forms.Timer timer2;
        private PictureBox pbSag1;
        private PictureBox pbSag2;
    }
}