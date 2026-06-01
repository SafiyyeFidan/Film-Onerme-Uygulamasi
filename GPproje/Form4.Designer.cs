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
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            filmText = new Label();
            filmKonuText = new Label();
            label1 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Interstellar_film_poster;
            pictureBox1.Location = new Point(54, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 421);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // filmText
            // 
            filmText.AutoSize = true;
            filmText.BackColor = Color.Transparent;
            filmText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            filmText.Location = new Point(344, 86);
            filmText.Name = "filmText";
            filmText.Size = new Size(151, 28);
            filmText.TabIndex = 1;
            filmText.Text = "İNTERSTELLAR";
            // 
            // filmKonuText
            // 
            filmKonuText.BackColor = Color.Transparent;
            filmKonuText.Location = new Point(344, 202);
            filmKonuText.Name = "filmKonuText";
            filmKonuText.Size = new Size(294, 214);
            filmKonuText.TabIndex = 2;
            filmKonuText.Text = "konu yazacak burda";
            filmKonuText.Click += filmKonuText_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(344, 52);
            label1.Name = "label1";
            label1.Size = new Size(230, 25);
            label1.TabIndex = 3;
            label1.Text = "Karşında Bugünün Filmi :";
            // 
            // button1
            // 
            button1.Location = new Point(694, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Profile Git";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Location = new Point(345, 162);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(341, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://www.youtube.com/watch?v=zSWdZVtXT7E";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(345, 125);
            label2.Name = "label2";
            label2.Size = new Size(229, 25);
            label2.TabIndex = 6;
            label2.Text = "Fragmanı izlemek için tıkla:";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(filmKonuText);
            Controls.Add(filmText);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label filmText;
        private Label filmKonuText;
        private Label label1;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label2;
    }
}